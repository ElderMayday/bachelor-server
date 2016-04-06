using System;
using System.Runtime.Serialization;

namespace Assets.Backend.Auxiliary
{
    /// <summary>
    /// Подкласс исключений для всего проекта
    /// </summary>
    public class ExceptionServer : Exception, ISerializable
    {
        /// <summary>
        /// Создает исключение и заносит его в журнал
        /// </summary>
        /// <param name="description">Описание исключения</param>
        public ExceptionServer(string description) : base(description)
        {
            Logger.Add("[EXCEPTION] " + description);
        }
    }
}
