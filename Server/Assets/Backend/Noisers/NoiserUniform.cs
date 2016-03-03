


namespace Assets.Backend.Noisers
{
    public class NoiserUniform : Noiser
    {
        public NoiserUniform(double _min, double _max)
        {
            min = _min;
            max = _max;
        }

        public override double Get()
        {
            return min + (max - min) * getRandom();
        }

        protected double min, max;
    }
}
