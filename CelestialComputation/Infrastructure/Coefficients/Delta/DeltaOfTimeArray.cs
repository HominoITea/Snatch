﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CelestialComputation.Coefficients
{
    internal static class DeltaOfTimeArray
    {
        public static DeltaOfTime[] GetArray()
        {
            return new DeltaOfTime[]
            {
                //All the initial values are observed values from 1 February 1973 to 1 June 2017 as taken from http://maia.usno.navy.mil/ser7/deltat.data 
                new DeltaOfTime(2441714.5,  43.4724),
                new DeltaOfTime(2441742.5,  43.5648),
                new DeltaOfTime(2441773.5,  43.6737),
                new DeltaOfTime(2441803.5,  43.7782),
                new DeltaOfTime(2441834.5,  43.8763),
                new DeltaOfTime(2441864.5,  43.9562),
                new DeltaOfTime(2441895.5,  44.0315),
                new DeltaOfTime(2441926.5,  44.1132),
                new DeltaOfTime(2441956.5,  44.1982),
                new DeltaOfTime(2441987.5,  44.2952),
                new DeltaOfTime(2442017.5,  44.3936),
                new DeltaOfTime(2442048.5,  44.4841),
                new DeltaOfTime(2442079.5,  44.5646),
                new DeltaOfTime(2442107.5,  44.6425),
                new DeltaOfTime(2442138.5,  44.7386),
                new DeltaOfTime(2442168.5,  44.8370),
                new DeltaOfTime(2442199.5,  44.9302),
                new DeltaOfTime(2442229.5,  44.9986),
                new DeltaOfTime(2442260.5,  45.0584),
                new DeltaOfTime(2442291.5,  45.1284),
                new DeltaOfTime(2442321.5,  45.2064),
                new DeltaOfTime(2442352.5,  45.2980),
                new DeltaOfTime(2442382.5,  45.3897),
                new DeltaOfTime(2442413.5,  45.4761),
                new DeltaOfTime(2442444.5,  45.5633),
                new DeltaOfTime(2442472.5,  45.6450),
                new DeltaOfTime(2442503.5,  45.7375),
                new DeltaOfTime(2442533.5,  45.8284),
                new DeltaOfTime(2442564.5,  45.9133),
                new DeltaOfTime(2442594.5,  45.9820),
                new DeltaOfTime(2442625.5,  46.0408),
                new DeltaOfTime(2442656.5,  46.1067),
                new DeltaOfTime(2442686.5,  46.1825),
                new DeltaOfTime(2442717.5,  46.2789),
                new DeltaOfTime(2442747.5,  46.3713),
                new DeltaOfTime(2442778.5,  46.4567),
                new DeltaOfTime(2442809.5,  46.5445),
                new DeltaOfTime(2442838.5,  46.6311),
                new DeltaOfTime(2442869.5,  46.7302),
                new DeltaOfTime(2442899.5,  46.8284),
                new DeltaOfTime(2442930.5,  46.9247),
                new DeltaOfTime(2442960.5,  46.9970),
                new DeltaOfTime(2442991.5,  47.0709),
                new DeltaOfTime(2443022.5,  47.1451),
                new DeltaOfTime(2443052.5,  47.2362),
                new DeltaOfTime(2443083.5,  47.3413),
                new DeltaOfTime(2443113.5,  47.4319),
                new DeltaOfTime(2443144.5,  47.5214),
                new DeltaOfTime(2443175.5,  47.6049),
                new DeltaOfTime(2443203.5,  47.6837),
                new DeltaOfTime(2443234.5,  47.7781),
                new DeltaOfTime(2443264.5,  47.8771),
                new DeltaOfTime(2443295.5,  47.9687),
                new DeltaOfTime(2443325.5,  48.0348),
                new DeltaOfTime(2443356.5,  48.0942),
                new DeltaOfTime(2443387.5,  48.1608),
                new DeltaOfTime(2443417.5,  48.2460),
                new DeltaOfTime(2443448.5,  48.3439),
                new DeltaOfTime(2443478.5,  48.4355),
                new DeltaOfTime(2443509.5,  48.5344),
                new DeltaOfTime(2443540.5,  48.6325),
                new DeltaOfTime(2443568.5,  48.7294),
                new DeltaOfTime(2443599.5,  48.8365),
                new DeltaOfTime(2443629.5,  48.9353),
                new DeltaOfTime(2443660.5,  49.0319),
                new DeltaOfTime(2443690.5,  49.1013),
                new DeltaOfTime(2443721.5,  49.1591),
                new DeltaOfTime(2443752.5,  49.2286),
                new DeltaOfTime(2443782.5,  49.3070),
                new DeltaOfTime(2443813.5,  49.4018),
                new DeltaOfTime(2443843.5,  49.4945),
                new DeltaOfTime(2443874.5,  49.5862),
                new DeltaOfTime(2443905.5,  49.6805),
                new DeltaOfTime(2443933.5,  49.7602),
                new DeltaOfTime(2443964.5,  49.8556),
                new DeltaOfTime(2443994.5,  49.9489),
                new DeltaOfTime(2444025.5,  50.0347),
                new DeltaOfTime(2444055.5,  50.1019),
                new DeltaOfTime(2444086.5,  50.1622),
                new DeltaOfTime(2444117.5,  50.2260),
                new DeltaOfTime(2444147.5,  50.2968),
                new DeltaOfTime(2444178.5,  50.3831),
                new DeltaOfTime(2444208.5,  50.4599),
                new DeltaOfTime(2444239.5,  50.5387),
                new DeltaOfTime(2444270.5,  50.6161),
                new DeltaOfTime(2444299.5,  50.6866),
                new DeltaOfTime(2444330.5,  50.7658),
                new DeltaOfTime(2444360.5,  50.8454),
                new DeltaOfTime(2444391.5,  50.9187),
                new DeltaOfTime(2444421.5,  50.9761),
                new DeltaOfTime(2444452.5,  51.0278),
                new DeltaOfTime(2444483.5,  51.0843),
                new DeltaOfTime(2444513.5,  51.1538),
                new DeltaOfTime(2444544.5,  51.2319),
                new DeltaOfTime(2444574.5,  51.3063),
                new DeltaOfTime(2444605.5,  51.3808),
                new DeltaOfTime(2444636.5,  51.4526),
                new DeltaOfTime(2444664.5,  51.5160),
                new DeltaOfTime(2444695.5,  51.5985),
                new DeltaOfTime(2444725.5,  51.6809),
                new DeltaOfTime(2444756.5,  51.7573),
                new DeltaOfTime(2444786.5,  51.8133),
                new DeltaOfTime(2444817.5,  51.8532),
                new DeltaOfTime(2444848.5,  51.9014),
                new DeltaOfTime(2444878.5,  51.9603),
                new DeltaOfTime(2444909.5,  52.0328),
                new DeltaOfTime(2444939.5,  52.0985),
                new DeltaOfTime(2444970.5,  52.1668),
                new DeltaOfTime(2445001.5,  52.2316),
                new DeltaOfTime(2445029.5,  52.2938),
                new DeltaOfTime(2445060.5,  52.3680),
                new DeltaOfTime(2445090.5,  52.4465),
                new DeltaOfTime(2445121.5,  52.5180),
                new DeltaOfTime(2445151.5,  52.5752),
                new DeltaOfTime(2445182.5,  52.6178),
                new DeltaOfTime(2445213.5,  52.6668),
                new DeltaOfTime(2445243.5,  52.7340),
                new DeltaOfTime(2445274.5,  52.8056),
                new DeltaOfTime(2445304.5,  52.8792),
                new DeltaOfTime(2445335.5,  52.9565),
                new DeltaOfTime(2445366.5,  53.0445),
                new DeltaOfTime(2445394.5,  53.1268),
                new DeltaOfTime(2445425.5,  53.2197),
                new DeltaOfTime(2445455.5,  53.3024),
                new DeltaOfTime(2445486.5,  53.3747),
                new DeltaOfTime(2445516.5,  53.4335),
                new DeltaOfTime(2445547.5,  53.4778),
                new DeltaOfTime(2445578.5,  53.5300),
                new DeltaOfTime(2445608.5,  53.5845),
                new DeltaOfTime(2445639.5,  53.6523),
                new DeltaOfTime(2445669.5,  53.7256),
                new DeltaOfTime(2445700.5,  53.7882),
                new DeltaOfTime(2445731.5,  53.8367),
                new DeltaOfTime(2445760.5,  53.8830),
                new DeltaOfTime(2445791.5,  53.9443),
                new DeltaOfTime(2445821.5,  54.0042),
                new DeltaOfTime(2445852.5,  54.0536),
                new DeltaOfTime(2445882.5,  54.0856),
                new DeltaOfTime(2445913.5,  54.1084),
                new DeltaOfTime(2445944.5,  54.1463),
                new DeltaOfTime(2445974.5,  54.1914),
                new DeltaOfTime(2446005.5,  54.2452),
                new DeltaOfTime(2446035.5,  54.2958),
                new DeltaOfTime(2446066.5,  54.3427),
                new DeltaOfTime(2446097.5,  54.3911),
                new DeltaOfTime(2446125.5,  54.4320),
                new DeltaOfTime(2446156.5,  54.4898),
                new DeltaOfTime(2446186.5,  54.5456),
                new DeltaOfTime(2446217.5,  54.5977),
                new DeltaOfTime(2446247.5,  54.6355),
                new DeltaOfTime(2446278.5,  54.6532),
                new DeltaOfTime(2446309.5,  54.6776),
                new DeltaOfTime(2446339.5,  54.7174),
                new DeltaOfTime(2446370.5,  54.7741),
                new DeltaOfTime(2446400.5,  54.8253),
                new DeltaOfTime(2446431.5,  54.8713),
                new DeltaOfTime(2446462.5,  54.9161),
                new DeltaOfTime(2446490.5,  54.9581),
                new DeltaOfTime(2446521.5,  54.9997),
                new DeltaOfTime(2446551.5,  55.0476),
                new DeltaOfTime(2446582.5,  55.0912),
                new DeltaOfTime(2446612.5,  55.1132),
                new DeltaOfTime(2446643.5,  55.1328),
                new DeltaOfTime(2446674.5,  55.1532),
                new DeltaOfTime(2446704.5,  55.1898),
                new DeltaOfTime(2446735.5,  55.2416),
                new DeltaOfTime(2446765.5,  55.2838),
                new DeltaOfTime(2446796.5,  55.3222),
                new DeltaOfTime(2446827.5,  55.3613),
                new DeltaOfTime(2446855.5,  55.4063),
                new DeltaOfTime(2446886.5,  55.4629),
                new DeltaOfTime(2446916.5,  55.5111),
                new DeltaOfTime(2446947.5,  55.5524),
                new DeltaOfTime(2446977.5,  55.5812),
                new DeltaOfTime(2447008.5,  55.6004),
                new DeltaOfTime(2447039.5,  55.6262),
                new DeltaOfTime(2447069.5,  55.6656),
                new DeltaOfTime(2447100.5,  55.7168),
                new DeltaOfTime(2447130.5,  55.7698),
                new DeltaOfTime(2447161.5,  55.8197),
                new DeltaOfTime(2447192.5,  55.8615),
                new DeltaOfTime(2447221.5,  55.9130),
                new DeltaOfTime(2447252.5,  55.9663),
                new DeltaOfTime(2447282.5,  56.0220),
                new DeltaOfTime(2447313.5,  56.0700),
                new DeltaOfTime(2447343.5,  56.0939),
                new DeltaOfTime(2447374.5,  56.1105),
                new DeltaOfTime(2447405.5,  56.1314),
                new DeltaOfTime(2447435.5,  56.1611),
                new DeltaOfTime(2447466.5,  56.2068),
                new DeltaOfTime(2447496.5,  56.2583),
                new DeltaOfTime(2447527.5,  56.3000),
                new DeltaOfTime(2447558.5,  56.3399),
                new DeltaOfTime(2447586.5,  56.3790),
                new DeltaOfTime(2447617.5,  56.4283),
                new DeltaOfTime(2447647.5,  56.4804),
                new DeltaOfTime(2447678.5,  56.5352),
                new DeltaOfTime(2447708.5,  56.5697),
                new DeltaOfTime(2447739.5,  56.5983),
                new DeltaOfTime(2447770.5,  56.6328),
                new DeltaOfTime(2447800.5,  56.6739),
                new DeltaOfTime(2447831.5,  56.7332),
                new DeltaOfTime(2447861.5,  56.7972),
                new DeltaOfTime(2447892.5,  56.8553),
                new DeltaOfTime(2447923.5,  56.9111),
                new DeltaOfTime(2447951.5,  56.9755),
                new DeltaOfTime(2447982.5,  57.0471),
                new DeltaOfTime(2448012.5,  57.1136),
                new DeltaOfTime(2448043.5,  57.1738),
                new DeltaOfTime(2448073.5,  57.2226),
                new DeltaOfTime(2448104.5,  57.2597),
                new DeltaOfTime(2448135.5,  57.3073),
                new DeltaOfTime(2448165.5,  57.3643),
                new DeltaOfTime(2448196.5,  57.4334),
                new DeltaOfTime(2448226.5,  57.5016),
                new DeltaOfTime(2448257.5,  57.5653),
                new DeltaOfTime(2448288.5,  57.6333),
                new DeltaOfTime(2448316.5,  57.6973),
                new DeltaOfTime(2448347.5,  57.7711),
                new DeltaOfTime(2448377.5,  57.8407),
                new DeltaOfTime(2448408.5,  57.9058),
                new DeltaOfTime(2448438.5,  57.9576),
                new DeltaOfTime(2448469.5,  57.9975),
                new DeltaOfTime(2448500.5,  58.0426),
                new DeltaOfTime(2448530.5,  58.1043),
                new DeltaOfTime(2448561.5,  58.1679),
                new DeltaOfTime(2448591.5,  58.2389),
                new DeltaOfTime(2448622.5,  58.3092),
                new DeltaOfTime(2448653.5,  58.3833),
                new DeltaOfTime(2448682.5,  58.4537),
                new DeltaOfTime(2448713.5,  58.5401),
                new DeltaOfTime(2448743.5,  58.6228),
                new DeltaOfTime(2448774.5,  58.6917),
                new DeltaOfTime(2448804.5,  58.7410),
                new DeltaOfTime(2448835.5,  58.7836),
                new DeltaOfTime(2448866.5,  58.8406),
                new DeltaOfTime(2448896.5,  58.8986),
                new DeltaOfTime(2448927.5,  58.9714),
                new DeltaOfTime(2448957.5,  59.0438),
                new DeltaOfTime(2448988.5,  59.1218),
                new DeltaOfTime(2449019.5,  59.2003),
                new DeltaOfTime(2449047.5,  59.2747),
                new DeltaOfTime(2449078.5,  59.3574),
                new DeltaOfTime(2449108.5,  59.4434),
                new DeltaOfTime(2449139.5,  59.5242),
                new DeltaOfTime(2449169.5,  59.5850),
                new DeltaOfTime(2449200.5,  59.6344),
                new DeltaOfTime(2449231.5,  59.6928),
                new DeltaOfTime(2449261.5,  59.7588),
                new DeltaOfTime(2449292.5,  59.8386),
                new DeltaOfTime(2449322.5,  59.9111),
                new DeltaOfTime(2449353.5,  59.9845),
                new DeltaOfTime(2449384.5,  60.0564),
                new DeltaOfTime(2449412.5,  60.1231),
                new DeltaOfTime(2449443.5,  60.2042),
                new DeltaOfTime(2449473.5,  60.2804),
                new DeltaOfTime(2449504.5,  60.3530),
                new DeltaOfTime(2449534.5,  60.4012),
                new DeltaOfTime(2449565.5,  60.4440),
                new DeltaOfTime(2449596.5,  60.4900),
                new DeltaOfTime(2449626.5,  60.5578),
                new DeltaOfTime(2449657.5,  60.6324),
                new DeltaOfTime(2449687.5,  60.7059),
                new DeltaOfTime(2449718.5,  60.7853),
                new DeltaOfTime(2449749.5,  60.8664),
                new DeltaOfTime(2449777.5,  60.9387),
                new DeltaOfTime(2449808.5,  61.0277),
                new DeltaOfTime(2449838.5,  61.1103),
                new DeltaOfTime(2449869.5,  61.1870),
                new DeltaOfTime(2449899.5,  61.2454),
                new DeltaOfTime(2449930.5,  61.2881),
                new DeltaOfTime(2449961.5,  61.3378),
                new DeltaOfTime(2449991.5,  61.4036),
                new DeltaOfTime(2450022.5,  61.4760),
                new DeltaOfTime(2450052.5,  61.5525),
                new DeltaOfTime(2450083.5,  61.6287),
                new DeltaOfTime(2450114.5,  61.6846),
                new DeltaOfTime(2450143.5,  61.7433),
                new DeltaOfTime(2450174.5,  61.8132),
                new DeltaOfTime(2450204.5,  61.8823),
                new DeltaOfTime(2450235.5,  61.9497),
                new DeltaOfTime(2450265.5,  61.9969),
                new DeltaOfTime(2450296.5,  62.0343),
                new DeltaOfTime(2450327.5,  62.0714),
                new DeltaOfTime(2450357.5,  62.1202),
                new DeltaOfTime(2450388.5,  62.1810),
                new DeltaOfTime(2450418.5,  62.2382),
                new DeltaOfTime(2450449.5,  62.2950),
                new DeltaOfTime(2450480.5,  62.3506),
                new DeltaOfTime(2450508.5,  62.3995),
                new DeltaOfTime(2450539.5,  62.4754),
                new DeltaOfTime(2450569.5,  62.5463),
                new DeltaOfTime(2450600.5,  62.6136),
                new DeltaOfTime(2450630.5,  62.6571),
                new DeltaOfTime(2450661.5,  62.6942),
                new DeltaOfTime(2450692.5,  62.7383),
                new DeltaOfTime(2450722.5,  62.7926),
                new DeltaOfTime(2450753.5,  62.8567),
                new DeltaOfTime(2450783.5,  62.9146),
                new DeltaOfTime(2450814.5,  62.9659),
                new DeltaOfTime(2450845.5,  63.0217),
                new DeltaOfTime(2450873.5,  63.0807),
                new DeltaOfTime(2450904.5,  63.1462),
                new DeltaOfTime(2450934.5,  63.2053),
                new DeltaOfTime(2450965.5,  63.2599),
                new DeltaOfTime(2450995.5,  63.2844),
                new DeltaOfTime(2451026.5,  63.2961),
                new DeltaOfTime(2451057.5,  63.3126),
                new DeltaOfTime(2451087.5,  63.3422),
                new DeltaOfTime(2451118.5,  63.3871),
                new DeltaOfTime(2451148.5,  63.4339),
                new DeltaOfTime(2451179.5,  63.4673),
                new DeltaOfTime(2451210.5,  63.4979),
                new DeltaOfTime(2451238.5,  63.5319),
                new DeltaOfTime(2451269.5,  63.5679),
                new DeltaOfTime(2451299.5,  63.6104),
                new DeltaOfTime(2451330.5,  63.6444),
                new DeltaOfTime(2451360.5,  63.6642),
                new DeltaOfTime(2451391.5,  63.6739),
                new DeltaOfTime(2451422.5,  63.6926),
                new DeltaOfTime(2451452.5,  63.7147),
                new DeltaOfTime(2451483.5,  63.7518),
                new DeltaOfTime(2451513.5,  63.7927),
                new DeltaOfTime(2451544.5,  63.8285),
                new DeltaOfTime(2451575.5,  63.8557),
                new DeltaOfTime(2451604.5,  63.8804),
                new DeltaOfTime(2451635.5,  63.9075),
                new DeltaOfTime(2451665.5,  63.9393),
                new DeltaOfTime(2451696.5,  63.9691),
                new DeltaOfTime(2451726.5,  63.9799),
                new DeltaOfTime(2451757.5,  63.9833),
                new DeltaOfTime(2451788.5,  63.9938),
                new DeltaOfTime(2451818.5,  64.0093),
                new DeltaOfTime(2451849.5,  64.0400),
                new DeltaOfTime(2451879.5,  64.0670),
                new DeltaOfTime(2451910.5,  64.0908),
                new DeltaOfTime(2451941.5,  64.1068),
                new DeltaOfTime(2451969.5,  64.1282),
                new DeltaOfTime(2452000.5,  64.1584),
                new DeltaOfTime(2452030.5,  64.1833),
                new DeltaOfTime(2452061.5,  64.2094),
                new DeltaOfTime(2452091.5,  64.2117),
                new DeltaOfTime(2452122.5,  64.2073),
                new DeltaOfTime(2452153.5,  64.2116),
                new DeltaOfTime(2452183.5,  64.2223),
                new DeltaOfTime(2452214.5,  64.2500),
                new DeltaOfTime(2452244.5,  64.2761),
                new DeltaOfTime(2452275.5,  64.2998),
                new DeltaOfTime(2452306.5,  64.3192),
                new DeltaOfTime(2452334.5,  64.3450),
                new DeltaOfTime(2452365.5,  64.3735),
                new DeltaOfTime(2452395.5,  64.3943),
                new DeltaOfTime(2452426.5,  64.4151),
                new DeltaOfTime(2452456.5,  64.4132),
                new DeltaOfTime(2452487.5,  64.4118),
                new DeltaOfTime(2452518.5,  64.4097),
                new DeltaOfTime(2452548.5,  64.4168),
                new DeltaOfTime(2452579.5,  64.4329),
                new DeltaOfTime(2452609.5,  64.4511),
                new DeltaOfTime(2452640.5,  64.4734),
                new DeltaOfTime(2452671.5,  64.4893),
                new DeltaOfTime(2452699.5,  64.5053),
                new DeltaOfTime(2452730.5,  64.5269),
                new DeltaOfTime(2452760.5,  64.5471),
                new DeltaOfTime(2452791.5,  64.5597),
                new DeltaOfTime(2452821.5,  64.5512),
                new DeltaOfTime(2452852.5,  64.5371),
                new DeltaOfTime(2452883.5,  64.5359),
                new DeltaOfTime(2452913.5,  64.5415),
                new DeltaOfTime(2452944.5,  64.5544),
                new DeltaOfTime(2452974.5,  64.5654),
                new DeltaOfTime(2453005.5,  64.5736),
                new DeltaOfTime(2453036.5,  64.5891),
                new DeltaOfTime(2453065.5,  64.6015),
                new DeltaOfTime(2453096.5,  64.6176),
                new DeltaOfTime(2453126.5,  64.6374),
                new DeltaOfTime(2453157.5,  64.6549),
                new DeltaOfTime(2453187.5,  64.6530),
                new DeltaOfTime(2453218.5,  64.6379),
                new DeltaOfTime(2453249.5,  64.6372),
                new DeltaOfTime(2453279.5,  64.6400),
                new DeltaOfTime(2453310.5,  64.6543),
                new DeltaOfTime(2453340.5,  64.6723),
                new DeltaOfTime(2453371.5,  64.6876),
                new DeltaOfTime(2453402.5,  64.7052),
                new DeltaOfTime(2453430.5,  64.7313),
                new DeltaOfTime(2453461.5,  64.7575),
                new DeltaOfTime(2453491.5,  64.7811),
                new DeltaOfTime(2453522.5,  64.8001),
                new DeltaOfTime(2453552.5,  64.7995),
                new DeltaOfTime(2453583.5,  64.7876),
                new DeltaOfTime(2453614.5,  64.7831),
                new DeltaOfTime(2453644.5,  64.7921),
                new DeltaOfTime(2453675.5,  64.8096),
                new DeltaOfTime(2453705.5,  64.8311),
                new DeltaOfTime(2453736.5,  64.8452),
                new DeltaOfTime(2453767.5,  64.8597),
                new DeltaOfTime(2453795.5,  64.8850),
                new DeltaOfTime(2453826.5,  64.9175),
                new DeltaOfTime(2453856.5,  64.9480),
                new DeltaOfTime(2453887.5,  64.9794),
                new DeltaOfTime(2453917.5,  64.9895),
                new DeltaOfTime(2453948.5,  65.0028),
                new DeltaOfTime(2453979.5,  65.0138),
                new DeltaOfTime(2454009.5,  65.0371),
                new DeltaOfTime(2454040.5,  65.0773),
                new DeltaOfTime(2454070.5,  65.1122),
                new DeltaOfTime(2454101.5,  65.1464),
                new DeltaOfTime(2454132.5,  65.1833),
                new DeltaOfTime(2454160.5,  65.2145),
                new DeltaOfTime(2454191.5,  65.2494),
                new DeltaOfTime(2454221.5,  65.2921),
                new DeltaOfTime(2454252.5,  65.3279),
                new DeltaOfTime(2454282.5,  65.3413),
                new DeltaOfTime(2454313.5,  65.3452),
                new DeltaOfTime(2454344.5,  65.3496),
                new DeltaOfTime(2454374.5,  65.3711),
                new DeltaOfTime(2454405.5,  65.3972),
                new DeltaOfTime(2454435.5,  65.4296),
                new DeltaOfTime(2454466.5,  65.4573),
                new DeltaOfTime(2454497.5,  65.4868),
                new DeltaOfTime(2454526.5,  65.5152),
                new DeltaOfTime(2454557.5,  65.5450),
                new DeltaOfTime(2454587.5,  65.5781),
                new DeltaOfTime(2454618.5,  65.6127),
                new DeltaOfTime(2454648.5,  65.6288),
                new DeltaOfTime(2454679.5,  65.6370),
                new DeltaOfTime(2454710.5,  65.6493),
                new DeltaOfTime(2454740.5,  65.6760),
                new DeltaOfTime(2454771.5,  65.7097),
                new DeltaOfTime(2454801.5,  65.7461),
                new DeltaOfTime(2454832.5,  65.7768),
                new DeltaOfTime(2454863.5,  65.8025),
                new DeltaOfTime(2454891.5,  65.8237),
                new DeltaOfTime(2454922.5,  65.8595),
                new DeltaOfTime(2454952.5,  65.8973),
                new DeltaOfTime(2454983.5,  65.9323),
                new DeltaOfTime(2455013.5,  65.9509),
                new DeltaOfTime(2455044.5,  65.9534),
                new DeltaOfTime(2455075.5,  65.9628),
                new DeltaOfTime(2455105.5,  65.9839),
                new DeltaOfTime(2455136.5,  66.0147),
                new DeltaOfTime(2455166.5,  66.0420),
                new DeltaOfTime(2455197.5,  66.0699),
                new DeltaOfTime(2455228.5,  66.0961),
                new DeltaOfTime(2455256.5,  66.1310),
                new DeltaOfTime(2455287.5,  66.1683),
                new DeltaOfTime(2455317.5,  66.2072),
                new DeltaOfTime(2455348.5,  66.2356),
                new DeltaOfTime(2455378.5,  66.2409),
                new DeltaOfTime(2455409.5,  66.2335),
                new DeltaOfTime(2455440.5,  66.2349),
                new DeltaOfTime(2455470.5,  66.2441),
                new DeltaOfTime(2455501.5,  66.2751),
                new DeltaOfTime(2455531.5,  66.3054),
                new DeltaOfTime(2455562.5,  66.3246),
                new DeltaOfTime(2455593.5,  66.3406),
                new DeltaOfTime(2455621.5,  66.3624),
                new DeltaOfTime(2455652.5,  66.3957),
                new DeltaOfTime(2455682.5,  66.4289),
                new DeltaOfTime(2455713.5,  66.4619),
                new DeltaOfTime(2455743.5,  66.4749),
                new DeltaOfTime(2455774.5,  66.4751),
                new DeltaOfTime(2455805.5,  66.4829),
                new DeltaOfTime(2455835.5,  66.5056),
                new DeltaOfTime(2455866.5,  66.5383),
                new DeltaOfTime(2455896.5,  66.5706),
                new DeltaOfTime(2455927.5,  66.6030),
                new DeltaOfTime(2455958.5,  66.6340),
                new DeltaOfTime(2455987.5,  66.6569),
                new DeltaOfTime(2456018.5,  66.6925), //1 April 2012
                new DeltaOfTime(2456048.5,  66.7289),
                new DeltaOfTime(2456079.5,  66.7579),
                new DeltaOfTime(2456109.5,  66.7708),
                new DeltaOfTime(2456140.5,  66.7740),
                new DeltaOfTime(2456171.5,  66.7846),
                new DeltaOfTime(2456201.5,  66.8103),
                new DeltaOfTime(2456232.5,  66.8400),
                new DeltaOfTime(2456262.5,  66.8779),
                new DeltaOfTime(2456293.5,  66.9069), //1 January 2013
                new DeltaOfTime(2456324.5,  66.9443), //1 Februrary 2013
                new DeltaOfTime(2456352.5,  66.9763), //1 March 2013
                new DeltaOfTime(2456383.5,  67.0258), //1 April 2013
                new DeltaOfTime(2456413.5,  67.0716), //1 May 2013
                new DeltaOfTime(2456444.5,  67.1100), //1 June 2013
                new DeltaOfTime(2456474.5,  67.1266), //1 July 2013
                new DeltaOfTime(2456505.5,  67.1331), //1 August 2013
                new DeltaOfTime(2456536.5,  67.1458), //1 September 2013
                new DeltaOfTime(2456566.5,  67.1717), //1 October 2013
                new DeltaOfTime(2456597.5,  67.2091), //1 November 2013
                new DeltaOfTime(2456627.5,  67.2460), //1 December 2013
                new DeltaOfTime(2456658.5,  67.2810), //1 January 2014
                new DeltaOfTime(2456689.5,  67.3136), //1 February 2014
                new DeltaOfTime(2456717.5,  67.3457), //1 March 2014
                new DeltaOfTime(2456748.5,  67.3890), //1 April 2014
                new DeltaOfTime(2456778.5,  67.4318), //1 May 2014
                new DeltaOfTime(2456809.5,  67.4666), //1 June 2014
                new DeltaOfTime(2456839.5,  67.4858), //1 July 2014
                new DeltaOfTime(2456870.5,  67.4989), //1 August 2014
                new DeltaOfTime(2456901.5,  67.5111), //1 September 2014
                new DeltaOfTime(2456931.5,  67.5353), //1 October 2014
                new DeltaOfTime(2456962.5,  67.5711), //1 November 2014
                new DeltaOfTime(2456992.5,  67.6070), //1 December 2014
                new DeltaOfTime(2457023.5,  67.6439), //1 January 2015
                new DeltaOfTime(2457054.5,  67.6765), //1 February 2015
                new DeltaOfTime(2457082.5,  67.7117), //1 March 2015
                new DeltaOfTime(2457113.5,  67.7591), //1 April 2015
                new DeltaOfTime(2457143.5,  67.8012), //1 May 2015
                new DeltaOfTime(2457174.5,  67.8402), //1 June 2015
                new DeltaOfTime(2457204.5,  67.8606), //1 July 2015
                new DeltaOfTime(2457235.5,  67.8822), //1 August 2015
                new DeltaOfTime(2457266.5,  67.9120), //1 September 2015
                new DeltaOfTime(2457296.5,  67.9546), //1 October 2015
                new DeltaOfTime(2457327.5,  68.0055), //1 November 2015
                new DeltaOfTime(2457357.5,  68.0514), //1 December 2015
                new DeltaOfTime(2457388.5,  68.1024), //1 January 2016
                new DeltaOfTime(2457419.5,  68.1577), //1 February 2016
                new DeltaOfTime(2457448.5,  68.2044), //1 March 2016
                new DeltaOfTime(2457479.5,  68.2665), //1 April 2016
                new DeltaOfTime(2457509.5,  68.3188), //1 May 2016
                new DeltaOfTime(2457540.5,  68.3703), //1 June 2016
                new DeltaOfTime(2457570.5,  68.3964), //1 July 2016
                new DeltaOfTime(2457601.5,  68.4094), //1 August 2016
                new DeltaOfTime(2457632.5,  68.4305), //1 September 2016
                new DeltaOfTime(2457662.5,  68.4630), //1 October 2016
                new DeltaOfTime(2457693.5,  68.5078), //1 November 2016
                new DeltaOfTime(2457723.5,  68.5537), //1 December 2016
                new DeltaOfTime(2457754.5,  68.5928), //1 January 2017
                new DeltaOfTime(2457785.5,  68.6298), //1 February 2017
                new DeltaOfTime(2457813.5,  68.6671), //1 March 2017
                new DeltaOfTime(2457844.5,  68.7135), //1 April 2017
                new DeltaOfTime(2457874.5,  68.7623), //1 May 2017
                new DeltaOfTime(2457905.5,  68.8033), //1 June 2017
                //All these final values are predicted values from Year 2017.5 to Year 2026.0 are taken from http://maia.usno.navy.mil/ser7/deltat.preds
                new DeltaOfTime(2457937.0,  68.81 ), //2017.5
                new DeltaOfTime(2458028.25, 68.86 ), //2017.75
                new DeltaOfTime(2458119.5,  68.99 ), //2018.0
                new DeltaOfTime(2458210.75, 69.14 ), //2018.25
                new DeltaOfTime(2458302.0,  69.3  ), //2018.5
                new DeltaOfTime(2458484.5,  69.5  ), //2019.0
                new DeltaOfTime(2458575.75, 69.6  ), //2019.25
                new DeltaOfTime(2458667.0,  69.7  ), //2019.5
                new DeltaOfTime(2458758.25, 69.8  ), //2019.75
                new DeltaOfTime(2458849.5,  69.9  ), //2020.0
                new DeltaOfTime(2458941.0,  70    ), //2020.25
                new DeltaOfTime(2459763.0,  71    ), //2022.5
                new DeltaOfTime(2461041.5,  72    ), //2026.0
                //Note as currently coded there is a single discontinuity of c. 2.074 seconds on 1 January 2026. At this point http://maia.usno.navy.mil/ser7/deltat.preds indicates an error value for DeltaT of about 5 seconds anyway.
            };
        }
    }
}