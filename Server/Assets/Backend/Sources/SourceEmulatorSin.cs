using System;
using System.Threading;

using Assets.Backend.Noisers;



namespace Assets.Backend.Sources
{
    public class SourceEmulatorSin : SourceEmulator
    {
        public SourceEmulatorSin(Noiser _noiser, double _step, double _amplitude, double _average) : base(_noiser)
        {
            step = _step;
            amplitude = _amplitude;
            average = _average;

            IsWorking = true;
            IsCorrect = true;
            thread.Name = "SourceEmulatorSin";
        }

        protected override void doThread()
        {
            double current = 0.0;

            while (mustWork)
            {
                current += step;
                DataPure = amplitude * Math.Sin(current * Math.PI / 180.0) + average;
                Thread.Sleep(interval);
            }
        }

        protected double step;
        protected double amplitude;
        protected double average;
    }
}
