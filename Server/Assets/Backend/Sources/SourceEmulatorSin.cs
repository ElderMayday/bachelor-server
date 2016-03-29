using System;
using System.Threading;

using Assets.Backend.Auxiliary;
using Assets.Backend.Noisers;


namespace Assets.Backend.Sources
{
    public class SourceEmulatorSin : SourceEmulator
    {
        /// <summary>
        /// Создает синусоидальный источник-эмулятор данных
        /// </summary>
        /// <param name="_noiser"></param>
        /// <param name="_step"></param>
        /// <param name="_amplitude"></param>
        /// <param name="_average"></param>
        public SourceEmulatorSin(EmulatorSettings _emulatorSettings, Noiser _noiser, double _amplitude, double _average, double _period) : base(_emulatorSettings, _noiser)
        {
            amplitude = _amplitude;
            average = _average;
            period = _period;

            thread.Name = "SourceEmulatorSin";
        }



        /// <summary>
        /// Вычисляет следующее выходное значение
        /// </summary>
        /// <returns>Выходное значение</returns>
        protected override double calculateNext()
        {
            return amplitude * Math.Sin(2.0 * Math.PI / period * current) + average;
        }



        /// <summary>
        /// Амплитуда
        /// </summary>
        protected double amplitude;

        /// <summary>
        /// Смещение
        /// </summary>
        protected double average;

        /// <summary>
        /// Период
        /// </summary>
        protected double period;
    }
}
