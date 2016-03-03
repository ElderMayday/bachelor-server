using System;



namespace Assets.Backend.Noisers
{
    public class NoiserErlang : Noiser
    {
        public NoiserErlang(double _lambda, int _k)
        {
            lambda = _lambda;
            k = _k;
        }

        public override double Get()
        {
            double result = 1.0;

            for (int i = 0; i < k; i++)
                result *= getRandom();

            result = -Math.Log(result) / lambda;

            return result;
        }

        protected double lambda, k;
    }
}
