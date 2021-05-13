using System;

namespace CelestialComputation.Infrastructure.Converters
{
    public class JulianDate
    {
        private readonly double _julian;  //Julian Day number for this date
        public double Value => _julian;
        public JulianDate(double julianDay) => (_julian) = (julianDay);
        public JulianDate(long year, long month, double day) =>_julian = ConvertDateToJulian(year, month, day, 0, 0, 0);        
        public JulianDate(long year, long month, double day, double hour, double minute, double second) => _julian = ConvertDateToJulian(year, month, day, hour, minute, second);
        
        private static double ConvertDateToJulian(long year, long month, double day, double hour, double minute, double second)
        {
            const int initialMonthNumber = 3; //March month used to initial in Julian Calendar
            if (month < initialMonthNumber)
            {
                year -= 1;
                month += 12;
            }
            const double calendarOffset = 1721118.5;
            const int dayInYear = 365;
            const int daysAfterMarch = 153;
            const int leapYear = 4;
            const int century = 100;
            const int firstMagicNumber = 457;
            const int secondMagicNumber = 5;

            const int hoursInDay = 24;
            const int minutesInDay = 1440;
            const int secondsInDay = 86400;

            double julianDay = day
                + (hour / hoursInDay)
                + (minute / minutesInDay)
                + (second / secondsInDay);

            return julianDay
                + (daysAfterMarch * month - firstMagicNumber) / secondMagicNumber
                + dayInYear * year 
                + (year / leapYear) 
                - (year / century) 
                + (year / (leapYear * century)) 
                + calendarOffset;
        }
        private static bool IsLeap(long year)
        {
            const int century = 100;
            const int leapYear = 4;

            return  (year % century) == 0 ?
                    (year % (leapYear * century)) == 0 :
                    (year % leapYear) == 0;
        }
        internal double FractionalYear()
        {
            const int daysCount = 365;
            const int leapDaysCount = 366;

            var year = GetYear();
            const long month = 1;
            const double day = 1;
            const double hour = 0;
            const double minute = 0;
            const double second = 0;

            var daysInYear = IsLeap(year) ? leapDaysCount : daysCount;
            var julianYear = ConvertDateToJulian(year, month, day, hour, minute, second);
            year += (long)((_julian - julianYear) / daysInYear);
            return year;
        }
        internal long GetYear()
        {
            const double daysInYear = 365.25;

            var integral = Math.Truncate(_julian + 0.5);
            var alpha = DecreaseIfNegative((integral - 1867216.25) / 36524.25); // What the alpha mean?
            var A = integral + 1 + alpha - DecreaseIfNegative(DecreaseIfNegative(alpha) / 4); //Stupid name from astronomical formulas. Have to be determined
            var B = A + 1524; //Stupid name from astronomical formulas
            var C = DecreaseIfNegative((B - 122.1) / daysInYear); //Stupid name from astronomical formulas
            var D = DecreaseIfNegative(daysInYear * C); //Stupid name from astronomical formulas
            var E = DecreaseIfNegative((B - D) / 30.6001); //Stupid name from astronomical formulas

            var month = (E < 14) 
                ? E - 1 
                : E - 13;
            var year = (month > 2) 
                ? C - 4716 
                : C - 4715;

            return year;

            static long DecreaseIfNegative(double value) => (value < 0) 
                ? (long)value - 1 
                : (long)value;
        }        
    }

}
