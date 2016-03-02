using System;



namespace Assets.Backend.Noisers
{
    public class NoiserExponential : Noiser
    {
        public NoiserExponential(float _lambda)
        {
            lambda = _lambda;
        }

        public override float Get()
        {
            return - 1.0f / lambda * (float)Math.Log(1.0f - getRandom());
        }

        protected float lambda;
    }
}
