﻿using StatisticsRomania.BusinessObjects;
using System.Collections.Generic;

namespace StatisticsRomania.Repository.Seeders
{
    internal class AverageGrossSalarySeeder : BaseSeeder
    {
        internal static List<AverageGrossSalary> GetData()
        {
            var rawData = new List<string>
                                       {
                                           // 2014, 2015
                                           "2014 10 Alba 1989 1981 2155 2042 2113 2130 2124 2118 2115 2150 2133 2163 2237 2277 2529",
                                           "2014 10 Arad 2128 2202 2275 2138 2152 2217 2201 2162 2256 2337 2210 2290 2328 2403 2571",
                                           "2014 10 Arges 2318 2347 2624 2256 2275 2350 2541 2493 2713 2666 2403 2409 2436 2420 2766",
                                           "2014 10 Bacau 1889 1947 2089 1791 1782 1908 1903 1902 1941 1986 1971 1981 2017 2093 2303",
                                           "2014 10 Bihor 1762 1799 1843 1771 1750 1823 1829 1823 1851 1896 1865 1901 1955 2004 2111",
                                           "2014 10 BistritaNasaud 1816 1864 1869 1753 1731 1801 1799 1766 1794 1890 1866 1937 1981 1993 2068",
                                           "2014 10 Botosani 1688 1705 1806 1817 1791 1819 1829 1800 1826 1871 1845 1871 1921 1942 2163",
                                           "2014 10 Brasov 2224 2358 2431 2297 2298 2489 2414 2383 2482 2443 2406 2421 2510 2630 2834",
                                           "2014 10 Braila 1744 1737 1847 1796 1765 1808 1853 1791 1803 1884 1830 1842 1901 1908 2103",
                                           "2014 10 Buzau 1863 1872 2073 1867 1874 1939 1960 1938 1952 1971 1984 1998 2038 2028 2256",
                                           "2014 10 CarasSeverin 1735 1779 1759 1745 1753 1784 1815 1826 1835 1862 1873 1898 1954 1955 2017",
                                           "2014 10 Calarasi 1816 1823 1901 1853 1838 1941 1907 1933 1948 2053 1966 2012 2088 2094 2258",
                                           "2014 10 Cluj 2500 2581 2655 2552 2541 2655 2767 2648 2738 2807 2709 2737 2848 2906 3260",
                                           "2014 10 Constanta 2184 2246 2422 2319 2300 2401 2503 2443 2397 2458 2442 2481 2554 2607 2933",
                                           "2014 10 Covasna 1713 1712 1825 1763 1731 1840 1751 1764 1785 1825 1831 1821 1877 1898 2069",
                                           "2014 10 Dambovita 1869 1872 1967 1960 1922 2015 2069 1984 2065 2087 2048 2094 2141 2132 2339",
                                           "2014 10 Dolj 2092 2149 2341 2268 2143 2152 2232 2150 2126 2272 2209 2211 2325 2302 2533",
                                           "2014 10 Galati 2168 2166 2370 2225 2205 2275 2327 2245 2269 2315 2318 2305 2342 2355 2654",
                                           "2014 10 Giurgiu 1692 1720 1840 1859 1805 1853 1939 1915 1884 1955 1906 1958 2041 2024 2266",
                                           "2014 10 Gorj 2242 2319 2473 2320 2293 2414 2614 2371 2310 2431 2511 2434 2510 2562 2915",
                                           "2014 10 Harghita 1565 1559 1610 1644 1643 1679 1686 1672 1713 1762 1741 1777 1827 1830 1973",
                                           "2014 10 Hunedoara 1960 1957 2106 1999 1993 2059 2102 1997 2012 2083 2033 2039 2115 2146 2346",
                                           "2014 10 Ialomita 1807 1797 1931 1774 1776 1845 1853 1850 1851 1865 1866 1933 1967 1983 2180",
                                           "2014 10 Iasi 2162 2209 2290 2246 2224 2321 2308 2330 2312 2348 2353 2374 2446 2518 2699",
                                           "2014 10 Ilfov 2724 2920 3096 2793 2809 3027 2902 2915 2906 3016 2924 2983 3007 3095 3495",
                                           "2014 10 Maramures 1702 1750 1768 1732 1734 1799 1779 1777 1803 1892 1864 1896 1967 2042 2127",
                                           "2014 10 Mehedinti 1951 2006 2142 1971 1948 2018 2059 2022 2001 2048 2159 2145 2088 2102 2317",
                                           "2014 10 Mures 2052 2061 2264 2148 2197 2282 2499 2245 2281 2297 2290 2280 2341 2366 2667",
                                           "2014 10 Neamt 1728 1708 1810 1758 1746 1801 1817 1787 1773 1811 1846 1850 1896 1894 2086",
                                           "2014 10 Olt 1961 1990 2143 1999 1985 2165 2090 2070 2212 2172 2254 2196 2216 2305 2537",
                                           "2014 10 Prahova 2232 2276 2372 2222 2241 2346 2331 2321 2278 2299 2287 2333 2357 2425 2608",
                                           "2014 10 SatuMare 1873 1859 1914 1816 1823 1986 1883 1896 1903 1969 1944 1790 2045 2048 2183",
                                           "2014 10 Salaj 2024 1859 1924 1816 1855 1868 1852 1830 1883 1981 1929 1992 2143 2008 2152",
                                           "2014 10 Sibiu 2432 2479 2912 2558 2476 2615 2784 2691 2596 2690 2628 2655 2721 2844 3040",
                                           "2014 10 Suceava 1701 1706 1798 1716 1641 1699 1697 1747 1708 1742 1744 1787 1822 1838 2027",
                                           "2014 10 Teleorman 1675 1694 1716 1905 1862 1896 1906 1893 1917 1963 1972 1974 2032 2061 2205",
                                           "2014 10 Timis 2438 2724 2738 2481 2497 2694 2690 2601 2710 2685 2585 2640 2713 3026 3078",
                                           "2014 10 Tulcea 1984 1950 2083 1879 1858 1909 2077 1907 1948 2004 2004 1926 1973 1991 2207",
                                           "2014 10 Vaslui 1700 1691 1747 1687 1675 1747 1773 1741 1729 1797 1775 1796 1893 1897 2053",
                                           "2014 10 Valcea 1856 1887 1986 1909 1904 1955 2034 2005 2009 2081 2085 2078 2125 2202 2316",
                                           "2014 10 Vrancea 1724 1711 1816 1774 1760 1833 1844 1822 1831 1890 1917 1897 1991 1993 2255",
                                           "2014 10 Bucuresti 3271 3314 3631 3344 3329 3581 3637 3520 3494 3543 3473 3509 3539 3624 4083",
                                           // 2016
                                            "2016 1 Alba 2342 2409 2488 2488 2501 2539 2550 2565 2602 2651",
                                            "2016 1 Arad 2358 2391 2462 2499 2558 2638 2613 2571 2648 2691",
                                            "2016 1 Arges 2449 2476 2488 3064 2757 2634 2828 2655 2665 2681",
                                            "2016 1 Bacau 2228 2237 2341 2331 2361 2435 2442 2505 2571 2496",
                                            "2016 1 Bihor 2057 2024 2087 2100 2194 2204 2218 2234 2258 2284",
                                            "2016 1 BistritaNasaud 2038 1996 2073 2069 2190 2129 2221 2170 2137 2156",
                                            "2016 1 Botosani 2074 2062 2101 2138 2145 2142 2123 2178 2190 2239",
                                            "2016 1 Brasov 2520 2522 2648 2729 2673 2803 2698 2716 2758 2805",
                                            "2016 1 Braila 1954 1955 2016 2047 2107 2151 2143 2135 2142 2190",
                                            "2016 1 Buzau 2190 2189 2220 2263 2346 2349 2356 2412 2377 2386",
                                            "2016 1 CarasSeverin 1964 1992 2023 2080 2128 2176 2118 2187 2285 2307",
                                            "2016 1 Calarasi 2154 2153 2226 2276 2307 2377 2356 2341 2419 2451",
                                            "2016 1 Cluj 2959 2920 3081 3111 3170 3130 3248 3249 3222 3240",
                                            "2016 1 Constanta 2504 2473 2557 2675 2598 2619 2652 2646 2662 2700",
                                            "2016 1 Covasna 1959 1965 2121 2002 2098 2137 2126 2257 2169 2195",
                                            "2016 1 Dambovita 2231 2166 2313 2245 2317 2324 2348 2398 2423 2444",
                                            "2016 1 Dolj 2396 2441 2412 2461 2479 2481 2551 2530 2533 2600",
                                            "2016 1 Galati 2418 2415 2490 2562 2583 2586 2582 2662 2657 2675",
                                            "2016 1 Giurgiu 2228 2208 2258 2253 2369 2304 2268 2304 2341 2377",
                                            "2016 1 Gorj 2588 2528 2523 2671 2575 2596 2670 2723 2637 2762",
                                            "2016 1 Harghita 1897 1871 1934 1916 2038 2047 2066 2104 2134 2126",
                                            "2016 1 Hunedoara 2172 2182 2205 2249 2226 2244 2229 2266 2328 2321",
                                            "2016 1 Ialomita 1997 2000 2061 2133 2132 2169 2103 2149 2193 2200",
                                            "2016 1 Iasi 2561 2546 2608 2625 2660 2690 2664 2666 2725 2790",
                                            "2016 1 Ilfov 3043 3023 3216 3211 3211 3188 3290 3228 3243 3288",
                                            "2016 1 Maramures 1998 2003 2048 2055 2096 2127 2131 2198 2218 2243",
                                            "2016 1 Mehedinti 2251 2257 2288 2305 2358 2342 2296 2376 2366 2395",
                                            "2016 1 Mures 2363 2350 2427 2624 2538 2605 2515 2545 2554 2568",
                                            "2016 1 Neamt 1922 1960 1988 2032 2087 2144 2121 2117 2150 2182",
                                            "2016 1 Olt 2227 2195 2280 2379 2349 2398 2356 2460 2406 2399",
                                            "2016 1 Prahova 2472 2512 2656 2629 2656 2647 2628 2689 2707 2684",
                                            "2016 1 SatuMare 2062 2121 2201 2118 2174 2168 2162 2192 2212 2285",
                                            "2016 1 Salaj 2012 2038 2068 2113 2135 2152 2191 2192 2185 2365",
                                            "2016 1 Sibiu 2777 2721 2870 3082 3019 2918 2966 2970 2978 2945",
                                            "2016 1 Suceava 1915 1912 1973 2021 2144 2091 2052 2084 2116 2155",
                                            "2016 1 Teleorman 1998 1985 2032 2026 2050 2075 2079 2126 2096 2159",
                                            "2016 1 Timis 2765 2788 2949 3058 2984 3087 3043 2980 3020 3078",
                                            "2016 1 Tulcea 2160 2136 2206 2307 2309 2315 2351 2384 2332 2383",
                                            "2016 1 Vaslui 2030 2012 2056 2055 2133 2118 2145 2146 2266 2250",
                                            "2016 1 Valcea 2089 2060 2105 2175 2174 2206 2186 2237 2260 2282",
                                            "2016 1 Vrancea 1972 1970 2002 1987 2144 2155 2152 2190 2204 2184",
                                            "2016 1 Bucuresti 3695 3732 4038 4023 3902 3944 3909 3875 3915 3898",
                                       };

            var items = GetItems<AverageGrossSalary>(rawData);

            return items;
        }
    }
}