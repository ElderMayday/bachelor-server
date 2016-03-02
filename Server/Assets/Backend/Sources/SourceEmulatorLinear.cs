using Assets.Backend.Noisers;
using System.Threading;

namespace Assets.Backend.Sources
{
    public class SourceEmulatorLinear : SourceEmulator
    {
        public SourceEmulatorLinear(Noiser _noiser, double _min, double _max, double _step) : base(_noiser)
        {
            min = (float)_min;
            max = (float)_max;
            step = (float)_step;

            IsWorking = true;
            IsCorrect = true;
            thread.Name = "SourceEmulatorLinear";
        }

        protected override void doThread()
        {
            float current = 0;
            
            bool isIncreasing = true;       

            while (mustWork)
            {
                if (isIncreasing)
                {
                    if (current <= max)
                        current += step;
                    else
                    {
                        current = max;
                        isIncreasing = false;
                    }
                }
                else
                {
                    if (current >= min)
                        current -= step;
                    else
                    {
                        current = min;
                        isIncreasing = true;
                    }
                }

                DataPure = current;
                Thread.Sleep(interval);
            }
        }

        protected float max = 90;
        protected float min = -90;
        protected float step = 5;
    }
}
