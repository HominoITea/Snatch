using CelestialComputation.Infrastructure.Enum;
using System;

namespace CelestialComputation.Infrastructure.Converters
{
    internal static class FK5
    {
        public static double CorrectLongitude(double longitude, double latitude, double julianDate)
        {
            double julianCenturies = Tools.GetCenturiesCount(julianDate);
            double Ldash = longitude - 1.397 
                * julianCenturies - 0.00031 
                * Tools.GetRaisedValue(julianCenturies, Power.Square);

            Ldash = CoordinateTransformation.SetDegreesToRadians(Ldash);
            latitude = CoordinateTransformation.SetDegreesToRadians(latitude);

            double value = -0.09033 + 0.03916 
                * (Math.Cos(Ldash) + Math.Sin(Ldash)) 
                * Math.Tan(latitude);
            return CoordinateTransformation.SetDMSToDegrees(0, 0, value);
        }
        public static double CorrectLatitude(double longitude, double julianDate)
        {
            double julianCenturies = Tools.GetCenturiesCount(julianDate);
            double Ldash = longitude - 1.397 
                * julianCenturies - 0.00031 
                * Tools.GetRaisedValue(julianCenturies, Power.Square);

            Ldash = CoordinateTransformation.SetDegreesToRadians(Ldash);

            double value = 0.03916 * (Math.Cos(Ldash) - Math.Sin(Ldash));
            return CoordinateTransformation.SetDMSToDegrees(0, 0, value);
        }
    }
}
