using CelestialComputation.Behavior;
using CelestialComputation.Infrastructure;
using CelestialComputation.Infrastructure.Converters;
using CelestialComputation.Infrastructure.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace CelestialComputation.CelestialBodies
{
    //Очень много всяких постоянных коэффициентов, определять названия всех - времени нет.
    class Sun
    {
        static public double GeometricEclipticLatitude(double julianDate) => -Earth.GetSunEclipticLatitude(julianDate);
        static public double ApparentEclipticLatitude(double julianDate, bool highPrecision) => ConvertLatitudeToFK5(julianDate, highPrecision);
        static public double ApparentEclipticLongitude(double julianDate, bool highPrecision)
        {
            var longitude = ConvertLongitudeToFK5(julianDate, highPrecision) 
                + CoordinateTransformation.SetDMSToDegrees(0, 0, Nutation.NutationInLongitude(julianDate));

            var radius = Earth.GetSunRadiusVector(julianDate);

            return (highPrecision) 
                ? longitude - (0.005775518 * radius * CoordinateTransformation.SetDMSToDegrees(0, 0, GetVariationEclipticLongitude(julianDate)))
                : longitude - CoordinateTransformation.SetDMSToDegrees(0, 0, 20.4898 / radius);            
        }        
        static public double ConvertLongitudeToFK5(double julianDate, bool highPrecision)
        {
            double longitude = GetEclipticLongitude(julianDate, highPrecision);
            double latitude = GeometricEclipticLatitude(julianDate);
            longitude += FK5.CorrectLongitude(longitude, latitude, julianDate);
            return longitude;
        }
        static public double ConvertLatitudeToFK5(double julianDate, bool highPrecision)
        {
            //Convert to the FK5 stystem
            double Longitude = GetEclipticLongitude(julianDate, highPrecision);
            double Latitude = GeometricEclipticLatitude(julianDate);
            double SunLatCorrection = FK5.CorrectLatitude(Longitude, julianDate);
            Latitude += SunLatCorrection;

            return Latitude;
        }
        static public double GetEclipticLongitude(double julianDate, bool highPrecision)
        {
            double earth = Earth.GetSunEclipticLongitude(julianDate, highPrecision);
            return CoordinateTransformation.MapTo0To360Range(earth + 180);
        }
        
        static public double GetVariationEclipticLongitude(double julianDate)
        {
            var millenniasCount = Tools.GetMillenniasCount(julianDate);
            double deltaLambda = 3548.193
                                 + 118.568 * Math.Sin(CoordinateTransformation.SetDegreesToRadians(87.5287 + 359993.7286 * millenniasCount))
                                 + 2.476 * Math.Sin(CoordinateTransformation.SetDegreesToRadians(85.0561 + 719987.4571 * millenniasCount))
                                 + 1.376 * Math.Sin(CoordinateTransformation.SetDegreesToRadians(27.8502 + 4452671.1152 * millenniasCount))
                                 + 0.119 * Math.Sin(CoordinateTransformation.SetDegreesToRadians(73.1375 + 450368.8564 * millenniasCount))
                                 + 0.114 * Math.Sin(CoordinateTransformation.SetDegreesToRadians(337.2264 + 329644.6718 * millenniasCount))
                                 + 0.086 * Math.Sin(CoordinateTransformation.SetDegreesToRadians(222.5400 + 659289.3436 * millenniasCount))
                                 + 0.078 * Math.Sin(CoordinateTransformation.SetDegreesToRadians(162.8136 + 9224659.7915 * millenniasCount))
                                 + 0.054 * Math.Sin(CoordinateTransformation.SetDegreesToRadians(82.5823 + 1079981.1857 * millenniasCount))
                                 + 0.052 * Math.Sin(CoordinateTransformation.SetDegreesToRadians(171.5189 + 225184.4282 * millenniasCount))
                                 + 0.034 * Math.Sin(CoordinateTransformation.SetDegreesToRadians(30.3214 + 4092677.3866 * millenniasCount))
                                 + 0.033 * Math.Sin(CoordinateTransformation.SetDegreesToRadians(119.8105 + 337181.4711 * millenniasCount))
                                 + 0.023 * Math.Sin(CoordinateTransformation.SetDegreesToRadians(247.5418 + 299295.6151 * millenniasCount))
                                 + 0.023 * Math.Sin(CoordinateTransformation.SetDegreesToRadians(325.1526 + 315559.5560 * millenniasCount))
                                 + 0.021 * Math.Sin(CoordinateTransformation.SetDegreesToRadians(155.1241 + 675553.2846 * millenniasCount))
                                 + 7.311 * millenniasCount * Math.Sin(CoordinateTransformation.SetDegreesToRadians(333.4515 + 359993.7286 * millenniasCount))
                                 + 0.305 * millenniasCount * Math.Sin(CoordinateTransformation.SetDegreesToRadians(330.9814 + 719987.4571 * millenniasCount))
                                 + 0.010 * millenniasCount * Math.Sin(CoordinateTransformation.SetDegreesToRadians(328.5170 + 1079981.1857 * millenniasCount))
                                 + 0.309 * Tools.GetRaisedValue(millenniasCount, Power.Square) * Math.Sin(CoordinateTransformation.SetDegreesToRadians(241.4518 + 359993.7286 * millenniasCount))
                                 + 0.021 * Tools.GetRaisedValue(millenniasCount, Power.Square) * Math.Sin(CoordinateTransformation.SetDegreesToRadians(205.0482 + 719987.4571 * millenniasCount))
                                 + 0.004 * Tools.GetRaisedValue(millenniasCount, Power.Square) * Math.Sin(CoordinateTransformation.SetDegreesToRadians(297.8610 + 4452671.1152 * millenniasCount))
                                 + 0.010 * Tools.GetRaisedValue(millenniasCount, Power.Cube) * Math.Sin(CoordinateTransformation.SetDegreesToRadians(154.7066 + 359993.7286 * millenniasCount));
            return deltaLambda;
        }
    }

}
