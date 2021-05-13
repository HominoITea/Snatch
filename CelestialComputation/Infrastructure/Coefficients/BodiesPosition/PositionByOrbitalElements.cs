using System;
using System.Collections.Generic;
using System.Text;

namespace CelestialComputation.Infrastructure.Coefficients.BodiesPosition
{
    public struct PositionByOrbitalElements
    {
        private readonly double _fisrt, _second, _third;
        public double First => _fisrt;
        public double Second => _second;
        public double Third => _third;

        public PositionByOrbitalElements(double fisrt, double second, double third) => (_fisrt, _second, _third) = (fisrt, second, third);
    }
}
