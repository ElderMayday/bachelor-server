using System.Collections.Generic;

using Assets.Backend.Auxiliary;



namespace Assets.Backend.Estimators
{
    /// <summary>
    /// Абстракная метрика оценки фильтрации
    /// </summary>
    public abstract class Estimator
    {
        /// <summary>
        /// Создает оценщика
        /// </summary>
        /// <param name="_pure">Исходные данные</param>
        /// <param name="_output">Конечные данные</param>
        public Estimator(List<double> _pure, List<double> _output)
        {
            if (_pure.Count != _output.Count)
                throw new ExceptionServer("Lists count mismatch");

            pure = _pure;
            output = _output;

            length = pure.Count;
        }

        /// <summary>
        /// Проводит оценку
        /// </summary>
        /// <returns>Величина метрики</returns>
        public abstract double Estimate();


        /// <summary>
        /// Исходные и конченые данные
        /// </summary>
        protected List<double> pure, output;

        /// <summary>
        /// Длина списков данных
        /// </summary>
        protected int length;
    }
}
