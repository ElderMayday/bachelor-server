using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Backend.Estimators
{
    public sealed class EstimatorDistance : Estimator
    {
        /// <summary>
        /// Создает оценщика
        /// </summary>
        /// <param name="_pure">Исходные данные</param>
        /// <param name="_output">Конечные данные</param>
        public EstimatorDistance(List<double> _pure, List<double> _output) : base(_pure, _output)
        {
        }

        /// <summary>
        /// Проводит оценку
        /// </summary>
        /// <returns>Величина метрики</returns>
        public override double Estimate()
        {
            double result = 0.0;

            for (int i = 0; i < pure.Count; i++)
            {
                if (Math.Abs(pure[i] - output[i]) > result)
                    result = Math.Abs(pure[i] - output[i]);
            }

            return result;
        }
    }
}
