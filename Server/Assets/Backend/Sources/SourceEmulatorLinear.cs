using System.Threading;

namespace Assets.Backend.Sources
{
    public class SourceEmulatorLinear : Source
    {
        public SourceEmulatorLinear() : base()
        {
            IsWorking = true;
            IsCorrect = true;
            thread.Name = "SourceEmulatorLinear";
        }

        protected override void doThread()
        {
            float current = 0;
            float step = 5;
            int interval = 100;
            float max = 90;
            float min = -90;

            bool isIncreasing = true;       

            while (true)
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

                DataFloat = current;
                Thread.Sleep(interval);
            }
        }
    }
}
