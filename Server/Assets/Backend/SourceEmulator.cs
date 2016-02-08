using System.Threading;

namespace Backend
{
    public class SourceEmulator : Source
    {
        public SourceEmulator()
        {
            thread = new Thread(doThread);
            thread.Start();
            IsWorking = true;
            IsCorrect = true;
        }

        protected override void doThread()
        {
            float current = 0;
            float step = 5;
            int interval = 100;
            bool isIncreasing = true;       

            while (true)
            {
                if (isIncreasing)
                {
                    if (current <= 90)
                        current += step;
                    else
                    {
                        current = 90;
                        isIncreasing = false;
                    }
                }
                else
                {
                    if (current >= 0)
                        current -= step;
                    else
                    {
                        //current = 0;
                        isIncreasing = true;
                    }
                }

                DataFloat = current;
                Thread.Sleep(interval);
            }
        }
    }
}
