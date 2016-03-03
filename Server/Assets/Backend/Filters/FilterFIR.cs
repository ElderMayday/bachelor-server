using System.Collections.Generic;


namespace Assets.Backend.Filters
{
    public abstract class FilterFIR : Filter
    {
        public FilterFIR(int order) : base(order)
        {
            weight = new List<double>();

            for (int i = 0; i < order; i++)
                weight.Add(0.0);
        }

        public override double GetOutput()
        {
            double result = 0.0;

            for (int i = 0; i < weight.Count; i++)
                result += weight[i] * input[input.Count - i - 1];

            return result;
        }


        protected List<double> weight;
    }
}
