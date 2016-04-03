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

            angleGap = 50.0;
        }

        /// <summary>
        /// Добавить входные данные
        /// </summary>
        /// <param name="newInput"></param>
        public virtual void AddInput(double newInput)
        {
            input.Add(newInput);
            input.RemoveAt(0);

            if ((-180.0 <= newInput) && (newInput <= -180.0 + angleGap))
            {
                for (int i = 0; i < input.Count - 1; i++)
                    if ((180.0 - angleGap <= input[i]) && (input[i] <= 180.0))
                        input[i] -= 360.0;
            }

            if ((180.0 - angleGap <= newInput) && (newInput <= 180.0))
            {
                for (int i = 0; i < input.Count - 1; i++)
                    if ((-180.0 <= input[i]) && (input[i] <= -180.0 + angleGap))
                        input[i] += 360.0;
            }
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

        /// <summary>
        /// Ширина промежутка анализа на разрыв
        /// </summary>
        protected double angleGap;
    }
}
