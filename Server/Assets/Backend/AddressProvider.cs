using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;


namespace Assets.Backend
{
    public static class AddressProvider
    {
        static AddressProvider()
        {
            localIp = GetLocalIp();
            localMask = GetSubnetMask();
            broadcastIp = GetBroadcastIp();
        }

        public static List<IPAddress> GetLocalIp()
        {
            List<IPAddress> result = new List<IPAddress>();

            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList)
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    result.Add(ip);

            return result;
        }


        public static List<IPAddress> GetSubnetMask()
        {
            List<IPAddress> result = new List<IPAddress>();

            foreach (IPAddress ip in localIp)
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


        public static List<IPAddress> GetBroadcastIp()
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


        public static List<IPAddress> localIp;
        public static List<IPAddress> localMask;
        public static List<IPAddress> broadcastIp;
    }
}
