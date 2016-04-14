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
                                  "Alba 48212 47661 45107 35795 48952 58373 46115 54158 52503 53947 44868 51507 53055",
                                  "Arad 230502 213119 177039 193985 209002 246317 226626 223353 239938 243226 197960 246593 246772",
                                  "Arges 365805 323459 272226 314095 323764 354939 333657 322306 348439 354678 217891 379900 360851",
                                  "Bacau 42854 39482 29312 32845 49457 55373 49914 48723 57403 54457 42773 55671 55380",
                                  "Bihor 190601 179009 135398 153613 158047 167921 161439 156487 159752 164785 138511 177482 182235",
                                  "BistritaNasaud 48727 47728 38951 43228 41785 47760 41039 48234 55142 52722 42505 61548 63848",
                                  "Botosani 18923 23098 19131 18307 17888 22753 23082 23503 23087 23933 12936 22282 22053",
                                  "Brasov 229691 217409 195364 181611 212484 222495 202859 196756 224666 235654 200801 237384 240252",
                                  "Braila 18015 15449 16678 15058 10849 13249 14232 14578 20357 15007 11103 13911 16179",
                                  "Buzau 41460 43900 29129 36128 27655 51834 41109 29311 49392 59135 45940 38446 51477",
                                  "CarasSeverin 18652 16607 12676 16394 16528 19049 18111 16499 19264 20081 17502 17916 20289",
                                  "Calarasi 22067 21875 15915 16393 22630 28664 30268 22605 29126 33157 20411 27184 17816",
                                  "Cluj 184009 172960 155099 124822 139283 170444 166443 168370 171035 189405 160334 191469 204274",
                                  "Constanta 308698 236836 237810 162056 190085 247343 248210 253730 211353 346590 241024 239196 166827",
                                  "Covasna 27279 26166 21076 20005 22095 25072 22555 22125 23779 22081 21043 25692 25745",
                                  "Dambovita 41979 36813 26673 31593 32891 41999 41538 42457 50959 51152 48301 43706 50001",
                                  "Dolj 81666 66199 62881 73699 88219 86014 68799 75136 84694 86447 57308 93604 82884",
                                  "Galati 78819 87217 66092 69206 69226 69268 66836 82094 80359 88302 91164 76731 83598",
                                  "Giurgiu 12606 10010 7508 5940 7669 10087 7515 9064 15371 9719 6781 9905 9511",
                                  "Gorj 6103 3602 4616 4548 3829 4093 4109 3679 3944 3931 4227 4256 3375",
                                  "Harghita 37859 28059 23854 22869 24248 33889 29988 30588 35598 33799 28841 37399 35467",
                                  "Hunedoara 48368 47998 46146 45836 51789 62291 50154 43800 46019 48898 35251 50725 52039",
                                  "Ialomita 12181 10048 7619 7541 9545 11672 12022 11665 16300 14950 15677 14742 12973",
                                  "Iasi 55714 55075 43183 42625 51023 65074 58524 57332 69102 65660 56625 68823 71088",
                                  "Ilfov 389247 373346 350331 302238 348118 414891 385239 375903 423187 432725 375309 440180 450725",
                                  "Maramures 71409 66193 52631 52588 59221 66318 63322 60999 71983 72667 58121 77079 74973",
                                  "Mehedinti 7544 6375 4868 6581 7394 8012 7229 8462 9248 8562 5032 9493 7841",
                                  "Mures 89008 89482 95169 79553 78656 102697 85048 81426 96807 109886 77251 96173 114954",
                                  "Neamt 26781 24098 24437 19569 26411 37214 30413 28111 38473 30932 27537 27678 31976",
                                  "Olt 62789 55542 38984 47750 48661 63591 51851 49260 58940 59503 47722 52864 48379",
                                  "Prahova 261010 247410 247664 171935 235636 270915 165247 228623 242584 240303 229983 244668 252861",
                                  "SatuMare 76828 72828 60678 60348 66363 76318 73775 67917 73421 82677 80376 87485 87891",
                                  "Salaj 27934 22869 22368 30389 24437 25570 21597 21960 23478 28996 16852 23248 26445",
                                  "Sibiu 179068 162919 137582 148345 152843 171506 158407 148495 163004 167440 136310 165020 192725",
                                  "Suceava 37114 31266 30969 31600 36096 41900 40522 39418 45727 48426 40333 47927 47130",
                                  "Teleorman 11394 11505 9800 10171 9823 11822 13230 26073 17694 16484 11830 15083 13234",
                                  "Timis 386957 354973 304349 267932 355963 395581 369408 363280 393821 412640 332255 402723 422066",
                                  "Tulcea 21883 23123 19733 21441 24667 33110 25046 34860 21163 25060 15246 21594 16562",
                                  "Vaslui 14326 10589 9592 9320 10462 10959 13267 14259 15105 13278 7556 11554 11601",
                                  "Valcea 23490 20412 16957 15278 21583 25575 23254 19972 23527 25258 20924 25122 22559",
                                  "Vrancea 20157 15635 14718 15489 17643 20594 24624 20268 25098 20568 14007 22188 23211",
                                  "Bucuresti 1586809 1517911 1400884 1374493 1405934 1691315 1505074 1463627 1601179 1591241 1492284 1678209 1874075",
                              };

            var items = GetItems<ImportCif>(rawData);

            return items;
        }
    }
}
