using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Backend.Auxiliary
{
    /// <summary>
    /// Класс-структура для трех величин
    /// </summary>
    public class Vector3
    {
        public Vector3()
        {
            X = Y = Z = 0.0;
        }

        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
    }
}
