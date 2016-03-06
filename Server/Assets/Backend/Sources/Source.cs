using System;
using System.Threading;

namespace Assets.Backend.Sources
{
    /// <summary>
    /// Абстрактный источник данных
    /// </summary>
    public abstract class Source
    {
        /// <summary>
        /// Создает источник данных
        /// </summary>
        public Source()
        {
            thread = new Thread(doThread);
            mustWork = true;
            random = new Random();
            IsWorking = false;
        }

        /// <summary>
        /// Запускает поток обновления данных
        /// </summary>
        public virtual void Start()
        {
            IsWorking = true;
            thread.Start();
        }

        /// <summary>
        /// Останавливает поток обновления данных
        /// </summary>
        public virtual void Stop()
        {
            mustWork = false;
            thread.Join();
            IsWorking = false;
        }
        
        /// <summary>
        /// Параметр - выходные данные
        /// </summary>
        public double Data { get; protected set; }

        /// <summary>
        /// Параметр - флаг работы потока
        /// </summary>
        public bool IsWorking { get; protected set; }

        /// <summary>
        /// Параметр - флаг корректности данных
        /// </summary>
        public bool IsCorrect { get; protected set; }



        /// <summary>
        /// Функция-обработчик потока
        /// </summary>
        protected abstract void doThread();

        /// <summary>
        /// Генератор случайных чисел
        /// </summary>
        protected Random random;

        /// <summary>
        /// Поток обновления данных
        /// </summary>
        protected Thread thread;

        /// <summary>
        /// Флаг необходимости продолжения работы
        /// </summary>
        protected bool mustWork;
    }
}
