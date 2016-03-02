using System;



namespace Assets.Backend
{
    public static class ExtraMath
    {
        public static int Factorial(int number)
        {
            if (number < 0)
                throw new Exception("Factorial agrument is lower than 0");

            int result = 1;

            for (int i = 1; i <= number; i++)
                result *= i;

            return result;
        }


        public static int Combination(int n, int k)
        {
            return Factorial(n) / (Factorial(k) * Factorial(n - k));
        }


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
    }
}
