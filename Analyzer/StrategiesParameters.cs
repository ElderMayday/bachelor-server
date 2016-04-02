using Assets.Backend.Auxiliary;
using Assets.Backend.Filters;
using Assets.Backend.Noisers;
using Assets.Backend.Sources;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Analyzer
{
    /// <summary>
    /// Параметры запуска анализа
    /// </summary>
    public class StrategiesParameters
    {
        public FilterType Filter { get; set; }
        public int FilterLength { get; set; }
        public double SinglePoleK { get; set; }
        public double GaussianA { get; set; }

        public SourceType Source { get ; set; }
        public double SinAverage { get; set; }
        public double SinAmplitude { get; set; }
        public double SinPeriod { get; set; }
        public double LinearMin { get; set; }
        public double LinearMax { get; set; }
        public double HalfOffset { get; set; }
        public List<double> aList { get; set; }
        public List<double> bList { get; set; }

        public NoiserType Noiser { get; set; }
        public double UniformMin { get; set; }
        public double UniformMax { get; set; }
        public double NormalMean { get; set; }
        public double NormalDeviation { get; set; }

        public RotationAxis Axis { get; set; }
        public IPAddress IP { get; set; }

        public EmulatorSettings EmulatorSetting { get; set; }
    }
}
