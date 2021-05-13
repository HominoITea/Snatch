using System;
using System.Collections.Generic;
using System.Text;

namespace CelestialComputation.Infrastructure.Coefficients.BodiesPosition
{
    internal static class PositionBySphereEquinoxArray
    {
        public static PositionBySphereEquinox[] GetPositions()
        {
            return new PositionBySphereEquinox[]
            {
                  new PositionBySphereEquinox(
                      PositionByOrbitalElementsArray.GetEarthBaseArray(), 
                      PositionByOrbitalElementsArray.GetEarthBaseArray().Length),

                  new PositionBySphereEquinox(
                      PositionByOrbitalElementsArray.GetEarthFirstArray(), 
                      PositionByOrbitalElementsArray.GetEarthFirstArray().Length),

                  new PositionBySphereEquinox(
                      PositionByOrbitalElementsArray.GetEarthSecondArray(), 
                      PositionByOrbitalElementsArray.GetEarthSecondArray().Length),

                  new PositionBySphereEquinox(
                      PositionByOrbitalElementsArray.GetEarthThirdArray(), 
                      PositionByOrbitalElementsArray.GetEarthThirdArray().Length),

                  new PositionBySphereEquinox(
                      PositionByOrbitalElementsArray.GetEarthFourthArray(), 
                      PositionByOrbitalElementsArray.GetEarthFourthArray().Length),

                  new PositionBySphereEquinox(
                      PositionByOrbitalElementsArray.GetEarthFifthArray(), 
                      PositionByOrbitalElementsArray.GetEarthFifthArray().Length)
            };
        }
    }
}
