using CelestialComputation.CelestialBodies;
using CelestialComputation.Infrastructure.Converters;
using System;

namespace CelestialComputation
{
    public class Celestial
    {
        public static float EclipticLongitude(DateTime date)
        {
            var julianDate= new JulianDate(date.Year, date.Month, date.Day, date.Hour, date.Minute, date.Second);
            double JDSun = DynamicalTime.ConvertCoordinatedTime(julianDate.Value);
            var eclipticLongitude = (float)Math.Round(Sun.ApparentEclipticLongitude(JDSun, true), 4);
            return eclipticLongitude;
        }
    }
}
