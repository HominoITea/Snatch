using CelestialComputation.Infrastructure;
using CelestialComputation.Infrastructure.Coefficients.BodiesPosition;
using CelestialComputation.Infrastructure.Converters;
using CelestialComputation.Infrastructure.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace CelestialComputation.CelestialBodies
{
    public static class Earth
    {
        public static double CalculateEarthPosition(double julianDate)
        {
            var positions = PositionBySphereEquinoxArray.GetPositions();
            var length = positions.Length;
            double julianMillennias = Tools.GetMillenniasCount(julianDate);
            double raisedJulian = julianMillennias;
            double result = 0;
            for (int i = 0; i < length; i++)
            {
                double tempResult = 0;
                for (int j = 0; j < positions[i].Size; j++)
                {
                    tempResult += positions[i].GetPositions()[j].First
                        * Math.Cos(positions[i].GetPositions()[j].Second
                        + positions[i].GetPositions()[j].Third * julianMillennias);
                }
                if (i > 0)
                {
                    tempResult *= raisedJulian;
                    raisedJulian *= julianMillennias;
                }
                result += tempResult;
            }
            return CoordinateTransformation.MapTo0To2PIRange(result);
        }
        public static double GetSunEclipticLongitude(double julianDate, bool highPrecision)
        {
            if (highPrecision)
            {
                return 
                    CoordinateTransformation.MapTo0To360Range
                    (CoordinateTransformation.SetRadiansToDegrees
                    (CalculateEarthPosition(julianDate))); // Вроде как для высокой точности
            }
            else
            {
                double julianMillennias = Tools.GetMillenniasCount(julianDate);

                var sunLongitudeBase = GetCalculatedValue(PositionByOrbitalElementsArray.GetSunLongitudeBaseArray(), julianMillennias);
                var sunLongitudeFirstGroup = GetCalculatedValue(PositionByOrbitalElementsArray.GetSunLongitudeFirstArray(), julianMillennias);
                var sunLongitudeSecondGroup = GetCalculatedValue(PositionByOrbitalElementsArray.GetSunLongitudeSecondArray(), julianMillennias);
                var sunLongitudeThirdGroup = GetCalculatedValue(PositionByOrbitalElementsArray.GetSunLongitudeThirdArray(), julianMillennias);
                var sunLongitudeFourthGroup = GetCalculatedValue(PositionByOrbitalElementsArray.GetSunLongitudeFourthArray(), julianMillennias);
                var sunLongitudeFifthGroup = GetCalculatedValue(PositionByOrbitalElementsArray.GetSunLongitudeFifthArray(), julianMillennias);

                var value = (sunLongitudeBase
                    + sunLongitudeFirstGroup * julianMillennias
                    + sunLongitudeSecondGroup * Tools.GetRaisedValue(julianMillennias, Power.Square)
                    + sunLongitudeThirdGroup * Tools.GetRaisedValue(julianMillennias, Power.Cube)
                    + sunLongitudeFourthGroup * Tools.GetRaisedValue(julianMillennias, Power.Fourth)
                    + sunLongitudeFifthGroup * Tools.GetRaisedValue(julianMillennias, Power.Fifth)) / 100000000;

                //convert results back to degrees            
                return CoordinateTransformation.MapTo0To360Range(CoordinateTransformation.SetRadiansToDegrees(value));
            }
        }
        public static double GetSunEclipticLatitude(double julianDate)
        {
            var julianMillennias = Tools.GetMillenniasCount(julianDate);// (julianDate - 2451545) / 365250;

            var sunLatitudeBase = GetCalculatedValue(PositionByOrbitalElementsArray.GetSunLatitudeBaseArray(), julianMillennias);
            var sunLatitudeFirstGroup = GetCalculatedValue(PositionByOrbitalElementsArray.GetSunLatitudeFirstArray(), julianMillennias);

            double value = (sunLatitudeBase + sunLatitudeFirstGroup * julianMillennias) / 100000000;
            
            return CoordinateTransformation.MapToMinus90To90Range(CoordinateTransformation.SetRadiansToDegrees(value));
        }       
        public static double GetSunRadiusVector(double julianDate)
        {
            double julianMillennias = Tools.GetMillenniasCount(julianDate);

            var sunRadiusBase = GetCalculatedValue(PositionByOrbitalElementsArray.GetSunRadiusBaseArray(), julianMillennias);
            var sunRadiusFirstGroup = GetCalculatedValue(PositionByOrbitalElementsArray.GetSunRadiusFirstArray(), julianMillennias);
            var sunRadiusSecondGroup = GetCalculatedValue(PositionByOrbitalElementsArray.GetSunRadiusSecondArray(), julianMillennias);
            var sunRadiusThirdGroup = GetCalculatedValue(PositionByOrbitalElementsArray.GetSunRadiusThirdArray(), julianMillennias);
            var sunRadiusFourthGroup = GetCalculatedValue(PositionByOrbitalElementsArray.GetSunRadiusFourthArray(), julianMillennias);
            
            return 
                (sunRadiusBase 
                + sunRadiusFirstGroup * julianMillennias 
                + sunRadiusSecondGroup * Tools.GetRaisedValue(julianMillennias, Power.Square)
                + sunRadiusThirdGroup * Tools.GetRaisedValue(julianMillennias, Power.Cube)
                + sunRadiusFourthGroup * Tools.GetRaisedValue(julianMillennias, Power.Fourth)) 
                / 100000000;
        }
        private static double GetCalculatedValue(PositionByOrbitalElements[] collection, double dateOffset)
        {
            double result = 0;
            for (int i = 0; i < collection.Length; i++)
            {
                result += collection[i].First * Math.Cos(collection[i].Second + collection[i].Third * dateOffset);
            }
            return result;
        }
    }
    

}
