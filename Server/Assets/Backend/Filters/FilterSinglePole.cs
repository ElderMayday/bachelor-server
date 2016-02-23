using System;


namespace Assets.Backend.Filters
{
    public class FilterSinglePole : FilterIIR
    {
        public FilterSinglePole(int stage, double x) : base(stage + 1, 1)
        {
            weightOutput[0] = Math.Pow(1 - x, stage);

            for (int i = 1; i <= stage; i++)
                if (i % 2 == 0)
                    weightInput[i] = -ExtraMath.Combination(stage, i) * Math.Pow(x, i);
                else
                    weightInput[i] = ExtraMath.Combination(stage, i) * Math.Pow(x, i);
        }
    }
}
