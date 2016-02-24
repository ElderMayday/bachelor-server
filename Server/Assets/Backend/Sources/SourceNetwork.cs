using System;
using System.Text;
using System.Globalization;

using System.Net;
using System.Net.Sockets;

namespace Assets.Backend.Sources
{
    public class SourceNetwork : Source
    {
        public SourceNetwork() : base()
        {
            IsWorking = false;
            IsCorrect = true;
            thread.Name = "SourceNetwork";
        }


        protected override void doThread()
        {
            while (mustWork)
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
                        stringEdited = "0";
                        IsCorrect = false;
                    }

                    try
                    {
                        DataFloat = Single.Parse(stringEdited, CultureInfo.InvariantCulture);
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