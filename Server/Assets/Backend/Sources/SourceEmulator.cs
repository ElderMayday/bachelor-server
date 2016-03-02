using Assets.Backend.Noisers;




namespace Assets.Backend.Sources
{
    public abstract class SourceEmulator : Source
    {
        public SourceEmulator(Noiser _noiser)
        {
            interval = 100;

            noiser = _noiser;
        }

        public float DataPure
        {
            get { return dataPure; }
            protected set { dataPure = value; Data = value + noiser.Get(); }
        }

        protected int interval;
        protected Noiser noiser;
        protected float dataPure;
    }
}
