


namespace Assets.Backend.Filters
{
    public class FilterMovingAverage : FilterFIR
    {
        public FilterMovingAverage(int length) : base(length)
        {
            double average = 1.0 / length;

            for (int i = 0; i < weight.Count; i++)
                weight[i] = average;
        }
    }
}
