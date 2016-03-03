using System.Collections.Generic;



namespace Assets.Backend.Auxiliary
{
    /// <summary>
    /// Журнал
    /// </summary>
    public static class Logger
    {
        /// <summary>
        /// Создает список записей
        /// </summary>
        static Logger()
        {
            logs = new List<string>();
        }

        /// <summary>
        /// Добавляет запись с учетом многопоточности
        /// </summary>
        /// <param name="message">Запись</param>
        public static void Add(string message)
        {
            lock (logs)
            {
                logs.Add(message);
            }
        }

        private static List<string> logs;
    }
}
