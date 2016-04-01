


namespace Assets.Backend.Noisers
{
    /// <summary>
    /// Генератор шума по нормальному распределению
    /// </summary>
    public sealed class NoiserNormal : Noiser
    {
        /// <summary>
        /// Создает генератор шума по заданному распределению
        /// </summary>
        /// <param name="_mean">Математическое ожидание</param>
        /// <param name="_deviation">Среднеквадратичное отклонение</param>
        public NoiserNormal(double _mean, double _deviation)
        {
            mean = _mean;
            deviation = _deviation;
        }

        public override double Get()
        {
            double sum = 0.0;

            for (int i = 0; i < 12; i++)
                sum += getRandom();

            sum = (sum - 6 )* deviation + mean;

            return sum;
        }



        /// <summary>
        /// Математическое ожидание
        /// </summary>
        private double mean;

        /// <summary>
        /// Среднеквадратичное отклонение
        /// </summary>
        private double deviation;
    }
}
