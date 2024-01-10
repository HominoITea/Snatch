using CelestialComputation.Coefficients;
using System;
using System.Collections.Generic;
using System.Text;

namespace CelestialComputation.Infrastructure.Converters
{
    class DynamicalTime
    {
        public static double ConvertCoordinatedTime(double julianDate) // Convert from universal coordinated time (UTC) given as a two-part pseudo-Julian date to terrestrial time(TT), represented as a two-part Julian date.
        {
            //Outside of the range 1 January 1961 to 500 days after the last leap second,
            // implement TT2UTC as TT2UT1
            const int dayOffset = 500;
            var leapSecondsArray = LeapSecondsArray.GetArray();
            int length = leapSecondsArray.Length;
            if ((julianDate < leapSecondsArray[0].JulianDate) || (julianDate > (leapSecondsArray[length - 1].JulianDate + dayOffset)))
            {
                return ConvertUniversalTime(julianDate);
            }

            double deltaOfTime = GetDeltaOfTime(julianDate);
            double leapSeconds = GetCumulativeLeapSeconds(julianDate);
            const int secondsInDay = 86400;
            const double secondsOffset = 32.184;

            return 
                julianDate 
                - ((deltaOfTime - leapSeconds - secondsOffset) / secondsInDay) 
                + (deltaOfTime / secondsInDay);
        }
        public static double GetDeltaOfTime(double julianDate)
        {
            double delta = 0;
            var deltas = DeltaOfTimeArray.GetArray();
            if ((julianDate >= deltas[0].JulianDate) && (julianDate < deltas[deltas.Length - 1].JulianDate))
            {
                //Find the index in the lookup table which contains the julianDate value closest to the julianDate input parameter
                bool isFound = false;
                int foundIndecies = 0;
                while (!isFound)
                {
                    isFound = (deltas[foundIndecies].JulianDate > julianDate);

                    if (!isFound)
                    {
                        ++foundIndecies;
                    }
                    else
                    {
                        //Now do a simple linear interpolation of the DeltaOfTime values from the lookup table
                        delta = (julianDate - deltas[foundIndecies - 1].JulianDate)
                            / (deltas[foundIndecies].JulianDate - deltas[foundIndecies - 1].JulianDate)
                            * (deltas[foundIndecies].Delta - deltas[foundIndecies - 1].Delta)
                            + deltas[foundIndecies - 1].Delta;
                    }
                }
            }
            else
            {
                delta = DeltaFinder.FindDelta(new JulianDate(julianDate).FractionalYear());
            }
            return delta;
        }
        static double ConvertUniversalTime(double julianDate)
        {
            const int secondsInDay = 86400;
            return julianDate + (GetDeltaOfTime(julianDate) / secondsInDay);
        }
        static double GetCumulativeLeapSeconds(double julianDate)
        {
            double leapSeconds = 0;
            const double daysOffset = 2400000.5;

            var leapSecondsArray = LeapSecondsArray.GetArray();
            int length = leapSecondsArray.Length;

            if (julianDate >= leapSecondsArray[0].JulianDate)
            {
                //Find the index in the lookup table which contains the JulianDate value closest to the JulianDate input parameter
                bool isContinue = true;
                int index = 1;
                while (isContinue)
                {
                    if (index >= length)
                    {
                        leapSeconds = leapSecondsArray[length - 1].Seconds 
                            + (julianDate - daysOffset - leapSecondsArray[length - 1].BaseModifiedJulian) 
                            * leapSecondsArray[length - 1].Coefficient;
                        isContinue = false;
                    }
                    else if (julianDate < leapSecondsArray[index].JulianDate)
                    {
                        leapSeconds = leapSecondsArray[index - 1].Seconds 
                            + (julianDate - daysOffset - leapSecondsArray[index - 1].BaseModifiedJulian) 
                            * leapSecondsArray[index - 1].Coefficient;
                        isContinue = false;
                    }
                    //Prepare for the next loop
                    if (isContinue)
                    {
                        ++index;
                    }
                }
            }
            return leapSeconds;
        }
    }
}
