using System.Threading;

using Assets.Backend.Noisers;



namespace Assets.Backend.Sources
{
    public class SourceEmulatorLinear : SourceEmulator
    {
        public SourceEmulatorLinear(Noiser _noiser, double _min, double _max, double _step) : base(_noiser)
        {
            min = _min;
            max = _max;
            step = _step;

            IsWorking = true;
            IsCorrect = true;
            thread.Name = "SourceEmulatorLinear";
        }

        protected override void doThread()
        {
            double current = 0;
            
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

        protected double max = 90;
        protected double min = -90;
        protected double step = 5;
    }
}
