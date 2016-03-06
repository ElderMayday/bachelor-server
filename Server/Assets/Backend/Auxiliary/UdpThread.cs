using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;



namespace Assets.Backend.Auxiliary
{
    /// <summary>
    /// Обработчик UDP потока для посылания сообщений-приглашений клиентов
    /// </summary>
    public class UdpThread
    {
        /// <summary>
        /// Создает поток
        /// </summary>
        public UdpThread()
        {
            thread = new Thread(doThread);
            thread.Name = "UDP";
        }

        /// <summary>
        /// Запускает поток
        /// </summary>
        public void Start()
        {
            mustWork = true;
            thread.Start();
        }

        /// <summary>
        /// Останавливает поток
        /// </summary>
        public void Stop()
        {
            mustWork = false;
            thread.Join();
        }

        /// <summary>
        /// Флаг работы потока
        /// </summary>
        public bool isWorking { get; protected set; }



        /// <summary>
        /// Функция-обработчик потока
        /// </summary>
        protected void doThread()
        {
            UdpClient udpClient = new UdpClient();

            try
            {
                isWorking = true;

                byte[] bytes = Encoding.UTF8.GetBytes("<server-request>");

                List<IPAddress> broadcastIp = AddressProvider.GetBroadcastIp();

                while (mustWork)
                {
                    foreach (IPAddress ip in broadcastIp)
                    {
                        IPEndPoint endPoint = new IPEndPoint(ip, 11000);
                        udpClient.Send(bytes, bytes.Length, endPoint);
                    }

                    Thread.Sleep(1000);
                }
            }
            catch (ExceptionServer e)
            {
            }
            finally
            {
                isWorking = false;
            }
        }

        

        /// <summary>
        /// Флаг необходимости работы
        /// </summary>
        protected bool mustWork;

        /// <summary>
        /// Поток обновления данных
        /// </summary>
        protected Thread thread;
    }
}
