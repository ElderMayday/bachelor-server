using System;
using System.Linq;



namespace Assets.Backend.Filters
{
    public class FilterGaussian : FilterFIR
    {
        public FilterGaussian(int length, double a) : base(length)
        {
            double x;

            for (int i = 0; i < length; i++)
            {
                x = i - (length - 1.0) / 2.0;
                x = x * x;
                weight[i] = Math.Sqrt(a / Math.PI) * Math.Exp(-a * x);
            }

            double coefficient = 1.0 / weight.Sum();

            for (int i = 0; i < length; i++)
                weight[i] *= coefficient;
        }
    }
}
