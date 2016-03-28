using Assets.Backend.Auxiliary;
using System;
using System.Threading;

namespace Assets.Backend.Sources
{
    /// <summary>
    /// Абстрактный источник данных
    /// </summary>
    public abstract class Source : IThreadHandler
    {
        /// <summary>
        /// Создает источник данных
        /// </summary>
        public Source()
        {
            dataLock = new object();
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

            if (IsWorking == true)
                thread.Join();

            IsWorking = false;
        }
        
        /// <summary>
        /// Параметр - выходные данные
        /// </summary>
        public double Data
        {
            get { lock (dataLock) { return data; } }
            set { lock (dataLock) { data = value; } }
        }

        /// <summary>
        /// Параметр - флаг работы потока
        /// </summary>
        public bool IsWorking
        {
            get { lock (dataLock) { return isWorking; } }
            set { lock (dataLock) { isWorking = value; } }
        }

        /// <summary>
        /// Параметр - флаг корректности данных
        /// </summary>
        public bool IsCorrect
        {
            get { lock (dataLock) { return isCorrect; } }
            set { lock (dataLock) { isCorrect = value; } }
        }



        /// <summary>
        /// Функция-обработчик потока
        /// </summary>
        protected abstract void doThread();



        /// <summary>
        /// Объект блокировки данных
        /// </summary>
        protected object dataLock;

        /// <summary>
        /// Поле данных
        /// </summary>
        protected double data;

        /// <summary>
        /// Поле флага работы
        /// </summary>
        protected bool isWorking;

        /// <summary>
        /// Поле флага корректности данных
        /// </summary>
        protected bool isCorrect;

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
