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

            localIp = getLocalIp();
            localMask = getSubnetMask(localIp);
            broadcastIp = getBroadcastIp(localIp, localMask);

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


        protected List<IPAddress> getLocalIp()
        {
            List<IPAddress> result = new List<IPAddress>();

            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList)
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    result.Add(ip);

            return result;
        }


        protected List<IPAddress> getSubnetMask(List<IPAddress> address)
        {
            List<IPAddress> result = new List<IPAddress>();

            foreach (IPAddress ip in address)
            {
                foreach (var adapter in System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces())
                {
                    foreach (var unicastIPAddressInformation in adapter.GetIPProperties().UnicastAddresses)
                    {
                        if (unicastIPAddressInformation.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            if (ip.Equals(unicastIPAddressInformation.Address))
                            {
                                result.Add(unicastIPAddressInformation.IPv4Mask);
                            }
                        }
                    }
                }
            }

            return result;
        }


        protected List<IPAddress> getBroadcastIp(List<IPAddress> localIp, List<IPAddress> localMask)
        {
            List<IPAddress> result = new List<IPAddress>();

            for (int i = 0; i < localIp.Count; i++)
            {
                if (localMask[i].ToString() == "255.255.255.0")
                {
                    string s = localIp[i].ToString();
                    s = s.Substring(0, s.LastIndexOf('.'));
                    result.Add(IPAddress.Parse(s + ".255"));
                }

                if (localMask[i].ToString() == "255.255.0.0")
                {
                    string s = localIp[i].ToString();
                    s = s.Substring(0, s.LastIndexOf('.'));
                    s = s.Substring(0, s.LastIndexOf('.'));
                    result.Add(IPAddress.Parse(s + ".255.255"));
                }

                if (localMask[i].ToString() == "255.0.0.0")
                {
                    string s = localIp[i].ToString();
                    s = s.Substring(0, s.LastIndexOf('.'));
                    s = s.Substring(0, s.LastIndexOf('.'));
                    s = s.Substring(0, s.LastIndexOf('.'));
                    result.Add(IPAddress.Parse(s + ".255.255.255"));
                }
            }

            result.Add(IPAddress.Parse("255.255.255.255"));

            return result;
        }


        protected List<IPAddress> localIp;
        protected List<IPAddress> localMask;
        protected List<IPAddress> broadcastIp;

        protected bool mustWork;
        protected byte[] bytes;
        protected UdpClient udpClient;
        protected Thread thread;
    }
}
