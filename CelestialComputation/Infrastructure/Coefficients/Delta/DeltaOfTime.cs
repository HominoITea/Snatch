using System;
using System.Collections.Generic;
using System.Text;

namespace CelestialComputation.Coefficients
{
    struct DeltaOfTime
    {
        private readonly double _julianDate;
        private readonly double _delta;
        public double JulianDate => _julianDate;
        public double Delta => _delta;
        public DeltaOfTime(double julianDate, double delta) 
            => (_julianDate, _delta) 
            = (julianDate, delta);
    };
}
