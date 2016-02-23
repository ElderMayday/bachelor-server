using System.Collections.Generic;


namespace Assets.Backend.Filters
{
    public abstract class FilterIIR : Filter
    {
        public FilterIIR(int orderInput, int orderOutput) : base(orderInput)
        {
            weightInput = new List<double>();
            weightOutput = new List<double>();

            for (int i = 0; i < orderInput; i++)
                weightInput.Add(0.0);

            for (int i = 0; i < orderOutput; i++)
                weightOutput.Add(0.0);

            output = new List<double>();

            for (int i = 0; i < orderOutput; i++)
                output.Add(0.0);
        }

        public override double GetOutput()
        {
            return output[output.Count - 1];
        }

        public override void AddInput(double newX)
        {
            input.Add(newX);
            output.Add(0.0);

            double result = 0.0;

            for (int i = 0; i < weightInput.Count; i++)
                result += weightInput[i] * input[input.Count - i - 1];

            for (int i = 0; i < weightOutput.Count; i++)
                result += weightOutput[i] * output[output.Count - i - 2];

            output[output.Count - 1] = result;
        }

        protected List<double> weightInput, weightOutput;
        protected List<double> output;
    }
}
