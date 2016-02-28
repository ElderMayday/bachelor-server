using Assets.Backend.Noisers;




namespace Assets.Backend.Sources
{
    public abstract class SourceEmulator : Source
    {
        public SourceEmulator(Noiser _noiser)
        {
            noiser = _noiser;
        }

        public float DataPure
        {
            get { return dataPure; }
            protected set { dataPure = value; Data = value + noiser.Get(); }
        }

        protected Noiser noiser;
        protected float dataPure;
    }
}
