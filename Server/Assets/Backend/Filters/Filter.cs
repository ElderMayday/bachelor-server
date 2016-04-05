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
            correctPeriod(ref input, input[input.Count - 1]);
        }

        /// <summary>
        /// Получить выходные данные
        /// </summary>
        /// <returns></returns>
        public abstract double GetOutput();



        /// <summary>
        /// Корректирует период данных
        /// </summary>
        /// <param name="list">список данных</param>
        /// <param name="newValue">новое значение (обычно последний элемент списка)</param>
        protected void correctPeriod(ref List<double> list, double newValue)
        {
            if ((-180.0 <= newValue) && (newValue <= -180.0 + angleGap))
            {
                for (int i = 0; i < list.Count - 1; i++)
                    if ((180.0 - angleGap <= list[i]) && (list[i] <= 180.0))
                        list[i] -= 360.0;
            }

            if ((180.0 - angleGap <= newValue) && (newValue <= 180.0))
            {
                for (int i = 0; i < list.Count - 1; i++)
                    if ((-180.0 <= list[i]) && (list[i] <= -180.0 + angleGap))
                        list[i] += 360.0;
            }
        }



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
