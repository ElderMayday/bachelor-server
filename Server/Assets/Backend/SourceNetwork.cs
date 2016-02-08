using System;
using System.Text;

using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Backend
{
    public class SourceNetwork : Source
    {
        public SourceNetwork()
        {
            thread = new Thread(doThread);
            thread.Start();
            IsWorking = false;
            IsCorrect = true;
        }

        protected override void doThread()
        {
            while (true)
            {
                IPAddress ip = IPAddress.Parse("192.168.100.3");
                IPEndPoint ipEndPoint = new IPEndPoint(ip, 11000);
                Socket socketListener = new Socket(ip.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                socketListener.Bind(ipEndPoint);
                socketListener.Listen(10);

                Socket socketHandler = socketListener.Accept();
                socketHandler.ReceiveTimeout = 1000;

                IsWorking = true;
                IsCorrect = true;

                while (true)
                {
                    byte[] bytes = new byte[1024];
                    int bytesLength = socketHandler.Receive(bytes);

                    string stringOriginal = Encoding.UTF8.GetString(bytes, 0, bytesLength);
                    string stringEdited;

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