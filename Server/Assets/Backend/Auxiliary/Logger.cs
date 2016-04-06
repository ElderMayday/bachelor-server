using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

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
            System.IO.File.WriteAllText(filename, string.Empty);
        }

        /// <summary>
        /// Добавляет запись с учетом многопоточности
        /// </summary>
        /// <param name="message">Запись</param>
        public static void Add(string message)
        {
            lock (logs)
            {
                File.AppendAllText(filename, "[" + DateTime.Now.ToString("HH:mm:ss") + "] " + message + "\n", Encoding.GetEncoding("Windows-1251"));
                logs.Add("[" + DateTime.Now.ToString("HH:mm:ss") + "] " + message);
            }
        }



        /// <summary>
        /// Список сообщений
        /// </summary>
        private static List<string> logs;

        /// <summary>
        /// Имя лог-файла
        /// </summary>
        private static string filename = "Log.txt";
    }
}
