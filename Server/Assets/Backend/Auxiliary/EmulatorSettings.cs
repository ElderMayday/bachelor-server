using Assets.Backend.Noisers;



namespace Assets.Backend.Auxiliary
{
    /// <summary>
    /// Настройки запуска эмуляции
    /// </summary>
    public class EmulatorSettings
    {

        public EmulatorSettings()
        {

        }

        public EmulatorSettings(int _interval, double _step, bool _fast, double _range)
        {
            Interval = _interval;
            Step = _step;
            Fast = _fast;
            Range = _range;
        }



        /// <summary>
        /// Интервал обновления данных
        /// </summary>
        public int Interval { get; set; }
        
        /// <summary>
        /// Шаг изменения аргумента
        /// </summary>
        public double Step { get; set; }

        /// <summary>
        /// Флаг быстрой эмуляции
        /// </summary>
        public bool Fast { get; set; }

        /// <summary>
        /// Предел аргумента (для быстрой эмуляции)
        /// </summary>
        public double Range { get; set; }
    }
}
