


namespace Assets.Backend.Auxiliary
{
    /// <summary>
    /// Интерфейс - менеджер потока
    /// </summary>
    interface IThreadHandler
    {
        /// <summary>
        /// Запускает поток
        /// </summary>
        void Start();


        /// <summary>
        /// Завершает поток
        /// </summary>
        void Stop();
    }
}
