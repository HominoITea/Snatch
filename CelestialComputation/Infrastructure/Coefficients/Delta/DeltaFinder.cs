using System;
using System.Collections.Generic;
using System.Text;

namespace CelestialComputation.Coefficients
{
    internal static class DeltaFinder
    {
        //Use the polynomial expressions from Espenak & Meeus 2006. References: http://eclipse.gsfc.nasa.gov/SEcat5/deltatpoly.html and
        //http://www.staff.science.uu.nl/~gent0113/deltat/deltat_old.htm (Espenak & Meeus 2006 section)

        public static double FindDelta(double year)
        {
            if (year < -500)
            {
                double u = (year - 1820) / 100.0;
                double u2 = u * u;
                return -20 + (32 * u2);
            }
            else if (year < 500)
            {
                double u = year / 100.0;
                double u2 = u * u;
                double u3 = u2 * u;
                double u4 = u3 * u;
                double u5 = u4 * u;
                double u6 = u5 * u;
                return 10583.6 + (-1014.41 * u) + (33.78311 * u2) + (-5.952053 * u3) + (-0.1798452 * u4) + (0.022174192 * u5) + (0.0090316521 * u6);
            }
            else if (year < 1600)
            {
                double u = (year - 1000) / 100.0;
                double u2 = u * u;
                double u3 = u2 * u;
                double u4 = u3 * u;
                double u5 = u4 * u;
                double u6 = u5 * u;
                return 1574.2 + (-556.01 * u) + (71.23472 * u2) + (0.319781 * u3) + (-0.8503463 * u4) + (-0.005050998 * u5) + (0.0083572073 * u6);
            }
            else if (year < 1700)
            {
                double u = (year - 1600) / 100.0;
                double u2 = u * u;
                double u3 = u2 * u;
                return 120 + (-98.08 * u) + (-153.2 * u2) + (u3 / 0.007129);
            }
            else if (year < 1800)
            {
                double u = (year - 1700) / 100.0;
                double u2 = u * u;
                double u3 = u2 * u;
                double u4 = u3 * u;
                return 8.83 + (16.03 * u) + (-59.285 * u2) + (133.36 * u3) + (-u4 / 0.01174);
            }
            else if (year < 1860)
            {
                double u = (year - 1800) / 100.0;
                double u2 = u * u;
                double u3 = u2 * u;
                double u4 = u3 * u;
                double u5 = u4 * u;
                double u6 = u5 * u;
                double u7 = u6 * u;
                return 13.72 + (-33.2447 * u) + (68.612 * u2) + (4111.6 * u3) + (-37436 * u4) + (121272 * u5) + (-169900 * u6) + (87500 * u7);
            }
            else if (year < 1900)
            {
                double u = (year - 1860) / 100.0;
                double u2 = u * u;
                double u3 = u2 * u;
                double u4 = u3 * u;
                double u5 = u4 * u;
                return 7.62 + (57.37 * u) + (-2517.54 * u2) + (16806.68 * u3) + (-44736.24 * u4) + (u5 / 0.0000233174);
            }
            else if (year < 1920)
            {
                double u = (year - 1900) / 100.0;
                double u2 = u * u;
                double u3 = u2 * u;
                double u4 = u3 * u;
                return -2.79 + (149.4119 * u) + (-598.939 * u2) + (6196.6 * u3) + (-19700 * u4);
            }
            else if (year < 1941)
            {
                double u = (year - 1920) / 100.0;
                double u2 = u * u;
                double u3 = u2 * u;
                return 21.20 + (84.493 * u) + (-761.00 * u2) + (2093.6 * u3);
            }
            else if (year < 1961)
            {
                double u = (year - 1950) / 100.0;
                double u2 = u * u;
                double u3 = u2 * u;
                return 29.07 + (40.7 * u) + (-u2 / 0.0233) + (u3 / 0.002547);
            }
            else if (year < 1986)
            {
                double u = (year - 1975) / 100.0;
                double u2 = u * u;
                double u3 = u2 * u;
                return 45.45 + 106.7 * u - u2 / 0.026 - u3 / 0.000718;
            }
            else if (year < 2005)
            {
                double u = (year - 2000) / 100.0;
                double u2 = u * u;
                double u3 = u2 * u;
                double u4 = u3 * u;
                double u5 = u4 * u;
                return 63.86 + (33.45 * u) + (-603.74 * u2) + (1727.5 * u3) + (65181.4 * u4) + (237359.9 * u5);
            }
            else if (year < 2050)
            {
                double u = (year - 2000) / 100.0;
                double u2 = u * u;
                return 62.92 + (32.217 * u) + (55.89 * u2);
            }
            else if (year < 2150)
            {
                double u = (year - 1820) / 100.0;
                double u2 = u * u;
                return -205.72 + (56.28 * u) + (32 * u2);
            }
            else
            {
                double u = (year - 1820) / 100.0;
                double u2 = u * u;
                return -20 + (32 * u2);
            }
        }
    }
}
