﻿


namespace Assets.Backend.Filters
{
    /// <summary>
    /// Фильтр скользящей средней
    /// </summary>
    public sealed class FilterMovingAverage : FilterFIR
    {
        /// <summary>
        /// Создает фильтр скользящей средней
        /// </summary>
        /// <param name="length">Порядок фильтра</param>
        public FilterMovingAverage(int length) : base(length)
        {
            double average = 1.0 / length;

            for (int i = 0; i < weight.Count; i++)
                weight[i] = average;
        }
    }
}
