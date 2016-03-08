using System.Collections.Generic;

using Assets.Backend.Auxiliary;



namespace Assets.Backend.Estimators
{
    public abstract class Estimator
    {
        public Estimator(List<double> _pure, List<double> _output)
        {
            if (_pure.Count != _output.Count)
                throw new ExceptionServer("Lists count mismatch");

            pure = _pure;
            output = _output;

            length = pure.Count;
        }

        public abstract double Estimate();



        protected List<double> pure, output;

        protected int length;
    }
}
