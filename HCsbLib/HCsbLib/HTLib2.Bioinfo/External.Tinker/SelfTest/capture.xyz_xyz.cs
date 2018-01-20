using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HTLib2.Bioinfo
{
    public partial class Tinker
    {
        public partial class Selftest
        {
            public static readonly string[] selftest_xyz = new string[]
{
"   186  GNOMES, ROCK MONSTERS AND CHILI SAUCE",
"     1  NH3  -11.020000  -12.540000  -24.210000    65     2     5     6     7",
"     2  CT1  -12.460000  -12.650000  -24.060000    24     1     3     8     9",
"     3  C    -12.800000  -14.020000  -23.500000    20     2     4    25",
"     4  O    -12.120000  -15.000000  -23.800000    74     3",
"     5  HC   -10.790000  -11.640000  -24.580000     6     1",
"     6  HC   -10.580000  -12.660000  -23.320000     6     1",
"     7  HC   -10.700000  -13.250000  -24.840000     6     1",
"     8  HB   -12.740000  -11.930000  -23.430000     5     2",
"     9  CT2  -13.150000  -12.430000  -25.410000    26     2    10    14    15",
"    10  CT2  -14.610000  -12.030000  -25.280000    26     9    11    16    17",
"    11  CT2  -15.320000  -12.030000  -26.620000    26    10    12    18    19",
"    12  CT2  -16.820000  -12.190000  -26.420000    58    11    13    20    21",
"    13  NH3  -17.100000  -13.270000  -25.420000    65    12    22    23    24",
"    14  HA   -13.100000  -13.280000  -25.940000     1     9",
"    15  HA   -12.670000  -11.710000  -25.910000     1     9",
"    16  HA   -14.650000  -11.110000  -24.890000     1    10",
"    17  HA   -15.070000  -12.680000  -24.670000     1    10",
"    18  HA   -14.970000  -12.790000  -27.180000     1    11",
"    19  HA   -15.140000  -11.160000  -27.090000     1    11",
"    20  HA   -17.250000  -12.430000  -27.280000    17    12",
"    21  HA   -17.200000  -11.330000  -26.080000    17    12",
"    22  HC   -18.090000  -13.360000  -25.290000     6    13",
"    23  HC   -16.730000  -14.140000  -25.750000     6    13",
"    24  HC   -16.680000  -13.040000  -24.540000     6    13",
"    25  NH1  -13.830000  -14.080000  -22.660000    63     3    26    29",
"    26  CT1  -14.300000  -15.350000  -22.110000    23    25    27    30    31",
"    27  C    -15.270000  -16.040000  -23.050000    20    26    28    44",
"    28  O    -16.370000  -15.530000  -23.300000    74    27",
"    29  H    -14.300000  -13.240000  -22.400000     3    25",
"    30  HB   -13.470000  -15.910000  -22.010000     4    26",
"    31  CT2  -14.970000  -15.140000  -20.760000    26    26    32    35    36",
"    32  CT1  -14.080000  -14.610000  -19.640000    25    31    33    34    37",
"    33  CT3  -14.870000  -14.540000  -18.350000    27    32    38    39    40",
"    34  CT3  -12.870000  -15.500000  -19.480000    27    32    41    42    43",
"    35  HA   -15.350000  -16.010000  -20.470000     1    31",
"    36  HA   -15.720000  -14.480000  -20.890000     1    31",
"    37  HA   -13.760000  -13.690000  -19.860000     1    32",
"    38  HA   -14.290000  -14.200000  -17.610000     1    33",
"    39  HA   -15.650000  -13.930000  -18.470000     1    33",
"    40  HA   -15.200000  -15.460000  -18.110000     1    33",
"    41  HA   -12.290000  -15.150000  -18.750000     1    34",
"    42  HA   -13.170000  -16.430000  -19.260000     1    34",
"    43  HA   -12.360000  -15.520000  -20.340000     1    34",
"    44  NH1  -14.870000  -17.180000  -23.570000    63    27    45    48",
"    45  CT1  -15.720000  -17.950000  -24.470000    23    44    46    49    50",
"    46  C    -16.190000  -19.230000  -23.800000    20    45    47    66",
"    47  O    -15.670000  -19.640000  -22.750000    74    46",
"    48  H    -13.960000  -17.530000  -23.350000     3    44",
"    49  HB   -16.500000  -17.360000  -24.670000     4    45",
"    50  CT2  -14.960000  -18.300000  -25.740000    26    45    51    55    56",
"    51  CT2  -14.450000  -17.110000  -26.500000    26    50    52    57    58",
"    52  CT2  -15.580000  -16.310000  -27.120000    26    51    53    59    60",
"    53  CT2  -16.200000  -17.050000  -28.290000    58    52    54    61    62",
"    54  NH3  -17.080000  -16.150000  -29.090000    65    53    63    64    65",
"    55  HA   -15.560000  -18.820000  -26.340000     1    50",
"    56  HA   -14.170000  -18.870000  -25.490000     1    50",
"    57  HA   -13.840000  -17.420000  -27.230000     1    51",
"    58  HA   -13.940000  -16.520000  -25.880000     1    51",
"    59  HA   -15.220000  -15.440000  -27.440000     1    52",
"    60  HA   -16.280000  -16.150000  -26.430000     1    52",
"    61  HA   -16.750000  -17.810000  -27.940000    17    53",
"    62  HA   -15.470000  -17.410000  -28.880000    17    53",
"    63  HC   -17.470000  -16.670000  -29.850000     6    54",
"    64  HC   -17.810000  -15.800000  -28.510000     6    54",
"    65  HC   -16.540000  -15.390000  -29.450000     6    54",
"    66  NH1  -17.160000  -19.890000  -24.400000    63    46    67    70",
"    67  CT1  -17.630000  -21.160000  -23.890000    23    66    68    71    72",
"    68  C    -17.490000  -22.240000  -24.950000    20    67    69    82",
"    69  O    -17.800000  -22.000000  -26.120000    74    68",
"    70  H    -17.570000  -19.510000  -25.230000     3    66",
"    71  HB   -17.050000  -21.350000  -23.100000     4    67",
"    72  CT1  -19.110000  -21.060000  -23.450000    25    67    73    74    75",
"    73  CT3  -19.650000  -22.430000  -23.050000    27    72    76    77    78",
"    74  CT3  -19.250000  -20.050000  -22.320000    27    72    79    80    81",
"    75  HA   -19.660000  -20.730000  -24.220000     1    72",
"    76  HA   -20.610000  -22.340000  -22.770000     1    73",
"    77  HA   -19.590000  -23.050000  -23.830000     1    73",
"    78  HA   -19.110000  -22.800000  -22.290000     1    73",
"    79  HA   -20.210000  -19.990000  -22.040000     1    74",
"    80  HA   -18.690000  -20.350000  -21.540000     1    74",
"    81  HA   -18.940000  -19.150000  -22.630000     1    74",
"    82  NH1  -17.020000  -23.410000  -24.550000    63    68    83    86",
"    83  CT1  -17.030000  -24.600000  -25.390000    23    82    84    87    88",
"    84  C    -17.720000  -25.690000  -24.600000    20    83    85   101",
"    85  O    -17.300000  -26.000000  -23.480000    74    84",
"    86  H    -16.650000  -23.480000  -23.620000     3    82",
"    87  HB   -17.520000  -24.380000  -26.230000     4    83",
"    88  CT2  -15.600000  -25.010000  -25.770000    26    83    89    92    93",
"    89  CT1  -15.430000  -26.200000  -26.720000    25    88    90    91    94",
"    90  CT3  -16.080000  -25.900000  -28.050000    27    89    95    96    97",
"    91  CT3  -13.960000  -26.540000  -26.920000    27    89    98    99   100",
"    92  HA   -15.120000  -25.230000  -24.920000     1    88",
"    93  HA   -15.170000  -24.220000  -26.200000     1    88",
"    94  HA   -15.880000  -27.000000  -26.310000     1    89",
"    95  HA   -15.970000  -26.680000  -28.660000     1    90",
"    96  HA   -17.060000  -25.730000  -27.910000     1    90",
"    97  HA   -15.660000  -25.090000  -28.460000     1    90",
"    98  HA   -13.870000  -27.320000  -27.540000     1    91",
"    99  HA   -13.480000  -25.750000  -27.310000     1    91",
"   100  HA   -13.540000  -26.770000  -26.030000     1    91",
"   101  NH1  -18.780000  -26.270000  -25.150000    63    84   102   105",
"   102  CT2  -19.560000  -27.220000  -24.380000    28   101   103   106   107",
"   103  C    -20.190000  -28.320000  -25.190000    20   102   104   108",
"   104  O    -20.040000  -28.390000  -26.420000    74   103",
"   105  H    -19.040000  -26.040000  -26.080000     3   101",
"   106  HB   -20.280000  -26.700000  -23.920000     4   102",
"   107  HB   -18.950000  -27.620000  -23.700000     4   102",
"   108  NH1  -20.910000  -29.190000  -24.490000    63   103   109   112",
"   109  CT1  -21.540000  -30.350000  -25.090000    23   108   110   113   114",
"   110  C    -23.010000  -30.370000  -24.730000    20   109   111   120",
"   111  O    -23.410000  -29.810000  -23.710000    74   110",
"   112  H    -21.020000  -29.030000  -23.510000     3   108",
"   113  HB   -21.420000  -30.250000  -26.070000     4   109",
"   114  CT2  -20.890000  -31.630000  -24.580000    54   109   115   118   119",
"   115  CC   -19.440000  -31.740000  -24.980000    55   114   116   117",
"   116  OC   -19.200000  -31.950000  -26.180000    78   115",
"   117  OC   -18.550000  -31.600000  -24.110000    78   115",
"   118  HA   -21.380000  -32.420000  -24.950000     1   114",
"   119  HA   -20.940000  -31.650000  -23.580000     1   114",
"   120  NH1  -23.810000  -31.040000  -25.560000    63   110   121   124",
"   121  CT1  -25.230000  -31.210000  -25.290000    23   120   122   125   126",
"   122  C    -25.490000  -32.630000  -24.840000    20   121   123   136",
"   123  O    -25.040000  -33.580000  -25.470000    74   122",
"   124  H    -23.420000  -31.430000  -26.390000     3   120",
"   125  HB   -25.430000  -30.550000  -24.570000     4   121",
"   126  CT1  -26.080000  -30.920000  -26.540000    25   121   127   128   129",
"   127  CT3  -27.550000  -31.030000  -26.210000    27   126   130   131   132",
"   128  CT3  -25.770000  -29.550000  -27.090000    27   126   133   134   135",
"   129  HA   -25.860000  -31.600000  -27.240000     1   126",
"   130  HA   -28.090000  -30.850000  -27.030000     1   127",
"   131  HA   -27.750000  -31.960000  -25.880000     1   127",
"   132  HA   -27.790000  -30.370000  -25.500000     1   127",
"   133  HA   -26.330000  -29.390000  -27.900000     1   128",
"   134  HA   -25.970000  -28.860000  -26.400000     1   128",
"   135  HA   -24.800000  -29.500000  -27.340000     1   128",
"   136  NH1  -26.230000  -32.780000  -23.750000    63   122   137   140",
"   137  CT1  -26.610000  -34.110000  -23.280000    23   136   138   141   142",
"   138  C    -28.100000  -34.200000  -23.000000    20   137   139   155",
"   139  O    -28.780000  -33.180000  -22.920000    74   138",
"   140  H    -26.530000  -31.970000  -23.240000     3   136",
"   141  HB   -26.370000  -34.700000  -24.060000     4   137",
"   142  CT1  -25.840000  -34.540000  -22.010000    25   137   143   144   146",
"   143  CT2  -26.220000  -33.670000  -20.810000    26   142   145   147   148",
"   144  CT3  -24.340000  -34.460000  -22.250000    27   142   149   150   151",
"   145  CT3  -25.640000  -34.160000  -19.480000    27   143   152   153   154",
"   146  HA   -26.090000  -35.490000  -21.800000     1   142",
"   147  HA   -25.890000  -32.740000  -20.980000     1   143",
"   148  HA   -27.220000  -33.660000  -20.730000     1   143",
"   149  HA   -23.860000  -34.740000  -21.420000     1   144",
"   150  HA   -24.090000  -35.070000  -23.000000     1   144",
"   151  HA   -24.090000  -33.520000  -22.490000     1   144",
"   152  HA   -25.920000  -33.550000  -18.750000     1   145",
"   153  HA   -25.970000  -35.080000  -19.290000     1   145",
"   154  HA   -24.640000  -34.170000  -19.540000     1   145",
"   155  NH1  -28.600000  -35.420000  -22.870000    63   138   156   159",
"   156  CT1  -29.980000  -35.660000  -22.500000    23   155   157   160   161",
"   157  C    -29.990000  -36.120000  -21.060000    20   156   158   170",
"   158  O    -29.300000  -37.080000  -20.700000    74   157",
"   159  H    -28.000000  -36.210000  -23.030000     3   155",
"   160  HB   -30.490000  -34.810000  -22.630000     4   156",
"   161  CT2  -30.570000  -36.760000  -23.390000    26   156   162   166   167",
"   162  CT2  -31.960000  -37.220000  -23.000000    54   161   163   168   169",
"   163  CC   -33.030000  -36.230000  -23.390000    55   162   164   165",
"   164  OC   -32.730000  -35.310000  -24.180000    78   163",
"   165  OC   -34.180000  -36.370000  -22.920000    78   163",
"   166  HA   -29.960000  -37.550000  -23.350000     1   161",
"   167  HA   -30.610000  -36.420000  -24.330000     1   161",
"   168  HA   -31.990000  -37.340000  -22.000000     1   162",
"   169  HA   -32.150000  -38.090000  -23.440000     1   162",
"   170  NH1  -30.740000  -35.410000  -20.230000    63   157   171   174",
"   171  CT1  -30.820000  -35.750000  -18.810000    23   170   172   175   176",
"   172  CC   -32.250000  -36.040000  -18.390000    22   171   173   186",
"   173  OC   -33.200000  -35.730000  -19.120000    79   172",
"   174  H    -31.260000  -34.630000  -20.580000     3   170",
"   175  HB   -30.250000  -36.560000  -18.730000     4   171",
"   176  CT1  -30.280000  -34.620000  -17.950000    25   171   177   178   179",
"   177  CT3  -28.800000  -34.400000  -18.210000    27   176   180   181   182",
"   178  CT3  -31.080000  -33.360000  -18.190000    27   176   183   184   185",
"   179  HA   -30.380000  -34.850000  -16.980000     1   176",
"   180  HA   -28.460000  -33.660000  -17.640000     1   177",
"   181  HA   -28.300000  -35.240000  -18.000000     1   177",
"   182  HA   -28.670000  -34.170000  -19.170000     1   177",
"   183  HA   -30.720000  -32.620000  -17.620000     1   178",
"   184  HA   -31.000000  -33.100000  -19.160000     1   178",
"   185  HA   -32.040000  -33.520000  -17.970000     1   178",
"   186  OC   -32.460000  -36.590000  -17.310000    79   172",
};
        }
    }
}