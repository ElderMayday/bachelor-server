using System.Collections.Generic;


namespace Assets.Backend.Filters
{
    /// <summary>
    /// Абстрактный БИХ-фильтр
    /// </summary>
    public abstract class FilterIIR : Filter
    {
        /// <summary>
        /// Создает БИХ-фильтр
        /// </summary>
        /// <param name="orderInput"></param>
        /// <param name="orderOutput"></param>
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

        /// <summary>
        /// Получить выходные данные
        /// </summary>
        /// <returns>Выходные отфильтрованные данные</returns>
        public override double GetOutput()
        {
            return output[output.Count - 1];
        }

        /// <summary>
        /// Добавить входные данные
        /// </summary>
        /// <param name="newInput"></param>
        public override void AddInput(double newX)
        {
            input.Add(newX);
            input.RemoveAt(0);

            output.Add(0.0);

            double result = 0.0;

            for (int i = 0; i < weightInput.Count; i++)
                result += weightInput[i] * input[input.Count - i - 1];

            for (int i = 0; i < weightOutput.Count; i++)
                result += weightOutput[i] * output[output.Count - i - 2];

            output[output.Count - 1] = result;

            output.RemoveAt(0);
        }



        /// <summary>
        /// Список значений импульсной переходной функции для входных и выходных данных
        /// </summary>
        protected List<double> weightInput, weightOutput;

        /// <summary>
        /// Список значений выходных данных
        /// </summary>
        protected List<double> output;
    }
}
