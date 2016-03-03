using System;



namespace Assets.Backend.Noisers
{
    public class NoiserExponential : Noiser
    {
        public NoiserExponential(double _lambda)
        {
            lambda = _lambda;
        }

        public override double Get()
        {
            return - 1.0 / lambda * Math.Log(1.0 - getRandom());
        }

        protected double lambda;
    }
}
