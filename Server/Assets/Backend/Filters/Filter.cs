using System.Collections.Generic;


namespace Assets.Backend.Filters
{
    public abstract class Filter
    {
        public Filter()
        {
            x = new List<double>();
        }

        public void AddX(double newX)
        {
            x.Add(newX);
        }

        public abstract double GetY();

        protected List<double> x;
    }
}
