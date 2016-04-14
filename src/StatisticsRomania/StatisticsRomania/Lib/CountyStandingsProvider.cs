﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatisticsRomania.BusinessObjects;
using StatisticsRomania.Repository;
using StatisticsRomania.ViewModels;

namespace StatisticsRomania.Lib
{
    public static class CountyStandingsProvider
    {
        public static async Task<List<StandingItem>> GetData(Type chapter, int year, int yearFraction)
        {
            if (chapter == typeof(ExportFob))
            {
                return await GetData<ExportFob>(year, yearFraction);
            }

            if (chapter == typeof(ImportCif))
            {
                return await GetData<ImportCif>(year, yearFraction);
            }

            if (chapter == typeof(SoldFobCif))
            {
                return await GetData<SoldFobCif>(year, yearFraction);
            }

            if (chapter == typeof(AverageGrossSalary))
            {
                return await GetData<AverageGrossSalary>(year, yearFraction);
            }
            
            if (chapter == typeof(AverageNetSalary))
            {
                return await GetData<AverageNetSalary>(year, yearFraction);
            }

            if (chapter == typeof(NumberOfTourists))
            {
                return await GetData<NumberOfTourists>(year, yearFraction);
            }

            if (chapter == typeof(NumberOfNights))
            {
                return await GetData<NumberOfNights>(year, yearFraction);
            }

            if (chapter == typeof(NumberOfEmployees))
            {
                return await GetData<NumberOfEmployees>(year, yearFraction);
            }

            if (chapter == typeof(Unemployed))
            {
                return await GetData<Unemployed>(year, yearFraction, true);
            }

            return null;
        }

        private static async Task<List<StandingItem>> GetData<T>(int year, int yearFraction, bool isAscending = false)
            where T : Data, new()
        {
            var repo = new Repository<T>(App.AsyncDb);

            var rawData = (await repo.GetAll(x => x.Year == year && x.YearFraction == yearFraction));

            var orderedRawData = isAscending ? rawData.OrderBy(x => x.Value) : rawData.OrderByDescending(x => x.Value);

            var data = await ProcessRawData(orderedRawData, repo);

            return data;
        }

        private static async Task<List<StandingItem>> ProcessRawData<T>(IEnumerable<Data> rawData, Repository<T> repo)
            where T : Data, new()
        {
            var data = new List<StandingItem>();
            var index = 1;

            foreach (var item in rawData)
            {
                await repo.GetChild((T) item, x => x.County);

                var standingItem = new StandingItem() {Position = index++, County = item.County.Name, Value = item.Value};
                data.Add(standingItem);
            }

            return data;
        }
    }
}