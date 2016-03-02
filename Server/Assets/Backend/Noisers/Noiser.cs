using System;



namespace Assets.Backend.Noisers
{
    public abstract class Noiser
    {
        public Noiser()
        {
            random = new Random();
        }

        public abstract float Get();

        protected float getRandom()
        {
            return random.Next(1, 1000) / 1000.0f;
        }

        private Random random;
    }
}
