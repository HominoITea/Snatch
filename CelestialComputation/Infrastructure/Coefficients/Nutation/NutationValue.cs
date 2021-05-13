using System;
using System.Collections.Generic;
using System.Text;

namespace CelestialComputation.Coefficients.Nutation
{
    struct NutationValue
{
        private readonly int _elongationOfMoon;
        private readonly int _anomalyOfSun;
        private readonly int _anomalyOfMoon;
        private readonly int _latitudeOfMoon;
        private readonly int _longitudeOfAscendingNode;
        private readonly int _sinusOfMoon;
        private readonly double _sinusOfSun;
        private readonly int _cosinusOfMoon;
        private readonly double _cosinusOfSun;

        public int ElongationOfMoon => _elongationOfMoon;
        public int AnomalyOfSun => _anomalyOfSun;
        public int AnomalyOfMoon => _anomalyOfMoon;
        public int LatitudeOfMoon => _latitudeOfMoon;
        public int LongitudeOfAscendingNode => _longitudeOfAscendingNode;
        public int SinusOfMoon => _sinusOfMoon;
        public double SinusOfSun => _sinusOfSun;

        public NutationValue(int elongationOfMoon, int anomalyOfSun, int anomalyOfMoon, int latitudeOfMoon, int longitudeOfAscendingNode, int sinusOfMoon, double sinusOfSun, int cosinusOfMoon, double cosinusOfSun)
        {
            _elongationOfMoon = elongationOfMoon;
            _anomalyOfSun = anomalyOfSun;
            _anomalyOfMoon = anomalyOfMoon;
            _latitudeOfMoon = latitudeOfMoon;
            _longitudeOfAscendingNode = longitudeOfAscendingNode;
            _sinusOfMoon = sinusOfMoon;
            _sinusOfSun = sinusOfSun;
            _cosinusOfMoon = cosinusOfMoon;
            _cosinusOfSun = cosinusOfSun;
        }
    }
}
