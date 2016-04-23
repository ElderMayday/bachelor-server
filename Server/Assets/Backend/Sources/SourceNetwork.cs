using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

using Assets.Backend.Auxiliary;
using Assets.Backend.Deserializers;

namespace Assets.Backend.Sources
{
    /// <summary>
    /// Сетевой источник данных
    /// </summary>
    public sealed class SourceNetwork : Source
    {
        /// <summary>
        /// Создает сетевой источник данных
        /// </summary>
        /// <param name="_axis">выбранная ось вращения</param>
        /// <param name="_ipAddress">IP-адрес сервера</param>
        public SourceNetwork(RotationAxis _axis, IPAddress _ipAddress) : base()
        {
            IsWorking = false;
            axis = _axis;
            thread.Name = "SourceNetwork";
            ipAddress = _ipAddress;
            deserializer = new DeserializerCustom();
        }

        /// <summary>
        /// Останавливает поток обновления данных (закрывает сокет)
        /// </summary>
        public override void Stop()
        {
            mustWork = false;

            closeSocket(); 

            thread.Join();
        }



        /// <summary>
        /// Направление
        /// </summary>
        public Vector3 Direction { get; set; }



        /// <summary>
        /// Функция-обработчик потока
        /// </summary>
        protected override void doThread()
        {
            while (mustWork)
            {
                try
                {
                    IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, 11000);
                    socketListener = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                    socketListener.Bind(ipEndPoint);
                    socketListener.Listen(10);

                    Logger.Add("Accepting connection");
                    Socket socketHandler = socketListener.Accept();
                    Logger.Add("Accepted connection");

                    socketHandler.ReceiveTimeout = 3000;

                    IsWorking = true;             

                    while (mustWork)
                    {
                        byte[] bytes = new byte[1024];
                        int bytesLength = socketHandler.Receive(bytes);

                        string package = Encoding.UTF8.GetString(bytes, 0, bytesLength);

                        IsCorrect = true;

                        try
                        {
                            Direction = deserializer.Do(package);
                        }
                        catch (Exception e)
                        {
                            IsCorrect = false;
                        }

                        switch (axis)
                        {
                            case RotationAxis.Pitch: Data = Direction.X; break;
                            case RotationAxis.Roll: Data = Direction.Y; break;
                            case RotationAxis.Yaw: Data = Direction.Z; break;
                        }

                        if (bytesLength == 0)
                            break;
                    }

                    IsWorking = false;
                    IsCorrect = true;
                    socketListener.Close();
                    ipEndPoint = null;
                }
                catch (Exception e)
                {
                    exception = new ExceptionServer(e.Message);
                    closeSocket();
                }
            }
        }



        /// <summary>
        /// Закрывает сокет
        /// </summary>
        private void closeSocket()
        {
            try
            {
                socketListener.Shutdown(SocketShutdown.Both);
            }
            catch (Exception e)
            {
                exception = new ExceptionServer(e.Message);
            }

            socketListener.Close();
        }



        /// <summary>
        /// IP-адрес сервера
        /// </summary>
        private IPAddress ipAddress;

        /// <summary>
        /// Сокет сервера
        /// </summary>
        private Socket socketListener;

        /// <summary>
        /// Полученное исключение
        /// </summary>
        private ExceptionServer exception;

        /// <summary>
        /// Выбранная ось
        /// </summary>
        private RotationAxis axis;

        /// <summary>
        /// Используемый десериализатор
        /// </summary>
        private Deserializer deserializer;
    }
}