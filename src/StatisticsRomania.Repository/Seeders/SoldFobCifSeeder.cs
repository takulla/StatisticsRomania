﻿using System.Collections.Generic;
using StatisticsRomania.BusinessObjects;

namespace StatisticsRomania.Repository.Seeders
{
    internal class SoldFobCifSeeder : BaseSeeder
    {
        internal static List<SoldFobCif> GetData()
        {
            var rawData = new List<string>()
                              {
                                  // 2014, 2015
                                  "2014 10 Alba 41208 39393 38842 50264 30583 44492 42782 34413 40151 38827 28649 26482 33116 36333 9419",
                                  "2014 10 Arad 36265 53768 14970 39779 49764 26516 35173 29878 31991 29991 -1154 46419 44261 49713 28907",
                                  "2014 10 Arges 120797 174365 91336 83854 109488 122510 99986 147346 121323 116295 53708 102333 152704 148116 64130",
                                  "2014 10 Bacau -1709 1980 1279 108 -13781 -12779 -11196 -8050 -15093 -6834 -11395 -14564 -12492 -10413 -7576",
                                  "2014 10 Bihor -2686 6865 5675 -8385 -10391 7113 -15835 -10748 -830 -837 2720 -3070 3792 -1207 -14355",
                                  "2014 10 BistritaNasaud 12379 11155 4939 8890 11308 10332 11309 7960 1455 7466 4353 2861 7652 8970 -3076",
                                  "2014 10 Botosani +5508 -1234 -981 +4206 +8709 +4805 +1661 +2134 +1567 +3821 +4286 -61 +3810 +838 +975",
                                  "2014 10 Brasov 11095 283 -19145 32370 4759 22846 33061 21881 23410 -573 -6930 4552 33311 32673 -5104",
                                  "2014 10 Braila 4393 2240 +8661 -4855 +19265 +1774 -1273 +13853 +13561 +16802 +8994 -1243 -2573 -2678 +16631",
                                  "2014 10 Buzau 37386 18370 7403 20187 17557 -11668 4142 18590 1059 689 18711 17555 -626 23965 -38428",
                                  "2014 10 CarasSeverin 6832 7355 5809 9785 9883 9387 8855 7360 6669 7995 1702 9166 9142 8995 -2536",
                                  "2014 10 Calarasi +13272 +5623 +2701 +6208 -547 +1003 -6235 +3571 +2897 +8354 +10788 +2041 +10580 +718 +7991",
                                  "2014 10 Cluj -79565 -76918 -81918 -41574 -48449 -74011 -74901 -65996 -68116 -88937 -71014 -83838 -85280 -73252 -88177",
                                  "2014 10 Constanta -72757 -55042 -92583 -38130 -53061 -89984 -93633 -101906 38264 -135012 -79844 51078 -12833 -20297 -32451",
                                  "2014 10 Covasna 1118 -1666 1213 6080 6647 3852 3365 -3152 2048 5345 2494 -1895 -1421 -16 -3625",
                                  "2014 10 Dambovita 12228 11305 11372 11530 11838 11095 8489 10157 6868 11164 3312 17423 6985 5071 -1973",
                                  "2014 10 Dolj -8237 7827 17488 40011 -3994 16491 10918 12375 18463 10421 14918 11815 -9280 23905 11743",
                                  "2014 10 Galati -13565 -14642 65703 8062 9418 307 36141 -8856 -13976 -14553 -17255 -18619 -12644 -29605 -29070",
                                  "2014 10 Giurgiu -5977 -4974 -4774 242 -4334 -5622 -2827 -3587 -10585 -5230 -3401 -5255 -3982 -5665 -6064",
                                  "2014 10 Gorj -1216 372 752 -1454 -48 1664 -522 1696 -155 1633 519 -293 1608 416 517",
                                  "2014 10 Harghita -8565 -1451 -1807 -861 -141 -7218 -6762 -3575 -8881 -4403 -6656 -9701 -5775 -9060 -7126",
                                  "2014 10 Hunedoara +22270 +14062 +512 +1216 +11677 +11899 +13518 +21331 +17521 +23138 +9885 +15207 +16665 +16829 +8910",
                                  "2014 10 Ialomita 7275 8192 6973 4770 4591 5823 5663 3519 6013 7839 -1706 9530 5890 -3942 -5572",
                                  "2014 10 Iasi 8238 9668 9193 14063 5115 4101 11567 3396 -870 1596 -4711 243 -129 -678 -8626",
                                  "2014 10 Ilfov -191727 -171218 -180789 -163112 -141847 -205272 -203748 -182885 -218390 -207610 -188620 -233961 -227945 -230367 -250261",
                                  "2014 10 Maramures +27329 +25728 +20111 +32086 +25694 +22797 +19857 +28819 +18091 +24279 +25297 +18204 +26045 +15949 +16180",
                                  "2014 10 Mehedinti 1352 1340 5971 -440 2549 1056 1558 2215 683 2016 -1031 1937 2322 219 346",
                                  "2014 10 Mures 6069 -12118 -30276 -23183 -3128 -23190 -12075 -2882 -18254 -22010 -4236 -9572 -28088 -422 -29157",
                                  "2014 10 Neamt 11502 7577 7272 11984 5586 209 1023 4730 -2042 8048 -1445 6478 6681 9010 4531",
                                  "2014 10 Olt 50848 61375 48484 52691 48551 49542 61990 55751 49306 43962 49038 56455 62687 52885 42843",
                                  "2014 10 Prahova -111183 -86385 -90647 -33551 -78904 -86737 -41161 -59184 -55665 -45311 -86301 -77437 -98570 -88224 -77164",
                                  "2014 10 SatuMare -790 -3519 -1562 5608 2895 1454 -3981 3772 -414 -9402 -11384 -13482 -7043 -1656 -5589",
                                  "2014 10 Salaj 22382 35905 7603 9886 16145 14589 19981 14533 20616 6530 16867 16821 15930 26078 31896",
                                  "2014 10 Sibiu 36123 23835 9677 47752 40269 31415 28562 43570 38147 34268 20260 33748 22421 39326 11775",
                                  "2014 10 Suceava 3459 2860 -3182 -2345 -2863 -3364 -6233 -3162 -10951 -8962 -7786 -13728 -9330 -7102 -9476",
                                  "2014 10 Teleorman 16101 15241 15103 12786 7007 8604 3703 -14089 -5047 -3003 -3833 -3065 72 26242 -84",
                                  "2014 10 Timis 65429 53204 -5179 78464 77077 89944 69934 55366 56130 68655 31738 84460 58458 75725 5778",
                                  "2014 10 Tulcea -11209 -11960 35440 11968 -16186 -23488 -14539 31451 -12574 39393 -3538 -7452 51375 79191 40674",
                                  "2014 10 Vaslui 900 2651 1251 5453 3477 3974 -67 -1200 1377 5331 5778 3077 3096 3225 2182",
                                  "2014 10 Valcea 8942 8807 9875 8915 6939 6422 9435 11387 11581 10246 9246 9472 12308 9520 1689",
                                  "2014 10 Vrancea 7865 6590 1804 3846 664 -2273 -7531 1690 -699 8871 13110 -590 2314 4729 4302",
                                  "2014 10 Bucuresti -728428 -692669 -762328 -566460 -640933 -859680 -742423 -738627 -831238 -698131 -746559 -844456 -1014846 -1056932 -935570",
                                  // 2016
                                    "2016 1 Alba 29226 13315 36178 25412 18067 48345",
                                    "2016 1 Arad 41875 32096 33059 48368 21529 31151",
                                    "2016 1 Arges 137422 121223 153095 148792 131628 187942",
                                    "2016 1 Bacau -1742 -14948 -25105 -17791 -19579 -16768",
                                    "2016 1 Bihor 7685 -1584 1489 -13339 -16561 -9391",
                                    "2016 1 BistritaNasaud 4950 5853 6767 19191 4784 10572",
                                    "2016 1 Botosani 10347 9861 4975 2938 1090 5141",
                                    "2016 1 Brasov 26973 23892 13410 18218 10241 17084",
                                    "2016 1 Braila 2065 -374 -4274 8242 -5449 -6104",
                                    "2016 1 Buzau 4263 7570 6140 7321 6317 3737",
                                    "2016 1 CarasSeverin 11952 11056 10260 11245 7237 6902",
                                    "2016 1 Calarasi 11454 16419 9155 6439 2896 14429",
                                    "2016 1 Cluj -45118 -62678 -77879 -69453 -76563 -76386",
                                    "2016 1 Constanta -17323 56353 -85041 -23839 21463 -45898",
                                    "2016 1 Covasna 6530 4161 1803 -3048 838 83",
                                    "2016 1 Dambovita 9212 6163 6516 10510 6667 11489",
                                    "2016 1 Dolj 18771 63053 10138 10123 3327 22575",
                                    "2016 1 Galati -742 36974 -32790 -9192 -1929 26336",
                                    "2016 1 Giurgiu -3356 -3096 -8993 -1508 -10185 -9117",
                                    "2016 1 Gorj 307 312 1405 -1000 -1539 1396",
                                    "2016 1 Harghita -1342 -7700 -7440 -8599 -14045 -8804",
                                    "2016 1 Hunedoara 12158 12216 18614 17295 17497 15149",
                                    "2016 1 Ialomita 2864 -776 -1696 2043 -4370 -6830",
                                    "2016 1 Iasi 8966 1067 9042 -218 9777 15227",
                                    "2016 1 Ilfov -165924 -228653 -314884 -272665 -289252 -304885",
                                    "2016 1 Maramures 28209 21205 27247 17985 19220 25568",
                                    "2016 1 Mehedinti 765 5355 4595 795 2189 1177",
                                    "2016 1 Mures -7232 -18273 -5819 -20830 -16260 -6828",
                                    "2016 1 Neamt 3537 609 5460 2311 -744 3251",
                                    "2016 1 Olt 43434 49168 51761 60557 54276 55706",
                                    "2016 1 Prahova -46183 -50629 -34267 -84067 -73633 -89314",
                                    "2016 1 SatuMare 5940 -5209 -5321 -8219 -503 415",
                                    "2016 1 Salaj 23991 8619 9116 8321 12172 14424",
                                    "2016 1 Sibiu 61303 46856 62611 54693 41950 47843",
                                    "2016 1 Suceava -8251 -18367 -14134 -15854 -11949 -9116",
                                    "2016 1 Teleorman 3617 -591 -912 -1135 52 674",
                                    "2016 1 Timis 48730 83124 90617 58862 53632 66100",
                                    "2016 1 Tulcea -2187 -6407 -3798 24245 -15157 17693",
                                    "2016 1 Vaslui 3423 6635 2374 1615 -182 2226",
                                    "2016 1 Valcea 13239 10528 8789 8249 9626 15605",
                                    "2016 1 Vrancea 5889 2164 -5430 -5211 -3816 -2855",
                                    "2016 1 Bucuresti -739034 -916599 -986322 -897527 -924626 -847718",
                              };

            var items = GetItems<SoldFobCif>(rawData);

            return items;
        }
    }
}
