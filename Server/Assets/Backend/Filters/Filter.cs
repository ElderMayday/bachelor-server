using System.Collections.Generic;


namespace Assets.Backend.Filters
{
    public abstract class Filter
    {
        public Filter()
        {
            input = new List<double>();
        }

        public Filter(int orderInput)
        {
            input = new List<double>();

            for (int i = 0; i < orderInput; i++)
                input.Add(0.0);
        }

        public virtual void AddInput(double newX)
        {
            input.Add(newX);
        }

        public abstract double GetOutput();

        protected List<double> input;
    }
}
