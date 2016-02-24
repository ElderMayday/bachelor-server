using System;
using System.Threading;

namespace Assets.Backend.Sources
{
    public class SourceEmulatorSin : Source
    {
        public SourceEmulatorSin() : base()
        {
            IsWorking = true;
            IsCorrect = true;
            thread.Name = "SourceEmulatorSin";
        }

        protected override void doThread()
        {
            float current = 0;
            float step = 5;
            int interval = 100;

            while (true)
            {
                current += step;
                DataFloat = 90.0f * (float)Math.Sin(current * Math.PI / 180.0) + random.Next(-10, 10);
                Thread.Sleep(interval);
            }
        }
    }
}
