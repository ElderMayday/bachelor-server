using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Assets.Backend
{
    public class UdpThread
    {
        public UdpThread()
        {
            udpClient = new UdpClient();

            bytes = Encoding.UTF8.GetBytes("<server-request>");

            mustWork = true;

            thread = new Thread(doThread);
            thread.Name = "UDP";
            thread.Start();
        }

        public void Stop()
        {
            mustWork = false;
            thread.Join();
        }

        protected void doThread()
        {
            List<IPAddress> broadcastIp = AddressProvider.GetBroadcastIp();

            while (mustWork)
            {
                foreach (IPAddress ip in broadcastIp)
                {
                    IPEndPoint endPoint = new IPEndPoint(ip, 11000);

                    try
                    {
                        udpClient.Send(bytes, bytes.Length, endPoint);
                    }
                    catch (Exception e)
                    {
                    }
                }

                Thread.Sleep(1000);
            }
        }

        protected bool mustWork;
        protected byte[] bytes;
        protected UdpClient udpClient;
        protected Thread thread;
    }
}
