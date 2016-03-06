using System;

using Assets.Backend.Auxiliary;



namespace Assets.Backend.Filters
{
    /// <summary>
    /// Однополярный фильтр
    /// </summary>
    public class FilterSinglePole : FilterIIR
    {
        /// <summary>
        /// Создает однополярный фильтр
        /// </summary>
        /// <param name="stage"></param>
        /// <param name="x"></param>
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
