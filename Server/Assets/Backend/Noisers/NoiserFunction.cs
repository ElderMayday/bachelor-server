using System;



namespace Assets.Backend.Noisers
{
    /// <summary>
    /// Генератор шума по заданной функции
    /// </summary>
    public class NoiserFunction : Noiser
    {
        /// <summary>
        /// Создает генератор по заданной функции
        /// </summary>
        /// <param name="_f">Функция распределения</param>
        public NoiserFunction(Func<double, double> _f)
        {
            f = _f;
        }

        public override double Get()
        {
            double r = getRandom();

            double result = binarySearch(r);

            return result;
        }



        /// <summary>
        /// Совершает двоичный поиск корня по функции и значению функции
        /// </summary>
        /// <param name="yValue">значение функции</param>
        /// <returns></returns>
        protected double binarySearch(double yValue)
        {
            double startValue = 10.0;
            double step = 5.0;
            double accuracy = 0.1;

            double left, right;
            double swap;

            left = right = startValue;

            if (f(left) >= yValue)
            {
                do
                {
                    left = right;
                    right -= step;
                }
                while (f(right) > yValue);

                swap = left;
                left = right;
                right = swap;
            }
            else
            {
                do
                {
                    left = right;
                    right += step;
                }
                while (f(right) < yValue);
            }

            double current = left;

            while (Math.Abs(right - left) >= accuracy)
            {
                current = (right + left) / 2.0;

                if (f(current) > yValue)
                    right = current;
                else
                    left = current;
            }

            return current;
        }



        /// <summary>
        /// Функция распределения
        /// </summary>
        protected Func<double, double> f;
    }
}
