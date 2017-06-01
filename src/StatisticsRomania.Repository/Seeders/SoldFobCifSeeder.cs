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
"2016 1 Alba 34343 18176 36288 25577 26202 48623 40873 42703 60213 44382 54401 13819",
"2016 1 Arad 45529 25643 33357 46048 21533 29900 30177 13141 36982 33613 57576 5907",
"2016 1 Arges 115479 119072 152809 148067 130212 183483 102450 54842 123754 113989 148775 110113",
"2016 1 Bacau -1933 -14776 -24933 -17725 -19439 -17046 -13692 -23664 -19461 -21653 -12908 -17756",
"2016 1 Bihor 7983 -1711 1073 -12937 -14531 -7982 -14034 1999 9088 -8257 -59 5180",
"2016 1 BistritaNasaud 5023 5860 6904 19583 4882 9917 18476 9731 7263 8800 15679 4492",
"2016 1 Botosani 10362 9831 4984 2988 1123 4529 6036 3302 6646 465 1686 3694",
"2016 1 Brasov 27803 24278 15103 20119 11960 16119 -951 6351 32350 -3207 18063 -34437",
"2016 1 Braila 2081 -339 -4944 8358 -5385 -5616 -4475 13172 -3964 5523 -2148 16210",
"2016 1 Buzau 4287 7686 6243 7631 6494 3273 -5622 29170 33867 32625 25263 20157",
"2016 1 CarasSeverin 11981 11056 10176 11262 7192 7004 6005 6916 7451 7901 7730 3075",
"2016 1 Calarasi 11452 16429 9195 6300 2322 14512 39860 8508 16348 1310 17005 4552",
"2016 1 Cluj -44990 -62921 -77600 -69286 -75092 -74146 -64918 -74745 -73293 -74504 -61147 -67508",
"2016 1 Constanta -17678 55453 -86315 -24214 14927 -46146 -83947 -45671 -40960 47553 -7652 -73031",
"2016 1 Covasna 6569 4232 1892 -2913 1060 -525 3823 3392 -2183 -3677 344 -6713",
"2016 1 Dambovita 9233 6192 6580 10629 6861 11417 2280 3716 3699 1401 6510 618",
"2016 1 Dolj 18979 63212 9631 9873 3490 21840 24024 -820 32320 -2081 8915 397",
"2016 1 Galati -692 37073 -32504 -8773 -1569 25572 29632 -9577 -10884 -15603 -2578 -17191",
"2016 1 Giurgiu -3428 -3070 -9105 -1576 -9890 -9421 -7460 -5764 -2637 -6151 -5543 -8501",
"2016 1 Gorj 342 329 1452 -931 -1432 1149 904 1506 870 207 75 -175",
"2016 1 Harghita -1112 -7611 -7201 -8199 -13513 -9236 -6588 -6799 -6228 -8698 -10711 -6921",
"2016 1 Hunedoara +12374 +12421 +18489 +17576 +17890 +14301 +13032 +6450 +26437 +10392 +14572 +633",
"2016 1 Ialomita 2881 -689 -1553 2208 -3842 -6579 -1306 -275 -1726 2966 3517 -432",
"2016 1 Iasi 9373 1010 9370 -204 9676 15330 3691 -9162 1788 -8866 3227 -6820",
"2016 1 Ilfov -165563 -227923 -314229 -271977 -290548 -304250 -233253 -277678 -286273 -320739 -322585 -264898",
"2016 1 Maramures 28977 21286 27656 17781 18756 24827 29505 32859 27358 24595 34028 14216",
"2016 1 Mehedinti 781 5384 4634 615 2396 1140 4668 825 1681 2705 1953 -1006",
"2016 1 Mures -7198 -18344 -5728 -20711 -15792 -7564 -19359 -18206 -18363 -35541 -38856 -48820",
"2016 1 Neamt 3581 683 5403 2097 -179 5176 2817 -1401 3330 -518 1415 -3478",
"2016 1 Olt 43373 49202 51696 60300 54567 55392 45151 42053 45374 55192 61007 39287",
"2016 1 Prahova -45889 -50119 -33748 -83661 -76490 -85405 -88054 -87290 -84116 -90029 -76820 -78983",
"2016 1 SatuMare 6097 -5378 -5844 -8477 -915 -703 -4257 -8446 -6372 -9331 -11 -3413",
"2016 1 Salaj 24475 8669 9193 8416 12397 14206 9874 10394 15389 17448 16805 14157",
"2016 1 Sibiu 63198 47816 59814 57241 42945 50094 52201 45106 58419 53697 61255 32489",
"2016 1 Suceava -8287 -18229 -14107 -16146 -11742 -9809 -10330 -13077 -5070 -13003 -4882 -13285",
"2016 1 Teleorman 3635 -578 -822 -936 54 75 63 -5603 -3619 -2669 -1427 -2961",
"2016 1 Timis 52347 88095 92104 57072 52036 85637 75156 73657 87687 61383 91791 15614",
"2016 1 Tulcea -2166 -6387 -3814 25620 -15139 17220 24088 -393 24036 2038 1129 12263",
"2016 1 Vaslui 3406 6651 2437 1642 -136 2097 5183 4110 2682 3188 4234 1549",
"2016 1 Valcea 12793 10564 8658 8118 9742 15247 9694 10551 8321 9604 12493 4088",
"2016 1 Vrancea 5929 2216 -5264 -5364 -5707 -2806 2761 1670 4460 -4954 3011 2769",
"2016 1 Bucuresti -726829 -914623 -986101 -899768 -924641 -851306 -728597 -947438 -953435 -948700 -1059728 -923520",
// 2017
"2017 1 Alba 94941",
"2017 1 Arad 42774",
"2017 1 Arges 148517",
"2017 1 Bacau -3946",
"2017 1 Bihor -3897",
"2017 1 BistritaNasaud 13508",
"2017 1 Botosani 4004",
"2017 1 Brasov 35790",
"2017 1 Braila -1415",
"2017 1 Buzau 25864",
"2017 1 CarasSeverin 7640",
"2017 1 Calarasi 7962",
"2017 1 Cluj -58359",
"2017 1 Constanta -83624",
"2017 1 Covasna 6552",
"2017 1 Dambovita 6856",
"2017 1 Dolj 7535",
"2017 1 Galati 27951",
"2017 1 Giurgiu -7346",
"2017 1 Gorj -215",
"2017 1 Harghita -2365",
"2017 1 Hunedoara 15697",
"2017 1 Ialomita -416",
"2017 1 Iasi 4096",
"2017 1 Ilfov -254016",
"2017 1 Maramures 30479",
"2017 1 Mehedinti 1794",
"2017 1 Mures -48224",
"2017 1 Neamt 5892",
"2017 1 Olt 62584",
"2017 1 Prahova -101171",
"2017 1 SatuMare 1891",
"2017 1 Salaj 19742",
"2017 1 Sibiu 52993",
"2017 1 Suceava -4135",
"2017 1 Teleorman 4476",
"2017 1 Timis 75966",
"2017 1 Tulcea -3823",
"2017 1 Vaslui 7760",
"2017 1 Valcea 11214",
"2017 1 Vrancea -884",
"2017 1 Bucuresti -810346",
                              };

            var items = GetItems<SoldFobCif>(rawData);

            return items;
        }
    }
}
