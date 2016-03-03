using System;



namespace Assets.Backend.Noisers
{
    public abstract class Noiser
    {
        public Noiser()
        {
            random = new Random();
        }

        public abstract double Get();

        protected double getRandom()
        {
            return random.Next(1, 1000) / 1000.0;
        }

        private Random random;
    }
}
