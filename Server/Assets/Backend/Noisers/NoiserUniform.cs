


namespace Assets.Backend.Noisers
{
    /// <summary>
    /// Генератор равномерного шума
    /// </summary>
    public class NoiserUniform : Noiser
    {
        /// <summary>
        /// Создает генератор равномерного шума
        /// </summary>
        /// <param name="_min">Минимальное значение</param>
        /// <param name="_max">Максимальное значение</param>
        public NoiserUniform(double _min, double _max)
        {
            min = _min;
            max = _max;
        }

        public override double Get()
        {
            return min + (max - min) * getRandom();
        }



        /// <summary>
        /// Минимальное значение
        /// </summary>
        protected double min;

        /// <summary>
        /// Максимальное значение
        /// </summary>
        protected double max;
    }
}
