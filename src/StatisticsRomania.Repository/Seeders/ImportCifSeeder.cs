﻿using System.Collections.Generic;
using StatisticsRomania.BusinessObjects;

namespace StatisticsRomania.Repository.Seeders
{
    internal class ImportCifSeeder : BaseSeeder
    {
        internal static List<ImportCif> GetData()
        {
            var rawData = new List<string>()
                              {
                                  "Alba 48212 47661 45107 35770 48939 58265 46105 54109 52523 53906 44857 51506 53319 51870",
                                  "Arad 230502 213119 177039 193957 209189 246214 226681 223387 239951 243737 198115 247752 249487 236653",
                                  "Arges 365805 323459 272226 314063 323759 354843 333630 322237 348280 354540 217728 379806 360925 332162",
                                  "Bacau 42854 39482 29312 32826 49452 55274 49899 48669 57345 54515 43025 55604 55306 51640",
                                  "Bihor 190601 179009 135398 153518 158008 167586 161387 156331 159592 164596 138481 177845 182710 175878",
                                  "BistritaNasaud 48727 47728 38951 43272 42031 48564 42501 49885 57196 55235 43152 61711 63774 58323",
                                  "Botosani 18923 23098 19131 18297 17885 22708 23077 23484 23094 23893 12919 22288 22195 23102",
                                  "Brasov 229691 217409 195364 181565 212454 228880 202867 196702 224461 238286 200910 237832 239752 222525",
                                  "Braila 18015 15449 16678 15044 10845 13186 14217 14583 20312 14953 11070 13863 15800 13523",
                                  "Buzau 41460 43900 29129 36110 27652 51767 41100 29278 49352 59089 45892 38162 51573 33632",
                                  "CarasSeverin 18652 16607 12676 16384 16526 19049 18093 16469 19231 20040 17390 17832 20053 19956",
                                  "Calarasi 22067 21875 15915 16386 22628 28620 30247 22592 29102 33116 20383 27160 17724 18965",
                                  "Cluj 184009 172960 155099 124825 139353 170654 166661 168868 171154 189289 160072 191677 203200 185672",
                                  "Constanta 308698 236836 237810 162012 190069 247146 248183 253625 211201 346392 240906 239083 166798 107983",
                                  "Covasna 27279 26166 21076 19994 22092 25025 22547 22099 23759 22052 21024 25671 25654 24191",
                                  "Dambovita 41979 36813 26673 31579 32888 41938 41525 42380 50926 51114 48269 43677 49879 44400",
                                  "Dolj 81666 66199 62881 73677 88211 85921 68814 75097 84647 86394 57277 93541 82790 75414",
                                  "Galati 78819 87217 66092 69182 69219 69167 66807 82007 80261 88118 90791 76625 83273 81579",
                                  "Giurgiu 12606 10010 7508 5931 7666 10737 7551 9073 15361 9849 6756 9906 9408 10513",
                                  "Gorj 6103 3602 4616 4540 3828 4067 4104 3664 3925 3884 4206 4237 3467 4888",
                                  "Harghita 37859 28059 23854 22840 24247 33760 29963 30528 35512 33693 28790 37283 35101 35521",
                                  "Hunedoara 48368 47998 46146 45937 51759 62121 50153 43745 46033 49229 35159 50924 52044 50894",
                                  "Ialomita 12181 10048 7619 7529 9543 11663 12015 11635 16264 14891 15749 14847 12768 14554",
                                  "Iasi 55714 55075 43183 42617 51014 64949 58497 57238 69039 65536 56737 68687 71013 65270",
                                  "Ilfov 389247 373346 350331 302338 348087 414947 385153 375758 423116 432500 374800 440367 450813 447577",
                                  "Maramures 71409 66193 52631 52572 59194 66273 63266 60949 71833 72691 58279 77103 75971 81107",
                                  "Mehedinti 7544 6375 4868 6573 7393 7996 7227 8447 9236 8547 5023 9489 7899 8512",
                                  "Mures 89008 89482 95169 81692 78679 102635 85069 81399 96755 109811 77200 96210 114759 95002",
                                  "Neamt 26781 24098 24437 19543 26407 37145 30402 28074 38585 30898 27599 27700 32724 29969",
                                  "Olt 62789 55542 38984 47752 48729 63564 51846 49235 58965 59469 47700 52839 48248 50835",
                                  "Prahova 261010 247410 247664 171903 235630 270813 164997 229292 242755 240134 229933 244586 252755 236816",
                                  "SatuMare 76828 72828 60678 60295 66352 76161 73751 68122 73629 82437 80911 87302 87722 79325",
                                  "Salaj 27934 22869 22368 30371 24434 25517 21587 21920 23448 29032 16825 23098 26365 22292",
                                  "Sibiu 179068 162919 137582 148317 152837 171549 158371 148475 162940 167612 136313 163921 191970 168187",
                                  "Suceava 37114 31266 30969 31556 36086 41739 40508 39333 45621 48364 40357 47690 46743 43353",
                                  "Teleorman 11394 11505 9800 10159 9820 11774 13223 26058 17652 16443 11810 15035 13218 10980",
                                  "Timis 386957 354973 304349 267787 355943 395350 369145 363032 393650 412454 331709 402566 421528 389108",
                                  "Tulcea 21883 23123 19733 21415 24651 32787 25028 34819 21193 25020 15298 21541 17381 19497",
                                  "Vaslui 14326 10589 9592 9314 10463 10932 13264 14238 15086 13259 7601 11622 11533 10800",
                                  "Valcea 23490 20412 16957 15263 21580 25535 23248 19942 23490 25243 21107 25112 22570 22209",
                                  "Vrancea 20157 15635 14718 15478 17641 20563 24617 20246 25052 20520 13982 22156 23081 18351",
                                  "Bucuresti 1586809 1517911 1400884 1373183 1405875 1686957 1504640 1462624 1600658 1587703 1492804 1678741 1873301 1826624",
                              };

            var items = GetItems<ImportCif>(rawData);

            return items;
        }
    }
}