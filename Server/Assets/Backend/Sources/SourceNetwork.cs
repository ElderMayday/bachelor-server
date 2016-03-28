using System;
using System.Text;
using System.Globalization;
using System.Net;
using System.Net.Sockets;

using Assets.Backend.Auxiliary;
using Assets.Backend.Deserializers;

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
        /// Направление
        /// </summary>
        public Vector3 Direction { get; set; }



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

                        string package = Encoding.UTF8.GetString(bytes, 0, bytesLength);

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
        protected RotationAxis axis;

        /// <summary>
        /// Используемый десериализатор
        /// </summary>
        protected Deserializer deserializer;
    }
}