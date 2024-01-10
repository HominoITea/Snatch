using System;
using System.Collections.Generic;
using System.Text;

namespace CelestialComputation.Infrastructure.Converters
{
    static class CoordinateTransformation
    {
        public static double SetDegreesToHours(double Degrees)
        {
            const int degreePerHour = 15;
            return Degrees / degreePerHour;
        }        
        public static double SetRadiansToDegrees(double radians)
        {
            const double radianToDegrees = 180 / Math.PI;
            return radians * radianToDegrees;
        }
        public static double SetDegreesToRadians(double degrees)
        {
            const double degreeToRaians = 0.017453292519943295769236907684886;
            return degrees * degreeToRaians;
        }
        public static double SetRadiansToHours(double radians)
        {
            const double radianToHours = 3.8197186342054880584532103209403;
            return radians * radianToHours;
        }
        public static double SetHoursToRadians(double hours)
        {
            const double hourToRadians = 0.26179938779914943653855361527329;
            return hours * hourToRadians;
        }
        public static double SetDMSToDegrees(double degrees, double minutes, double seconds, bool positive = true)
        {
            const int secondsInHour = 3600;
            const int minutesInHour = 60;

            return (positive) 
                ? degrees + minutes / minutesInHour + seconds / secondsInHour
                : -degrees - minutes / minutesInHour - seconds / secondsInHour;
        }
        public static double MapToMinus90To90Range(double Degrees)
        {
            double result = MapTo0To360Range(Degrees);
            const int convexAngle = 270;
            const int fullAngle = 360;
            const int unfoldedAngle = 180;
            const int rightAngle = 90;

            if (result > convexAngle)
            {
                result -= fullAngle;
            }
            else if (result > rightAngle)
            { 
                result = unfoldedAngle - result;
            }
            return result;
        }
        public static double MapTo0To360Range(double degrees)
        {
            const int fullAngle = 360;
            double result = GetModulo(degrees, fullAngle);
            return (result < 0) 
                ? result += fullAngle
                : result;
        }
        public static double MapTo0To24Range(double hourAngle)
        {
            const int hour = 24;
            double result = GetModulo(hourAngle, hour);  // HourAngle % 24;
            return (result < 0) 
                ? result += hour
                : result;
        }

        public static double MapTo0To2PIRange(double angle)
        {
            double result = GetModulo(angle, 2 * Math.PI); //Angle % 2 * Math.PI;
            return (result < 0)
                ? result += (2 * Math.PI)
                : result;
        }
        public static double GetModulo(double num, double denom) => num - Math.Truncate(num / denom) * denom;        
    }
}
