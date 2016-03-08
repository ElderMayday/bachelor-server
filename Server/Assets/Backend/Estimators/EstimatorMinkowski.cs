using System;
using System.Collections.Generic;



namespace Assets.Backend.Estimators
{
    public class EstimatorMinkowski : Estimator
    {
        public EstimatorMinkowski(List<double> _pure, List<double> _output, double _order) : base(_pure, _output)
        {
            order = _order;
        }

        public override double Estimate()
        {
            double result = 0.0;

            for (int i = 0; i < length; i++)
                result += Math.Pow(Math.Abs(pure[i] - output[i]), order);

            result = Math.Pow(result, 1.0 / order);

            return result;
        }



        protected double order;
    }
}
