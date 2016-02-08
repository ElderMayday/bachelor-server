using System.Threading;

namespace Backend
{
    public abstract class Source
    {
        public float DataFloat { get; protected set; }
        public bool IsWorking { get; protected set; }
        public bool IsCorrect { get; protected set; }

        protected Thread thread;

        protected abstract void doThread();
    }
}
