using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Backend.Auxiliary
{
    /// <summary>
    /// Класс-структура для трех величин
    /// </summary>
    public class Vector3d
    {
        public Vector3d()
        {
            x = y = z = 0.0;
            mutex = new object();
        }

        public double X
        {
            get
            {
                lock (mutex)
                {
                    return x;
                }
            }
            set
            {
                lock (mutex)
                {
                    x = value;
                }
            }
        }

        public double Y
        {
            get
            {
                lock (mutex)
                {
                    return y;
                }
            }
            set
            {
                lock (mutex)
                {
                    y = value;
                }
            }
        }

        public double Z
        {
            get
            {
                lock (mutex)
                {
                    return z;
                }
            }
            set
            {
                lock (mutex)
                {
                    z = value;
                }
            }
        }

        private double x, y, z;
        private object mutex;
    }
}
