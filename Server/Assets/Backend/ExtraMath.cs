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
            return ExtraMath.Factorial(n) / (ExtraMath.Factorial(k) * ExtraMath.Factorial(n - k));
        }
    }
}
