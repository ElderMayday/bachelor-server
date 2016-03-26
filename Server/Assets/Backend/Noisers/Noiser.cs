using System;



namespace Assets.Backend.Noisers
{
    /// <summary>
    /// Абстрактный генератор шума
    /// </summary>
    public abstract class Noiser
    {
        /// <summary>
        /// Создает генератор шума
        /// </summary>
        public Noiser()
        {
            random = new Random();
        }

        /// <summary>
        /// Получить следующую случайную величину
        /// </summary>
        /// <returns></returns>
        public abstract double Get();



        /// <summary>
        /// Получает случайную величину с равномерным распределением от 0 до 1
        /// </summary>
        /// <returns></returns>
        protected double getRandom()
        {
            return random.Next(1, 1000) / 1000.0;
        }



        private Random random;
    }
}
