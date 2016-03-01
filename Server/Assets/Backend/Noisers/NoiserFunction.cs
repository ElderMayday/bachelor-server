using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Backend.Noisers
{
    public class NoiserFunction : Noiser
    {
        public NoiserFunction(Func<double, double> _f)
        {
            f = _f;
        }

        public override float Get()
        {
            double r = getRandom();

            double left = 10.0;
            double step = 5.0;
            double accuracy = 0.1;

            double right;
            double swap;

            right = left;

            if (f(left) >= r)
            {
                do
                {
                    right -= step;
                }
                while (f(right) > r);

                swap = left;
                left = right;
                right = swap;
            }
            else
            {
                do
                {
                    right += step;
                }
                while (f(right) < r);
            }

            double current = left;

            while (Math.Abs(right - left) >= accuracy)
            {
                current = (right + left) / 2.0;

                if (f(current) > r)
                    right = current;
                else
                    left = current;
            }

            return (float)current;
        }

        Func<double, double> f;
    }
}
