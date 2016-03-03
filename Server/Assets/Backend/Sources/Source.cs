using System;
using System.Threading;

namespace Assets.Backend.Sources
{
    public abstract class Source
    {
        public double Data { get; protected set; }
        public bool IsWorking { get; protected set; }
        public bool IsCorrect { get; protected set; }

        public Source()
        {
            thread = new Thread(doThread);
            mustWork = true;
            random = new Random();
        }

        public virtual void Start()
        {
            thread.Start();
        }

        public virtual void Stop()
        {
            mustWork = false;
            thread.Join();
        }

        protected Random random;
        protected Thread thread;
        protected bool mustWork;
        protected abstract void doThread();
    }
}
