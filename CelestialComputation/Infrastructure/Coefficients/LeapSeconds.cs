using System;
using System.Collections.Generic;
using System.Text;

namespace CelestialComputation.Coefficients
{
    internal struct LeapSeconds
    {
        private readonly double _julianDate, _seconds, _baseModifiedJulian, _coefficient;
        public double JulianDate => _julianDate;
        public double Seconds => _seconds;
        public double BaseModifiedJulian => _baseModifiedJulian;
        public double Coefficient => _coefficient;
        public LeapSeconds(double julianDate, double seconds, double baseModifiedJulian, double coefficient) 
            => (_julianDate, _seconds, _baseModifiedJulian, _coefficient)
            = (julianDate, seconds, baseModifiedJulian, coefficient);
    }
}
