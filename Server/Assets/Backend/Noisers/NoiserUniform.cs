


namespace Assets.Backend.Noisers
{
    public class NoiserUniform : Noiser
    {
        public NoiserUniform(float _min, float _max)
        {
            min = _min;
            max = _max;
        }

        public override float Get()
        {
            return min + (max - min) * getRandom();
        }

        protected float min, max;
    }
}
