﻿using StatisticsRomania.BusinessObjects;
using System.Collections.Generic;

namespace StatisticsRomania.Repository.Seeders
{
    internal class NumberOfEmployeesSeeder : BaseSeeder
    {
        internal static List<NumberOfEmployees> GetData()
        {
            var rawData = new List<string>
                              {
                                  // 2014, 2015
                                  "2014 10 Alba 81564 81472 81118 80896 80968 81207 81413 81680 81948 82269 82390 82520 82561 82620 82287",
                                  "2014 10 Arad 123546 123407 122871 126281 126310 126600 126922 127340 127759 128261 128451 128654 128717 128809 128289",
                                  "2014 10 Arges 136477 136325 135737 136460 136635 137089 137433 137881 138330 138868 139071 139288 139356 139455 138898",
                                  "2014 10 Bacau 104529 104412 103962 103808 103931 104266 104528 104868 105209 105617 105771 105936 105988 106063 105640",
                                  "2014 10 Bihor 156634 156461 155795 156946 156760 156893 157285 157795 158305 158917 159148 159396 159473 159585 158952",
                                  "2014 10 BistritaNasaud 60893 60825 60563 61713 61716 61847 62002 62205 62408 62651 62743 62841 62872 62916 62665",
                                  "2014 10 Botosani 51937 51878 51651 51288 51375 51568 51699 51870 52041 52247 52324 52407 52433 52471 52258",
                                  "2014 10 Brasov 166030 165844 165129 166870 166954 167381 167803 168351 168900 169559 169807 170073 170157 170278 169596",
                                  "2014 10 Braila 65759 65686 65402 64976 65037 65231 65395 65608 65822 66078 66175 66279 66311 66358 66093",
                                  "2014 10 Buzau 81124 81035 80688 80729 80817 81069 81271 81534 81798 82113 82232 82360 82400 82458 82131",
                                  "2014 10 CarasSeverin 52786 52727 52499 54275 54374 54584 54721 54900 55078 55292 55373 55460 55487 55526 55304",
                                  "2014 10 Calarasi 43161 43113 42928 42672 42708 42832 42940 43079 43219 43386 43449 43517 43538 43569 43395",
                                  "2014 10 Cluj 207874 207647 206768 215857 215742 216065 216602 217300 218001 218840 219156 219496 219602 219756 218887",
                                  "2014 10 Constanta 177622 177427 176672 174747 174699 175004 175440 176005 176573 177252 177509 177783 177870 177994 177291",
                                  "2014 10 Covasna 46169 46117 45916 46942 46949 47053 47173 47329 47485 47672 47742 47818 47842 47876 47682",
                                  "2014 10 Dambovita 73682 73599 73280 73692 73770 74001 74188 74431 74675 74967 75078 75196 75233 75286 74984",
                                  "2014 10 Dolj 122741 122605 122079 121970 122232 122742 123048 123445 123843 124321 124501 124694 124754 124842 124348",
                                  "2014 10 Galati 110360 110238 109765 109628 109756 110109 110384 110741 111100 111529 111691 111865 111919 111998 111553",
                                  "2014 10 Giurgiu 33017 32981 32840 33306 33306 33375 33458 33566 33675 33805 33854 33907 33923 33947 33812",
                                  "2014 10 Gorj 74501 74417 74093 72538 72607 72825 73010 73249 73490 73777 73886 74003 74039 74092 73794",
                                  "2014 10 Harghita 64981 64910 64633 64291 64256 64351 64512 64720 64930 65181 65275 65377 65409 65455 65195",
                                  "2014 10 Hunedoara 110633 110508 110025 110089 110189 110517 110799 111164 111531 111971 112136 112314 112370 112450 111995",
                                  "2014 10 Ialomita 44164 44115 43925 43278 43310 43431 43540 43682 43824 43995 44059 44128 44150 44181 44004",
                                  "2014 10 Iasi 148618 148451 147807 147449 147685 148225 148600 149086 149574 150158 150378 150615 150689 150796 150191",
                                  "2014 10 Ilfov 115670 115543 115051 119373 119122 119114 119414 119803 120193 120661 120837 121026 121086 121171 120687",
                                  "2014 10 Maramures 97683 97574 97154 99239 99197 99359 99610 99935 100262 100653 100800 100959 101008 101080 100675",
                                  "2014 10 Mehedinti 41705 41658 41476 42013 42020 42114 42221 42360 42500 42667 42730 42798 42819 42850 42676",
                                  "2014 10 Mures 126441 126300 125756 126362 126469 126835 127154 127568 127984 128482 128670 128871 128934 129025 128510",
                                  "2014 10 Neamt 78276 78189 77853 78329 78353 78537 78734 78991 79248 79555 79672 79796 79835 79892 79573",
                                  "2014 10 Olt 64458 64386 64106 64587 64707 64960 65124 65338 65552 65808 65905 66009 66041 66088 65823",
                                  "2014 10 Prahova 170325 170135 169398 169417 169475 169881 170310 170868 171428 172098 172351 172623 172708 172831 172136",
                                  "2014 10 SatuMare 77446 77360 77025 77097 77046 77153 77349 77603 77857 78163 78278 78401 78440 78496 78180",
                                  "2014 10 Salaj 45057 45007 44813 45653 45661 45762 45878 46028 46178 46358 46426 46499 46522 46555 46368",
                                  "2014 10 Sibiu 121778 121640 121106 120903 121055 121459 121770 122173 122577 123061 123244 123440 123501 123590 123089",
                                  "2014 10 Suceava 96356 96250 95841 97279 97269 97457 97700 98015 98331 98710 98853 99006 99054 99124 98731",
                                  "2014 10 Teleorman 53378 53319 53089 53201 53260 53429 53563 53737 53912 54121 54200 54285 54311 54350 54133",
                                  "2014 10 Timis 217672 217429 216489 221717 221767 222275 222837 223567 224300 225177 225508 225863 225975 226135 225227",
                                  "2014 10 Tulcea 42846 42799 42616 43618 43668 43807 43917 44058 44201 44371 44435 44504 44526 44557 44381",
                                  "2014 10 Vaslui 52237 52178 51952 51746 51866 52092 52224 52394 52566 52771 52848 52931 52957 52995 52782",
                                  "2014 10 Valcea 76164 76079 75750 74453 74474 74647 74835 75080 75325 75618 75729 75848 75885 75939 75635",
                                  "2014 10 Vrancea 53869 53809 53580 53521 53595 53778 53911 54085 54259 54467 54545 54630 54656 54694 54479",
                                  "2014 10 Bucuresti 898010 897006 893149 888291 888174 889882 892115 895026 897944 901438 902760 904171 904619 905258 901641",
                                  // 2016
"2016 1 Alba 84473 84995 85485 85702 85890 86158 86506 86670 86832 86971 87005 86683",
"2016 1 Arad 129258 130092 130877 131211 131499 131909 132443 132695 132943 133156 133209 132715",
"2016 1 Arges 142007 142888 143716 144078 144392 144838 145419 145693 145964 146195 146252 145715",
"2016 1 Bacau 106834 107528 108181 108453 108688 109023 109459 109665 109868 110042 110084 109681",
"2016 1 Bihor 163041 164197 165292 165706 166063 166572 167235 167548 167856 168120 168185 167573",
"2016 1 BistritaNasaud 66321 66752 67158 67328 67475 67685 67957 68086 68212 68321 68347 68096",
"2016 1 Botosani 53155 53520 53864 54001 54120 54289 54509 54613 54716 54803 54825 54622",
"2016 1 Brasov 171280 172255 173166 173604 173983 174523 175226 175557 175884 176163 176232 175583",
"2016 1 Braila 66105 66514 66898 67067 67213 67421 67691 67819 67945 68053 68079 67829",
"2016 1 Buzau 82476 82958 83409 83618 83798 84055 84390 84548 84704 84837 84870 84561",
"2016 1 CarasSeverin 54974 55279 55563 55703 55824 55997 56221 56327 56432 56521 56543 56336",
"2016 1 Calarasi 44108 44332 44539 44651 44748 44886 45066 45151 45235 45306 45324 45158",
"2016 1 Cluj 223562 225185 226723 227288 227776 228471 229376 229802 230223 230584 230672 229837",
"2016 1 Constanta 176838 177851 178798 179244 179630 180180 180896 181233 181566 181851 181921 181260",
"2016 1 Covasna 47783 48056 48310 48434 48541 48683 48891 48984 49076 49155 49174 48991",
"2016 1 Dambovita 75655 76128 76571 76765 76933 77172 77484 77630 77775 77899 77930 77642",
"2016 1 Dolj 125620 126454 127242 127560 127834 128225 128734 128974 129211 129414 129464 128994",
"2016 1 Galati 112694 113314 113891 114177 114425 114777 115236 115452 115665 115848 115893 115469",
"2016 1 Giurgiu 33490 33739 33975 34060 34133 34237 34373 34437 34500 34554 34568 34442",
"2016 1 Gorj 71663 72058 72426 72610 72769 72995 73290 73429 73566 73684 73713 73440",
"2016 1 Harghita 64678 65116 65530 65694 65836 66037 66300 66423 66545 66650 66676 66433",
"2016 1 Hunedoara 113177 113828 114435 114728 114981 112827 113286 113502 113715 113898 113943 113519",
"2016 1 Ialomita 43594 43851 44092 44203 44300 44437 44615 44699 44782 44853 44870 44706",
"2016 1 Iasi 152796 153672 154490 154882 155221 155704 156332 156629 156921 157171 157233 156652",
"2016 1 Ilfov 127510 129117 130675 130999 131279 131678 132198 132443 132684 132891 132942 132463",
"2016 1 Maramures 101809 102470 103093 103353 103578 104444 104864 105062 105258 105425 105466 105078",
"2016 1 Mehedinti 42343 42553 42747 42856 42951 43086 43261 43344 43425 43495 43512 43350",
"2016 1 Mures 128697 129414 130082 130410 130694 131099 131626 131874 132119 132329 132381 131894",
"2016 1 Neamt 80833 81359 81854 82060 82239 82492 82823 82979 83132 83264 83296 82991",
"2016 1 Olt 65848 66240 66606 66775 66921 67129 67400 67528 67654 67762 67788 67538",
"2016 1 Prahova 172558 173620 174617 175060 175443 175988 176697 177032 177362 177645 177714 177059",
"2016 1 SatuMare 78457 78960 79434 79636 79810 80058 80382 80534 80684 80813 80845 80546",
"2016 1 Salaj 46069 46359 46632 46749 46851 46996 47185 47274 47362 47437 47455 47281",
"2016 1 Sibiu 125624 126408 127143 127468 127750 128151 128674 128920 129163 129371 129422 128940",
"2016 1 Suceava 100283 100955 101588 101841 102061 102373 102779 102971 103160 103322 103361 102986",
"2016 1 Teleorman 53353 53659 53945 54081 54198 54365 54583 54686 54787 54874 54895 54694",
"2016 1 Timis 231499 233086 234584 235178 235692 236424 237377 237826 238269 238648 238742 237862",
"2016 1 Tulcea 44045 44276 44490 44602 44698 44835 45014 45098 45181 45252 45270 45105",
"2016 1 Vaslui 53341 53653 53944 54081 54199 54367 54586 54689 54791 54878 54900 54698",
"2016 1 Valcea 75460 75943 76398 76591 76758 76995 77304 77450 77593 77717 77747 77461",
"2016 1 Vrancea 55907 56243 56558 56699 56821 56995 57221 57328 57433 57523 57545 57336",
"2016 1 Bucuresti 911434 917872 923968 926294 928299 931171 934900 936656 938391 939876 940240 936800",
// 2017
"2017 1 Alba 88584 88926 89575 89632 89957 90072 90191",
"2017 1 Arad 131863 132286 133165 133251 133735 133906 134084",
"2017 1 Arges 149911 150449 151502 151598 152145 152338 152538",
"2017 1 Bacau 108473 108765 109427 109497 109890 110029 110174",
"2017 1 Bihor 169822 170435 171625 171733 172347 172563 172788",
"2017 1 BistritaNasaud 68276 68537 69032 69076 69326 69414 69505",
"2017 1 Botosani 54801 54963 55314 55350 55551 55623 55697",
"2017 1 Brasov 179157 179815 181089 181205 181860 182091 182331",
"2017 1 Braila 67774 67958 68375 68419 68666 68753 68843",
"2017 1 Buzau 82316 82538 83039 83092 83389 83494 83603",
"2017 1 CarasSeverin 55740 55922 56295 56331 56534 56605 56680",
"2017 1 Calarasi 43920 44116 44461 44490 44649 44705 44763",
"2017 1 Cluj 235844 236707 238369 238519 239367 239667 239979",
"2017 1 Constanta 177539 178055 179173 179286 179925 180150 180385",
"2017 1 Covasna 49734 49864 50167 50199 50383 50448 50515",
"2017 1 Dambovita 77586 77837 78356 78406 78690 78790 78894",
"2017 1 Dolj 127458 127871 128715 128796 129255 129416 129585",
"2017 1 Galati 113837 114264 115078 115151 115563 115708 115859",
"2017 1 Giurgiu 34465 34596 34844 34866 34990 35034 35079",
"2017 1 Gorj 71088 71300 71756 71802 72062 72154 72250",
"2017 1 Harghita 66539 66665 67017 67059 67299 67384 67472",
"2017 1 Hunedoara 110063 110363 111045 111116 111521 111664 111813",
"2017 1 Ialomita 44387 44533 44830 44859 45020 45077 45136",
"2017 1 Iasi 159195 159788 160929 161032 161615 161821 162035",
"2017 1 Ilfov 141609 142518 143905 143994 144502 144681 144868",
"2017 1 Maramures 106153 106472 107155 107224 107611 105176 105314",
"2017 1 Mehedinti 43370 43498 43776 43804 43964 44021 44080",
"2017 1 Mures 131494 131905 132767 132852 133331 133500 133676",
"2017 1 Neamt 82362 82630 83180 83233 83532 83638 83748",
"2017 1 Olt 68135 68339 68779 68823 69072 69160 69252",
"2017 1 Prahova 175591 176150 177312 177426 178068 178294 178530",
"2017 1 SatuMare 80028 80271 80789 80841 81134 81237 81345",
"2017 1 Salaj 48050 48210 48535 48566 48741 48803 48867",
"2017 1 Sibiu 131165 131635 132561 132647 133132 133303 133481",
"2017 1 Suceava 104445 104779 105468 105534 105911 106043 106182",
"2017 1 Teleorman 54627 54795 55150 55185 55384 55454 55526",
"2017 1 Timis 241057 241774 243322 243478 244360 244671 244995",
"2017 1 Tulcea 45431 45559 45841 45870 46034 46092 46152",
"2017 1 Vaslui 53849 54045 54426 54460 54657 54726 54798",
"2017 1 Valcea 77333 77583 78097 78147 78428 78527 78631",
"2017 1 Vrancea 58445 58590 58934 58971 59182 59257 59334",
"2017 1 Bucuresti 974351 977799 984586 985215 988762 990013 991320",
                              };

            var items = GetItems<NumberOfEmployees>(rawData);

            return items;
        }
    }
}