﻿using PropertyChanged;
using StatisticsRomania.Lib;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace StatisticsRomania.ViewModels
{
    [ImplementPropertyChanged]
    public class CountyStandingsViewModel : BaseViewModel
    {
        private readonly ObservableCollection<StandingItem> _standings;

        public List<string> YearList { get; set; }
        public List<string> YearFractionList { get; set; }

        public ObservableCollection<StandingItem> Standings
        {
            get { return _standings; }
        }

        public string ValueColumnCaption { get; set; }

        public bool HasData { get; set; }
        public bool DoesNotHaveData { get; set; }

        public int LastAvailableYear { get; set; }
        public int LastAvailableYearFraction { get; set; }

        public CountyStandingsViewModel()
        {
            _standings = new ObservableCollection<StandingItem>();
        }

        public async Task GetStandings(string chapter, int year, int yearFraction)
        {
            IsLoading = true;

            Standings.Clear();

            if (!ChapterList.ContainsKey(chapter))
                return;

            ValueColumnCaption = UnitOfMeasureList[chapter];

            var data = await CountyStandingsProvider.GetData(ChapterList[chapter], year, yearFraction);

            foreach (var item in data)
            {
                Standings.Add(item);
            }

            HasData = data.Count > 0;
            DoesNotHaveData = !HasData;

            if (DoesNotHaveData)
            {
                var lastData = (await CountyDetailsProvider.GetData(1, ChapterList[chapter]))
                    .OrderByDescending(x => x.Year)
                    .ThenByDescending(x => x.YearFraction)
                    .FirstOrDefault();
                LastAvailableYear = lastData.Year;
                LastAvailableYearFraction = lastData.YearFraction;
            }

            IsLoading = false;
        }

        internal void GetYears()
        {
            YearList = Enumerable.Range(2014, 3).Select(x => x.ToString()).ToList();
        }

        internal void GetYearFractions()
        {
            YearFractionList = Enumerable.Range(1, 12).Select(x => x.ToString()).ToList();
        }
    }
}