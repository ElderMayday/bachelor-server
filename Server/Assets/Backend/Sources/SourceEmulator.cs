using Assets.Backend.Auxiliary;
using Assets.Backend.Noisers;
using System.Threading;



namespace Assets.Backend.Sources
{
    /// <summary>
    /// Абстрактный эмулятор
    /// </summary>
    public abstract class SourceEmulator : Source
    {
        /// <summary>
        /// Создает источник-эмулятор данных
        /// </summary>
        /// <param name="_noiser"></param>
        /// <param name="_interval"></param>
        public SourceEmulator(EmulatorSettings _emulatorSettings, Noiser _noiser)
        {
            noiser = _noiser;
            settings = _emulatorSettings;
            IsCorrect = true;
        }

        /// <summary>
        /// Параметр - данные без добавленного шума
        /// </summary>
        public double DataPure
        {
            get { return dataPure; }
            protected set { dataPure = value; Data = value + noiser.Get(); }
        }

        /// <summary>
        /// Получить следующий вывод синхронно
        /// </summary>
        /// <returns></returns>
        public virtual double GetNext()
        {
            if (settings.Fast)
            {
                double result;
                result = calculateNext();
                DataPure = result;
                iterate();
                return Data;
            }
            else
                throw new ExceptionServer("Incorrect operation");
        }



        /// <summary>
        /// Функция-обработчик потока
        /// </summary>
        protected override void doThread()
        {
            if (!settings.Fast)
            {
                while (mustWork)
                {
                    DataPure = calculateNext();
                    Thread.Sleep(settings.Interval);
                    iterate();
                }
            }
            else
                throw new ExceptionServer("Incorrect operation");
        }

        /// <summary>
        /// Вычисляет следующее выходное значение
        /// </summary>
        /// <returns>Выходное значение</returns>
        protected abstract double calculateNext();

        /// <summary>
        /// Смещает текущий аргумент
        /// </summary>
        protected virtual void iterate()
        {
            current += settings.Step;
        }



        /// <summary>
        /// Интервал обновления данных
        /// </summary>
        protected EmulatorSettings settings;

        /// <summary>
        /// Источник искуственного шума
        /// </summary>
        protected Noiser noiser;
        
        /// <summary>
        /// Данные без добавления шума
        /// </summary>
        protected double dataPure;

        /// <summary>
        /// Текущий аргумент
        /// </summary>
        protected double current;
    }
}
