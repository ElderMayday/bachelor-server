using System.Collections.Generic;


namespace Assets.Backend.Filters
{
    public abstract class FilterFIR : Filter
    {
        public FilterFIR(int length) : base()
        {
            weight = new List<double>();

            for (int i = 0; i < length; i++)
                weight.Add(0.0);
        }

        public override double GetY()
        {
            double y = 0.0;

            if (x.Count >= weight.Count)
                for (int i = 0; i < weight.Count; i++)
                    y += weight[i] * x[x.Count - i - 1];

            return y;
        }

        protected List<double> weight;
    }
}
