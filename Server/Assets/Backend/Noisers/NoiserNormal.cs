


namespace Assets.Backend.Noisers
{
    public class NoiserNormal : Noiser
    {
        public NoiserNormal(double _mean, double _deviation)
        {
            mean = _mean;
            deviation = _deviation;
        }

        public override double Get()
        {
            double sum = 0.0;

            for (int i = 0; i < 12; i++)
                sum += getRandom();

            sum = (sum - 6 )* deviation + mean;

            return sum;
        }

        protected double mean, deviation;
    }
}
