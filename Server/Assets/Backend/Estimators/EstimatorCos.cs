using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Backend.Estimators
{
    public class EstimatorCos : Estimator
    {
        /// <summary>
        /// Создает оценщика
        /// </summary>
        /// <param name="_pure">Исходные данные</param>
        /// <param name="_output">Конечные данные</param>
        public EstimatorCos(List<double> _pure, List<double> _output) : base(_pure, _output)
        {
        }

        /// <summary>
        /// Проводит оценку
        /// </summary>
        /// <returns>Величина метрики</returns>
        public override double Estimate()
        {
            double numerator, denominator;

            numerator = 0.0;
            for (int i = 0; i < length; i++)
                numerator += pure[i] * output[i];

            denominator = Math.Sqrt(pure.Sum(x => x * x)) * Math.Sqrt(output.Sum(x => x * x));

            return numerator / denominator;
        }
    }
}
