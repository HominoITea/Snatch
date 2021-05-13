using System;
using System.Collections.Generic;
using System.Text;

namespace CelestialComputation.Coefficients
{
    //Cumulative leap second values from 1 Jan 1961 to 1 January 2017 as taken from http://maia.usno.navy.mil/ser7/tai-utc.dat
    internal static class LeapSecondsArray
    {
        public static LeapSeconds[] GetArray ()
        {
            return new LeapSeconds[]
            {
                new LeapSeconds (2437300.5, 1.4228180, 37300, 0.001296),
                new LeapSeconds (2437512.5, 1.3728180, 37300, 0.001296),
                new LeapSeconds (2437665.5, 1.8458580, 37665, 0.0011232),
                new LeapSeconds(2438334.5, 1.9458580, 37665, 0.0011232),
                new LeapSeconds (2438395.5, 3.2401300, 38761, 0.001296 ),
                new LeapSeconds (2438486.5, 3.3401300, 38761, 0.001296 ),
                new LeapSeconds (2438639.5, 3.4401300, 38761, 0.001296 ),
                new LeapSeconds (2438761.5, 3.5401300, 38761, 0.001296 ),
                new LeapSeconds (2438820.5, 3.6401300, 38761, 0.001296 ),
                new LeapSeconds (2438942.5, 3.7401300, 38761, 0.001296 ),
                new LeapSeconds (2439004.5, 3.8401300, 38761, 0.001296 ),
                new LeapSeconds (2439126.5, 4.3131700, 39126, 0.002592 ),
                new LeapSeconds (2439887.5, 4.2131700, 39126, 0.002592 ),
                new LeapSeconds (2441317.5, 10.0,      41317, 0.0      ),
                new LeapSeconds (2441499.5, 11.0,      41317, 0.0      ),
                new LeapSeconds (2441683.5, 12.0,      41317, 0.0      ),
                new LeapSeconds (2442048.5, 13.0,      41317, 0.0      ),
                new LeapSeconds (2442413.5, 14.0,      41317, 0.0      ),
                new LeapSeconds (2442778.5, 15.0,      41317, 0.0      ),
                new LeapSeconds (2443144.5, 16.0,      41317, 0.0      ),
                new LeapSeconds (2443509.5, 17.0,      41317, 0.0      ),
                new LeapSeconds (2443874.5, 18.0,      41317, 0.0      ),
                new LeapSeconds (2444239.5, 19.0,      41317, 0.0      ),
                new LeapSeconds (2444786.5, 20.0,      41317, 0.0      ),
                new LeapSeconds (2445151.5, 21.0,      41317, 0.0      ),
                new LeapSeconds (2445516.5, 22.0,      41317, 0.0      ),
                new LeapSeconds (2446247.5, 23.0,      41317, 0.0      ),
                new LeapSeconds (2447161.5, 24.0,      41317, 0.0      ),
                new LeapSeconds (2447892.5, 25.0,      41317, 0.0      ),
                new LeapSeconds (2448257.5, 26.0,      41317, 0.0      ),
                new LeapSeconds (2448804.5, 27.0,      41317, 0.0      ),
                new LeapSeconds (2449169.5, 28.0,      41317, 0.0      ),
                new LeapSeconds (2449534.5, 29.0,      41317, 0.0      ),
                new LeapSeconds (2450083.5, 30.0,      41317, 0.0      ),
                new LeapSeconds (2450630.5, 31.0,      41317, 0.0      ),
                new LeapSeconds (2451179.5, 32.0,      41317, 0.0      ),
                new LeapSeconds (2453736.5, 33.0,      41317, 0.0      ),
                new LeapSeconds (2454832.5, 34.0,      41317, 0.0      ),
                new LeapSeconds (2456109.5, 35.0,      41317, 0.0      ),
                new LeapSeconds (2457204.5, 36.0,      41317, 0.0      ),
                new LeapSeconds (2457754.5, 37.0,      41317, 0.0      )
            };
        }
    }
}
