using System;
using System.Collections.Generic;
using System.Text;

namespace CelestialComputation.Infrastructure.Coefficients.BodiesPosition
{
    public struct PositionBySphereEquinox
    {
        private readonly PositionByOrbitalElements[] _positions;
        private readonly int _size;        
        public PositionBySphereEquinox(PositionByOrbitalElements[] positions, int size)
        {
            _positions = positions;
            _size = size;
        }
        public PositionByOrbitalElements[] GetPositions() => _positions;
        public int Size => _size;
    };
}
