using System;
using System.Collections.Generic;
using System.Threading;

using Assets.Backend.Noisers;
using Assets.Backend.Auxiliary;

namespace Assets.Backend.Sources
{
    public class SourceEmulatorFourier : SourceEmulator
    {
        /// <summary>
        /// Создает источник-эмулятор данных по функции частичной суммы ряда Фурье 
        /// </summary>
        /// <param name="_noiser"></param>
        /// <param name="_halfOffset"></param>
        /// <param name="_aList"></param>
        /// <param name="_bList"></param>
        public SourceEmulatorFourier(EmulatorSettings _emulatorSettings, double _halfOffset, List<double> _aList, List<double> _bList) : base(_emulatorSettings)
        {
            if (_aList.Count != _bList.Count)
                throw new ExceptionServer("Coefficient lists length mismatch");

            aList = _aList;
            bList = _bList;
            halfOffset = _halfOffset;

            order = aList.Count;

            thread.Name = "SourceEmulatorFourier";

            current = -Math.PI * order;
        }



        /// <summary>
        /// Подсчитывает частичную сумму ряда
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        protected override double calculateNext()
        {
            double result;

            result = halfOffset;

            for (int i = 0; i < order; i++)
                result += aList[i] * Math.Cos((i + 1) * current) + bList[i] * Math.Sin((i + 1) * current);

            return result;
        }



        /// <summary>
        /// Списки коэффициентов ряда
        /// </summary>
        protected List<double> aList, bList;

        /// <summary>
        /// Порядок суммы
        /// </summary>
        protected int order;

        /// <summary>
        /// Смещение ряда
        /// </summary>
        protected double halfOffset;
    }
}
