using System.Collections.Generic;



namespace Assets.Backend.Filters
{
    public abstract class Filter
    {
        public Filter(int orderInput)
        {
            input = new List<double>();

            for (int i = 0; i < orderInput; i++)
                input.Add(0.0);
        }

        public virtual void AddInput(double newInput)
        {
            input.Add(newInput);
            input.RemoveAt(0);
        }

        public abstract double GetOutput();

        protected List<double> input;
    }
}
