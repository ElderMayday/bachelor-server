using System;



namespace Assets.Backend.Noisers
{
    public class NoiserErlang : Noiser
    {
        public NoiserErlang(float _lambda, int _k)
        {
            lambda = _lambda;
            k = _k;
        }

        public override float Get()
        {
            float result = 1.0f;

            for (int i = 0; i < k; i++)
                result *= getRandom();

            result = -(float)Math.Log(result) / lambda;

            return result;
        }

        protected float lambda, k;
    }
}
