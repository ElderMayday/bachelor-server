using System.Collections.Generic;


namespace Assets.Backend.Filters
{
    /// <summary>
    /// Абстрактный КИХ-фильтр
    /// </summary>
    public abstract class FilterFIR : Filter
    {
        /// <summary>
        /// Создает абстрактный КИХ-фильтр
        /// </summary>
        /// <param name="order">Порядок входных данных</param>
        public FilterFIR(int order) : base(order)
        {
            weight = new List<double>();

            for (int i = 0; i < order; i++)
                weight.Add(0.0);
        }

        /// <summary>
        /// Получить выходные данные
        /// </summary>
        /// <returns>Выходные отфильтрованные данные</returns>
        public override double GetOutput()
        {
            double result = 0.0;

            for (int i = 0; i < weight.Count; i++)
                result += weight[i] * input[input.Count - i - 1];

            return result;
        }



        /// <summary>
        /// Список значений импульсной переходной функции для входных данных
        /// </summary>
        protected List<double> weight;
    }
}
