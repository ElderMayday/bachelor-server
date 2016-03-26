using Assets.Backend.Auxiliary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Backend.Estimators
{
    public class EstimatorCorrelation : Estimator
    {
        /// <summary>
        /// Создает оценщика
        /// </summary>
        /// <param name="_pure">Исходные данные</param>
        /// <param name="_output">Конечные данные</param>
        public EstimatorCorrelation(List<double> _pure, List<double> _output) : base(_pure, _output)
        {
        }

        /// <summary>
        /// Проводит оценку
        /// </summary>
        /// <returns>Величина метрики</returns>
        public override double Estimate()
        {
            double meanPure = pure.Average();
            double meanFiltered = output.Average();

            double cov = 0.0;
            double sigmaPure = 0.0, sigmaFiltered = 0.0;

            for (int i = 0; i < length; i++)
            {
                cov += (pure[i] - meanPure) * (output[i] - meanFiltered);
                sigmaPure += Math.Pow(pure[i] - meanPure, 2.0);
                sigmaFiltered += Math.Pow(output[i] - meanFiltered, 2.0);
            }

            return cov / Math.Sqrt(sigmaPure * sigmaFiltered);
        }
    }
}
