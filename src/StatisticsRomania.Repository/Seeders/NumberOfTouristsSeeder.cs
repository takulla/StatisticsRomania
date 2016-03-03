using System.Collections.Generic;
using StatisticsRomania.BusinessObjects;

namespace StatisticsRomania.Repository.Seeders
{
    internal class NumberOfTouristsSeeder : BaseSeeder
    {
        internal static List<NumberOfTourists> GetData()
        {
            var rawData = new List<string>()
                              {
                                  "Alba 8718 7455 6047 5723 6634 6835 9336 14848 15397 19913 23753 15548 12715",
                                  "Arad 19241 15721 13757 13625 13003 14886 15586 18689 19975 25910 26644 20188 17588",
                                  "Arges 13345 10778 11643 9523 9080 10385 13721 15370 17745 26528 28858 19551 16387",
                                  "Bacau 9197 7430 7130 6880 7176 7955 7832 9659 13093 13846 16422 12387 11173",
                                  "Bihor 26768 22673 18912 12621 15268 16453 20641 27871 34384 42307 50062 35147 32282",
                                  "BistritaNasaud 5813 4386 4177 3993 4142 4590 5176 8236 8377 10919 10795 8096 6399",
                                  "Botosani 3077 2962 2433 2273 1833 2325 2469 3109 3730 3167 3151 3832 4341",
                                  "Brasov 74162 68159 75766 78678 77000 61827 63631 76059 81892 95494 120754 95090 84156",
                                  "Braila 5028 4911 4804 3468 3687 4647 4712 6260 7273 8680 8657 7036 6847",
                                  "Buzau 7225 5758 4250 3808 4007 4947 4954 5959 6213 7386 7836 6812 5891",
                                  "CarasSeverin 9583 7837 7001 7300 7273 7657 10793 15952 19606 24130 27231 16665 13257",
                                  "Calarasi 1387 1104 1062 821 1141 1264 1332 1536 1432 2099 1958 1713 1683",
                                  "Cluj 34924 31159 21462 20736 24267 28654 34560 41400 43140 42601 43397 42689 43412",
                                  "Constanta 20651 14966 12077 10449 12260 14835 19676 45284 118562 308849 347708 86364 23161",
                                  "Covasna 10299 7913 5213 4273 4448 4864 5987 9014 9304 11511 19265 8258 7374",
                                  "Dambovita 8189 6418 6069 5024 4869 5594 5726 7693 8315 9808 9921 9121 7925",
                                  "Dolj 8163 8180 7419 6262 7664 7984 8196 8571 9388 9191 9316 9409 9367",
                                  "Galati 6023 5387 4214 3800 4662 5025 5544 5993 7225 6404 7316 7332 7903",
                                  "Giurgiu 1558 1870 1400 1391 1275 1768 2184 1991 2674 3188 2626 2341 1797",
                                  "Gorj 7996 5171 5083 4874 4997 5091 5719 6507 6287 10464 9510 7429 6021",
                                  "Harghita 9565 7357 7812 7716 8484 6455 8758 14591 13773 19721 22405 16835 11713",
                                  "Hunedoara 8715 9248 6494 6574 7743 9422 10849 14731 15413 19053 22277 14936 10563",
                                  "Ialomita 4348 2644 1915 2106 2058 2321 2338 3932 4985 6021 6774 4067 4037",
                                  "Iasi 23129 18468 13433 11825 13611 17245 17952 22457 23052 22541 20467 26342 27539",
                                  "Ilfov 11300 9027 9215 8593 8444 10097 10009 11973 12469 12548 10999 12318 11036",
                                  "Maramures 11554 9847 10243 7998 8391 8358 9771 13816 14593 18573 20025 15525 12790",
                                  "Mehedinti 4708 3157 2568 2634 3248 3501 4942 6709 7990 10204 13477 10368 7571",
                                  "Mures 36278 29147 25464 24041 27107 30696 31906 41916 43709 56337 67957 51867 47581",
                                  "Neamt 14097 8578 10668 7642 7682 8155 11447 15720 20130 24752 31422 21025 13076",
                                  "Olt 3491 3020 2214 2378 2136 3172 3141 3427 2811 2257 2350 2840 3231",
                                  "Prahova 34618 29935 31061 30599 30703 27962 30659 37985 37113 46483 56026 46272 43008",
                                  "SatuMare 8653 7808 7042 7240 7378 7270 7071 7891 8655 9296 9694 8640 7132",
                                  "Salaj 2943 2760 1938 1807 2380 2414 2245 3289 3149 4320 4714 3711 3473",
                                  "Sibiu 27518 26130 24394 16270 17321 19778 23330 35585 40074 63397 71199 51637 28309",
                                  "Suceava 19524 16523 21965 17959 18375 15765 20887 26756 28422 37559 43873 31143 24211",
                                  "Teleorman 1153 1023 662 739 774 775 824 1370 1432 1399 1318 1027 1322",
                                  "Timis 29968 26131 20098 17511 19644 24674 27527 31207 30949 32019 31468 35684 34957",
                                  "Tulcea 3237 2663 1605 1502 2008 2359 3284 7268 10543 10458 13257 9763 4738",
                                  "Vaslui 3156 2194 2218 2124 1794 2812 3214 3368 3180 4047 3921 3992 3605",
                                  "Valcea 16448 15533 15461 14356 13317 12659 20194 25687 26454 37759 43660 27271 22726",
                                  "Vrancea 3958 3945 3345 2274 2370 2500 3396 3260 3545 4093 3988 3820 4012",
                                  "Bucuresti 157606 137846 108723 98968 109511 145347 136609 166963 164254 156049 143682 164670 164824",
                              };

            var items = GetItems<NumberOfTourists>(rawData);

            return items;
        }
    }
}