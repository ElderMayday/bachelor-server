using System.Collections.Generic;



namespace Assets.Backend.Filters
{
    /// <summary>
    /// Абстрактный фильтр
    /// </summary>
    public abstract class Filter
    {
        /// <summary>
        /// Создает фильтр
        /// </summary>
        /// <param name="orderInput">Порядок входных данных</param>
        public Filter(int orderInput)
        {
            input = new List<double>();

            for (int i = 0; i < orderInput; i++)
                input.Add(0.0);
        }

        /// <summary>
        /// Добавить входные данные
        /// </summary>
        /// <param name="newInput"></param>
        public virtual void AddInput(double newInput)
        {
            input.Add(newInput);
            input.RemoveAt(0);
        }

        /// <summary>
        /// Получить выходные данные
        /// </summary>
        /// <returns></returns>
        public abstract double GetOutput();



        /// <summary>
        /// Список значений входных данных
        /// </summary>
        protected List<double> input;
    }
}
