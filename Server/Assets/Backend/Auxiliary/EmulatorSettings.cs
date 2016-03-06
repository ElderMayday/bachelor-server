using Assets.Backend.Noisers;



namespace Assets.Backend.Auxiliary
{
    /// <summary>
    /// Настройки запуска эмуляции
    /// </summary>
    public class EmulatorSettings
    {
        public EmulatorSettings(Noiser _noiser, int _interval, double _step, bool _fast, double _range)
        {
            Noiser = _noiser;
            Interval = _interval;
            Step = _step;
            Fast = _fast;
            Range = _range;
        }



        /// <summary>
        /// Параметр - источние шума
        /// </summary>
        public Noiser Noiser { get; protected set; }

        /// <summary>
        /// Интервал обновления данных
        /// </summary>
        public int Interval { get; protected set; }
        
        /// <summary>
        /// Шаг изменения аргумента
        /// </summary>
        public double Step { get; protected set; }

        /// <summary>
        /// Флаг быстрой эмуляции
        /// </summary>
        public bool Fast { get; protected set; }

        /// <summary>
        /// Предел аргумента (для быстрой эмуляции)
        /// </summary>
        public double Range { get; protected set; }
    }
}
