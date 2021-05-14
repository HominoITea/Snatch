using CelestialComputation.Coefficients.Nutation;
using CelestialComputation.Infrastructure.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace CelestialComputation.Behavior
{
    static class Nutation
    {
        //A lot of magic number. The subject to determine all of coefficients
        public static double NutationInLongitude(double julianDate)
        {
            const int epoch = 2451545; // In Julian 1/1/2000
            const int daysInCentury = 36525;

            var meanSiderealTime = (julianDate - epoch) / daysInCentury;
            var squaredTime = meanSiderealTime * meanSiderealTime;
            var cubedTime = squaredTime * meanSiderealTime;

            var nutations = NutationValueArray.GetArray();
            int length = nutations.Length;
            double value = 0;
            for (int i = 0; i < length; i++)
            {
                double argument =
                    nutations[i].ElongationOfMoon * GetElongationOfMoon()
                    + nutations[i].AnomalyOfSun * GetAnomalyOfSun()
                    + nutations[i].AnomalyOfMoon * GetAnomalyOfMoon()
                    + nutations[i].LatitudeOfMoon * GetLatitudeOfMoon()
                    + nutations[i].LongitudeOfAscendingNode * GetLongitudeOfAscendingNode();

                double radargument = CoordinateTransformation.SetDegreesToRadians(argument);
                value += (nutations[i].SinusOfMoon + nutations[i].SinusOfSun * meanSiderealTime)
                    * Math.Sin(radargument) * 0.0001;
            }

            return value;

            double GetElongationOfMoon()
            {
                var meanElongationOfMoon = 297.85036 + 445267.111480 * meanSiderealTime - 0.0019142 * squaredTime + cubedTime / 189474;
                return CoordinateTransformation.MapTo0To360Range(meanElongationOfMoon);
            }

            double GetAnomalyOfSun()
            {
                double anomalyOfSun = 357.52772 + 35999.050340 * meanSiderealTime - 0.0001603 * squaredTime - cubedTime / 300000;
                return CoordinateTransformation.MapTo0To360Range(anomalyOfSun);
            }

            double GetAnomalyOfMoon()
            {
                double anomalyOfMoon = 134.96298 + 477198.867398 * meanSiderealTime + 0.0086972 * squaredTime + cubedTime / 56250;
                return CoordinateTransformation.MapTo0To360Range(anomalyOfMoon);
            }

            double GetLatitudeOfMoon()
            {
                double latitudeOfMoon = 93.27191 + 483202.017538 * meanSiderealTime - 0.0036825 * squaredTime + cubedTime / 327270; //F is ?
                return CoordinateTransformation.MapTo0To360Range(latitudeOfMoon);
            }
            double GetLongitudeOfAscendingNode()
            {
                double longitudeOfAscendingNode = 125.04452 - 1934.136261 * meanSiderealTime + 0.0020708 * squaredTime + cubedTime / 450000; //omega is ?
                return CoordinateTransformation.MapTo0To360Range(longitudeOfAscendingNode);
            }
        }
        
    }

}
