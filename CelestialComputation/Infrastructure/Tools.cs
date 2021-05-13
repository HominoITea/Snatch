using CelestialComputation.Infrastructure.Enum;
using System;

namespace CelestialComputation.Infrastructure
{
    internal static class Tools
    {
        public static double GetMillenniasCount(double julianDate)
        {
            const int centuriesInmillennium = 10;
            return GetCenturiesCount(julianDate) / centuriesInmillennium;
        }

        public static double GetCenturiesCount(double julianDate)
        {
            const int epoch = 2451545;
            const int daysInCentury = 36525;
            return (julianDate - epoch) / daysInCentury;
        }
        public static double GetRaisedValue(double millennias, Power power) => Math.Pow(millennias, (double)power);
    }
}
