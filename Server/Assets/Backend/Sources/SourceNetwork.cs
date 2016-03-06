using System;
using System.Text;
using System.Globalization;
using System.Net;
using System.Net.Sockets;



namespace Assets.Backend.Sources
{
    /// <summary>
    /// Сетевой источник данных
    /// </summary>
    public class SourceNetwork : Source
    {
        /// <summary>
        /// Создает сетевой источник данных
        /// </summary>
        /// <param name="_axis">выбранная ось вращения</param>
        /// <param name="_ipAddress">IP-адрес сервера</param>
        public SourceNetwork(Axis _axis, IPAddress _ipAddress) : base()
        {
            IsWorking = false;
            axis = _axis;
            thread.Name = "SourceNetwork";
            ipAddress = _ipAddress;
        }

        /// <summary>
        /// Останавливает поток обновления данных (закрывает сокет)
        /// </summary>
        public override void Stop()
        {
            mustWork = false;

            try
            {
                socketListener.Shutdown(SocketShutdown.Both);
            }
            catch (Exception e)
            {
                exception = e;
            }

            socketListener.Close();

            thread.Join();
        }



        /// <summary>
        /// Тангаж
        /// </summary>
        public double Pitch { get; protected set; }

        /// <summary>
        /// Крен
        /// </summary>
        public double Roll { get; protected set; }

        /// <summary>
        /// Рысканье
        /// </summary>
        public double Yaw { get; protected set; }



        /// <summary>
        /// Функция-обработчик потока
        /// </summary>
        protected override void doThread()
        {
            try
            {
                while (mustWork)
                {
                    IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, 11000);
                    socketListener = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                    socketListener.Bind(ipEndPoint);
                    socketListener.Listen(10);

                    Socket socketHandler = socketListener.Accept();
                    socketHandler.ReceiveTimeout = 1000;

                    IsWorking = true;
                    IsCorrect = true;

                    while (mustWork)
                    {
                        byte[] bytes = new byte[1024];
                        int bytesLength = socketHandler.Receive(bytes);

                        string stringOriginal = Encoding.UTF8.GetString(bytes, 0, bytesLength);
                        string stringEdited;

                        int index1 = stringOriginal.IndexOf('<');
                        int index2 = stringOriginal.IndexOf('>');

                        if ((index1 != -1) && (index2 != -1) && (index2 >= index1))
                            stringEdited = stringOriginal.Substring(index1 + 1, index2 - index1 - 1);
                        else
                        {
                            IsCorrect = false;
                            throw new Exception("Block borders are not found");
                        }

                        string[] parameters = stringEdited.Split(';');

                        try
                        {
                            Pitch = double.Parse(parameters[0], CultureInfo.InvariantCulture);
                            Roll = double.Parse(parameters[1], CultureInfo.InvariantCulture);
                            Yaw = double.Parse(parameters[2], CultureInfo.InvariantCulture);
                            IsCorrect = true;
                        }
                        catch (FormatException e)
                        {
                            IsCorrect = false;
                        }

                        switch (axis)
                        {
                            case Axis.Pitch: Data = Pitch; break;
                            case Axis.Roll: Data = Roll; break;
                            case Axis.Yaw: Data = Yaw; break;
                        }

                        if (bytesLength == 0)
                            break;
                    }

                    IsWorking = false;
                    IsCorrect = true;
                    socketListener.Close();
                    ipEndPoint = null;
                }
            }
            catch (Exception e)
            {
                exception = e;
            }
        }



        /// <summary>
        /// IP-адрес сервера
        /// </summary>
        protected IPAddress ipAddress;

        /// <summary>
        /// Сокет сервера
        /// </summary>
        protected Socket socketListener;

        /// <summary>
        /// Полученное исключение
        /// </summary>
        protected Exception exception;

        /// <summary>
        /// Выбранная ось
        /// </summary>
        protected Axis axis;
    }
}