using System;



namespace Assets.Backend.Auxiliary
{
    /// <summary>
    /// Подкласс исключений для всего проекта
    /// </summary>
    public class ExceptionServer : Exception
    {
        /// <summary>
        /// Создает исключение и заносит его в журнал
        /// </summary>
        /// <param name="description">Описание исключения</param>
        public ExceptionServer(string description) : base(description)
        {
            Logger.Add("server-exception: " + description);
        }
    }
}
