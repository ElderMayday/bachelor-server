using System;
using System.Collections.Generic;



namespace Assets.Backend.Estimators
{
    public sealed class EstimatorMinkowski : Estimator
    {
        /// <summary>
        /// Создает оценщика
        /// </summary>
        /// <param name="_pure">Исходные данные</param>
        /// <param name="_output">Конечные данные</param>
        /// <param name="_order">Порядок расстояния Минковского</param>
        public EstimatorMinkowski(List<double> _pure, List<double> _output, double _order) : base(_pure, _output)
        {
            order = _order;
        }

        /// <summary>
        /// Проводит оценку
        /// </summary>
        /// <returns>Величина метрики</returns>
        public override double Estimate()
        {
            double result = 0.0;

            for (int i = 0; i < length; i++)
                result += Math.Pow(Math.Abs(pure[i] - output[i]), order);

            result = Math.Pow(result, 1.0 / order);

            return result;
        }



        /// <summary>
        /// Порядок расстояния Минковского
        /// </summary>
        private double order;
    }
}
