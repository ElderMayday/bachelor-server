using System;
using System.Text;

using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Backend
{
    public class NetworkThread
    {
        public string Data { get; private set; }
        public float DataFloat { get; private set; }
        public bool IsWorking { get; private set; }

        protected Thread thread;

        public NetworkThread()
        {
            thread = new Thread(doThread);
            thread.Start();
            IsWorking = false;
        }

        public void doThread()
        {
            while (true)
            {
                IPAddress ip = IPAddress.Parse("192.168.100.3");
                IPEndPoint ipEndPoint = new IPEndPoint(ip, 11000);
                Socket socketListener = new Socket(ip.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                socketListener.Bind(ipEndPoint);
                socketListener.Listen(10);
                Socket socketHandler = socketListener.Accept();
                IsWorking = true;
                socketHandler.ReceiveTimeout = 500;

                while (true)
                {
                    byte[] bytes = new byte[1024];
                    int bytesLength = socketHandler.Receive(bytes);
                    Data = Encoding.UTF8.GetString(bytes, 0, bytesLength);
                    DataFloat = (float)Convert.ToDouble(Data);

                    if (bytesLength == 0)
                        break;
                }

                IsWorking = false;
                socketListener.Close();
                ipEndPoint = null;
            }
        }
    }
}