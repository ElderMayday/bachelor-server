using System;



namespace Assets.Backend.Auxiliary
{
    /// <summary>
    /// Класс дополнительных математических функций
    /// </summary>
    public static class ExtraMath
    {
        /// <summary>
        /// Вычисляет факториал
        /// </summary>
        /// <param name="number">Параметр факториала</param>
        /// <returns>Значение факториала</returns>
        public static int Factorial(int number)
        {
            if (number < 0)
                throw new ExceptionServer("Factorial agrument is lower than 0");

            int result = 1;

            for (int i = 1; i <= number; i++)
                result *= i;

            return result;
        }

        /// <summary>
        /// Вычисляет количество сочетаний n по k
        /// </summary>
        /// <param name="n">Количество различных элементов</param>
        /// <param name="k">Размер набора</param>
        /// <returns>Количество сочетаний</returns>
        public static int Combination(int n, int k)
        {
            return Factorial(n) / (Factorial(k) * Factorial(n - k));
        }

        /// <summary>
        /// Пример кусочно-заданной функции
        /// </summary>
        /// <param name="x">Входной параметр</param>
        /// <returns>Значение функции</returns>
        public static double PieceWiseExample1(double x)
        {
            if (x < 5.0)
                return 0.0;

            if ((5.0 <= x) && (x < 10.0))
                return (x - 5.0) / 10.0; // f(5.0) = 0.0, f(10.0) = 0.5

            if ((10.0 <= x) && (x < 20.0))
                return (x - 10.0) / 20.0 + 0.5; // f(10.0) = 0.5, f(20.0) = 1.0

            return 1.0;
        }

        /// <summary>
        /// Определяет равенство двух величин с некоторой точностью (для тестирования)
        /// </summary>
        /// <param name="a">Первая величина</param>
        /// <param name="b">Вторая величина</param>
        /// <returns>Результат проверки на равенство</returns>
        public static bool EqualValue(double a, double  b)
        {
            return Math.Abs(a - b) < 0.001;
        }
    }
}
