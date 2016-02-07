using System;
using System.Text;

using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Backend
{
    public class NetworkThread
    {
        public string stringOriginal { get; private set; }
        public string stringEdited { get; private set; }
        public float DataFloat { get; private set; }
        public bool IsWorking { get; private set; }
        public bool IsCorrect { get; private set; }

        protected Thread thread;

        public NetworkThread()
        {
            thread = new Thread(doThread);
            thread.Start();
            IsWorking = false;
            IsCorrect = true;
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
                IsCorrect = true;
                socketHandler.ReceiveTimeout = 1000;

                while (true)
                {
                    byte[] bytes = new byte[1024];
                    int bytesLength = socketHandler.Receive(bytes);
                    stringOriginal = Encoding.UTF8.GetString(bytes, 0, bytesLength);

                    int index1 = stringOriginal.IndexOf('<');
                    int index2 = stringOriginal.IndexOf('>');



                    if ((index1 != -1) && (index2 != -1))
                    {
                        stringEdited = stringOriginal.Substring(index1 + 1, index2 - index1 - 1);
                        stringEdited = stringEdited.Replace('.', ',');
                    }
                    else
                    {
                        stringEdited = "0";
                        IsCorrect = false;
                    }

                    try
                    {
                        DataFloat = (float)Convert.ToDouble(stringEdited);
                        IsCorrect = true;
                    }
                    catch (FormatException e)
                    {
                        IsCorrect = false;
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
    }
}