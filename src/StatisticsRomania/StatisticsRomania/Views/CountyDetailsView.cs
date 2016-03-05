﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Utils;
using OxyPlot;
using OxyPlot.Axes;
using StatisticsRomania.Controls;
using StatisticsRomania.ViewModels;
using Xamarin.Forms;
using DevExpress.Mobile.DataGrid;
using OxyPlot.Xamarin.Forms;
using OxyPlot.Series;

namespace StatisticsRomania.Views
{
    public class CountyDetailsView : ContentPage
    {
        private CountyDetailsViewModel _viewModel;
        private PickerWithNoSpellCheck _pickerChapters;
        private PickerWithNoSpellCheck _pickerCounties;
        private PickerWithNoSpellCheck _pickerCounties2;

        private GridControl degChapterData;
        private PlotView plotView;

        private StackLayout dataControls;

        public CountyDetailsView()
        {
            Title = "Statistici judetene";

            Init();
        }

        private async Task Init()
        {
            _viewModel = new CountyDetailsViewModel();
            await _viewModel.GetCounties();
            _viewModel.GetChapters();

            var lblCounty = new Label
            {
                VerticalOptions = LayoutOptions.Center,
                Text = "Judet:"
            };

            _pickerCounties = new PickerWithNoSpellCheck()
            {
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            foreach (var county in _viewModel.CountyList)
            {
                _pickerCounties.Items.Add(county.Key);
            }
            _pickerCounties.SelectedIndexChanged += pickerCounties_SelectedIndexChanged;

            var lblCompare = new Label
            {
                VerticalOptions = LayoutOptions.Center,
                Text = "compara cu"
            };
            _pickerCounties2 = new PickerWithNoSpellCheck()
            {
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            _pickerCounties2.Items.Add("──────");
            foreach (var county in _viewModel.CountyList)
            {
                _pickerCounties2.Items.Add(county.Key);
            }
            _pickerCounties2.SelectedIndexChanged += _pickerCounties2_SelectedIndexChanged;

            var lblChapter = new Label
            {
                VerticalOptions = LayoutOptions.Center,
                Text = "Indicator:"
            };

            _pickerChapters = new PickerWithNoSpellCheck()
            {
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            foreach (var chapter in _viewModel.ChapterList)
            {
                _pickerChapters.Items.Add(chapter.Key);
            }
            _pickerChapters.SelectedIndexChanged += pickerChapters_SelectedIndexChanged;

            await LoadData();

            degChapterData = new GridControl();
            degChapterData.IsReadOnly = true;
            degChapterData.HorizontalOptions = LayoutOptions.FillAndExpand;
            degChapterData.VerticalOptions = LayoutOptions.FillAndExpand;
            degChapterData.Columns.Add(new TextColumn() { Caption = "An", FieldName = "Year", IsReadOnly = true, AllowSort = DefaultBoolean.False});
            degChapterData.Columns.Add(new TextColumn() { Caption = "Luna", FieldName = "YearFraction", IsReadOnly = true, AllowSort = DefaultBoolean.False });
            var valueColumn = new TextColumn()
                                  {
                                      FieldName = "Value",
                                      IsReadOnly = true,
                                      AllowSort = DefaultBoolean.False
                                  };
            valueColumn.SetBinding(TextColumn.CaptionProperty, new Binding("ValueColumnCaption", source: _viewModel));
            degChapterData.Columns.Add(valueColumn);
            var valueColumn2 = new TextColumn()
            {
                FieldName = "Value2",
                IsReadOnly = true,
                AllowSort = DefaultBoolean.False
            };
            valueColumn2.SetBinding(TextColumn.CaptionProperty, new Binding("Value2ColumnCaption", source: _viewModel));
            valueColumn2.SetBinding(TextColumn.IsVisibleProperty, new Binding("Value2ColumnVisibility", source: _viewModel));
            degChapterData.Columns.Add(valueColumn2);
            degChapterData.ItemsSource = _viewModel.ChapterDataReversed;
            degChapterData.RowTap += degChapterData_RowTap;

            plotView = new PlotView();
            plotView.HorizontalOptions = LayoutOptions.FillAndExpand;
            plotView.VerticalOptions = LayoutOptions.FillAndExpand;
            plotView.Model = new PlotModel();
            var series = new LineSeries();
            series.ItemsSource = _viewModel.ChapterData;
            plotView.Model.Series.Add(series);
            plotView.Model.Title = "Evolutie indicator";
            plotView.BackgroundColor = Color.FromRgb(51, 51, 51);

            dataControls = new StackLayout()
                               {
                                   Orientation = StackOrientation.Vertical,
                                   HorizontalOptions = LayoutOptions.FillAndExpand,
                                   VerticalOptions = LayoutOptions.FillAndExpand,
                                   Spacing = 0,
                                   Children = {degChapterData, plotView}
                               };

            this.Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Padding = new Thickness(
                    left: 0,
                    right: 0,
                    bottom: 0,
                    top: Device.OnPlatform(iOS: 20, Android: 5, WinPhone: 0)),
                Children = { 
                    new StackLayout()
                    {
                        HorizontalOptions = LayoutOptions.FillAndExpand,
                        Orientation = StackOrientation.Horizontal,
                        Padding = new Thickness(0, 2),
                        Children =
                            {
                                lblCounty, _pickerCounties, lblCompare, _pickerCounties2
                            }
                    },
                    new StackLayout()
                    {
                        HorizontalOptions = LayoutOptions.FillAndExpand,
                        Orientation = StackOrientation.Horizontal,
                        Children =
                            {
                                lblChapter, _pickerChapters
                            }
                    },
                    //degChapterData,
                    //plotView
                    dataControls
                }
            };

            _pickerCounties.SelectedIndex = 0;
            _pickerCounties2.SelectedIndex = 0;
            _pickerChapters.SelectedIndex = 0;
            degChapterData.SelectedRowHandle = -1;
        }

        void degChapterData_RowTap(object sender, RowTapEventArgs e)
        {
            // Disable row selection on row tapping
            var grid = sender as GridControl;
            if (grid.SelectedRowHandle > -1)
            {
                grid.SelectedRowHandle = -1;
            }
        }

        private bool _isPortrait;

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);

            if (plotView == null || dataControls == null)
            {
                return;
            }

            if (height > width) // portrait
            {
                plotView.HeightRequest = height/3;
                plotView.WidthRequest = -1;
                dataControls.Orientation = StackOrientation.Vertical;
            }
            else
            {
                dataControls.Orientation = StackOrientation.Horizontal;
                plotView.HeightRequest = -1;
                plotView.WidthRequest = width / 2;
                degChapterData.ForceLayout();
            }

            _isPortrait = height > width;

            plotView.Model.IsLegendVisible = plotView.Model.Series.Count > 1;

            if (plotView.Model.IsLegendVisible)
            {
                if (_isPortrait)
                {
                    plotView.Model.LegendPlacement = LegendPlacement.Outside;
                    plotView.Model.LegendPosition = LegendPosition.RightTop;
                    plotView.Model.LegendOrientation = LegendOrientation.Vertical;
                }
                else
                {
                    plotView.Model.LegendPlacement = LegendPlacement.Outside;
                    plotView.Model.LegendPosition = LegendPosition.TopRight;
                    plotView.Model.LegendOrientation = LegendOrientation.Horizontal;
                }
            }
        }

        private async Task LoadData()
        {
            var selectedCounty = _pickerCounties.SelectedIndex >= 0
                                     ? _viewModel.CountyList[_pickerCounties.Items[_pickerCounties.SelectedIndex]]
                                     : -1;
            var selectedCounty2 = _pickerCounties2.SelectedIndex >= 1
                                     ? _viewModel.CountyList[_pickerCounties.Items[_pickerCounties2.SelectedIndex - 1]]
                                     : -1;
            var selectedChapter = _pickerChapters.SelectedIndex >= 0
                                      ? _pickerChapters.Items[_pickerChapters.SelectedIndex]
                                      : string.Empty;

            await _viewModel.GetChapterData(selectedCounty, selectedCounty2, selectedChapter);

            if (plotView == null)
                return;

            plotView.Model = new PlotModel();
            plotView.Model.Title = "Evolutie indicator";

            plotView.Model.TextColor = OxyColors.LightGray;

            var dtAxis = new DateTimeAxis();
            dtAxis.Position = AxisPosition.Bottom;
            dtAxis.IntervalType = DateTimeIntervalType.Months;
            dtAxis.StringFormat = "yyyy-MM";
            dtAxis.IsPanEnabled = false;
            dtAxis.IsZoomEnabled = false;

            var verticalAxis = new LinearAxis();
            verticalAxis.Position = AxisPosition.Left;
            verticalAxis.IsPanEnabled = false;
            verticalAxis.IsZoomEnabled = false;

            plotView.Model.Axes.Add(dtAxis);
            plotView.Model.Axes.Add(verticalAxis);

            plotView.Model.Series.Clear();

            var series = new LineSeries();
            series.ItemsSource = _viewModel.ChapterData;
            series.DataFieldX = "TimeStamp";
            series.DataFieldY = "Value";
            series.Title = _pickerCounties.Items[_pickerCounties.SelectedIndex];
            plotView.Model.Series.Add(series);

            if (_viewModel.Value2ColumnVisibility)
            {
                var series2 = new LineSeries();
                series2.ItemsSource = _viewModel.ChapterData;
                series2.DataFieldX = "TimeStamp";
                series2.DataFieldY = "Value2";
                series2.Title = _pickerCounties2.Items[_pickerCounties2.SelectedIndex];
                plotView.Model.Series.Add(series2);
            }

            plotView.Model.IsLegendVisible = plotView.Model.Series.Count > 1;

            if (plotView.Model.IsLegendVisible)
            {
                if (_isPortrait)
                {
                    plotView.Model.LegendPlacement = LegendPlacement.Outside;
                    plotView.Model.LegendPosition = LegendPosition.RightTop;
                    plotView.Model.LegendOrientation = LegendOrientation.Vertical;
                }
                else
                {
                    plotView.Model.LegendPlacement = LegendPlacement.Outside;
                    plotView.Model.LegendPosition = LegendPosition.TopRight;
                    plotView.Model.LegendOrientation = LegendOrientation.Horizontal;
                }
            }

            plotView.Model.InvalidatePlot(true);
        }

        private async void pickerChapters_SelectedIndexChanged(object sender, EventArgs e)
        {
            await LoadData();
        }

        private async void pickerCounties_SelectedIndexChanged(object sender, EventArgs e)
        {
            await LoadData();
        }

        private async void _pickerCounties2_SelectedIndexChanged(object sender, EventArgs e)
        {
            await LoadData();
        }
    }
}
