


namespace Assets.Backend.Noisers
{
    public class NoiserNormal : Noiser
    {
        public NoiserNormal(float _mean, float _deviation)
        {
            mean = _mean;
            deviation = _deviation;
        }

        public override float Get()
        {
            float sum = 0.0f;

            for (int i = 0; i < 12; i++)
                sum += getRandom();

            sum = (sum - 6 )* deviation + mean;

            return sum;
        }

        protected float mean, deviation;
    }
}
