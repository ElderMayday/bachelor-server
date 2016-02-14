using System.Threading;

namespace Assets.Backend.Sources
{
    public abstract class Source
    {
        public float DataFloat { get; protected set; }
        public bool IsWorking { get; protected set; }
        public bool IsCorrect { get; protected set; }

        public Source()
        {
            thread = new Thread(doThread);
            thread.Start();
        }

        protected Thread thread;

        protected abstract void doThread();
    }
}
