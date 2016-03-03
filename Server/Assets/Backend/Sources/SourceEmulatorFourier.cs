using System;
using System.Collections.Generic;
using System.Threading;

using Assets.Backend.Noisers;
using Assets.Backend.Auxiliary;

namespace Assets.Backend.Sources
{
    public class SourceEmulatorFourier : SourceEmulator
    {
        public SourceEmulatorFourier(Noiser _noiser, double _halfOffset, List<double> _aList, List<double> _bList) : base(_noiser)
        {
            if (_aList.Count != _bList.Count)
                throw new ExceptionServer("Coefficient lists length mismatch");

            aList = _aList;
            bList = _bList;
            halfOffset = _halfOffset;

            order = aList.Count;

            IsWorking = true;
            IsCorrect = true;
            thread.Name = "SourceEmulatorFourier";
        }

        protected override void doThread()
        {
            double current = -Math.PI * order;

            while (mustWork)
            {
                DataPure = calculate(current);
                Thread.Sleep(interval);
                current += 0.1;
            }
        }

        protected double calculate(double x)
        {
            double result;

            result = halfOffset;

            for (int i = 0; i < order; i++)
                result += aList[i] * Math.Cos((i + 1) * x) + bList[i] * Math.Sin((i + 1) * x);

            return result;
        }

        protected List<double> aList, bList;
        protected int order;
        protected double halfOffset;
    }
}
