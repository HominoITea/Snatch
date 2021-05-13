using CelestialComputation.CelestialBodies;
using CelestialComputation.Infrastructure.Converters;
using System;

namespace CelestialComputation
{
    public class Celestial
    {
        public static float GetEclipticLongitude(DateTime date)
        {
            var julianDate= new JulianDate(date.Year, date.Month, date.Day, date.Hour, date.Minute, date.Second);
            var convertedTime = DynamicalTime.ConvertCoordinatedTime(julianDate.Value);
            return (float) Math.Round(Sun.ApparentEclipticLongitude(convertedTime, true), 4);             
        }
    }
}
