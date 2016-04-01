using System;
using System.Threading;

using Assets.Backend.Auxiliary;
using Assets.Backend.Noisers;

namespace Assets.Backend.Sources
{
    public sealed class SourceEmulatorLinear : SourceEmulator
    {
        /// <summary>
        /// Создает линейный источник-эмулятор данных
        /// </summary>
        /// <param name="_noiser"></param>
        /// <param name="_min"></param>
        /// <param name="_max"></param>
        /// <param name="_step"></param>
        public SourceEmulatorLinear(EmulatorSettings _emulatorSettings, Noiser _noiser, double _min, double _max) : base(_emulatorSettings, _noiser)
        {
            min = _min;
            max = _max;

            thread.Name = "SourceEmulatorLinear";
        }



        /// <summary>
        /// Вычисляет следующее выходное значение
        /// </summary>
        /// <returns>Выходное значение</returns>
        protected override double calculateNext()
        {
            return current;
        }

        /// <summary>
        /// Смещает текущий аргумент
        /// </summary>
        protected override void iterate()
        {
            if (isIncreasing)
            {
                if (current <= max)
                    current += settings.Step;
                else
                {
                    current = max;
                    isIncreasing = false;
                }
            }
            else
            {
                if (current >= min)
                    current -= settings.Step;
                else
                {
                    current = min;
                    isIncreasing = true;
                }
            }
        }



        /// <summary>
        /// Сейчас выходное значение увеличивается
        /// </summary>
        private bool isIncreasing = true;

        /// <summary>
        /// Максимальное значение
        /// </summary>
        private double max;

        /// <summary>
        /// Минимальное значение
        /// </summary>
        private double min;
    }
}
