using Microcharts;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;
using XamarinFirst.View;

namespace XamarinFirst.ViewModel
{
    public class DashboardViewModel : BaseViewModel
    {
        #region Properties & Variables
        public LineChart chart { get; set; }

        static string color = GetHexString((Color)Application.Current.Resources["ThemeBarChartColor"]);
        IEnumerable<ChartEntry> entries = new[]
        {
            new ChartEntry(250)
            {
                Label = "Mon",
                ValueLabel = "250",
                Color = SKColor.Parse(color)
            },
            new ChartEntry(150)
            {
                Label = "Tue",
                ValueLabel = "150",
                Color = SKColor.Parse(color)
            },
            new ChartEntry(75)
            {
                Label = "Wed",
                ValueLabel = "75",
                Color = SKColor.Parse(color)
            },
            new ChartEntry(125)
            {
                Label = "Thu",
                ValueLabel = "125",
                Color = SKColor.Parse(color)
            },
            new ChartEntry(100)
            {
                Label = "Fri",
                ValueLabel = "100",
                Color = SKColor.Parse(color)
            },
            new ChartEntry(200)
            {
                Label = "Sat",
                ValueLabel = "200",
                Color = SKColor.Parse(color)
            },
            new ChartEntry(300)
            {
                Label = "Sun",
                ValueLabel = "300",
                Color = SKColor.Parse(color)
            }
        };

        INavigation navigation;

        public Dashboard dashboardView { get; set; }

        public string SoldProperties { get; set; }
        public string SoldPropertiesInWords { get; set; }

        public string AvailableProperties { get; set; }
        public string AvailablePropertiesInWords { get; set; }

        public string ThisWeekSales { get; set; }
        public string ThisWeekSalesInWords { get; set; }

        public string ThisMonthSales { get; set; }
        public string ThisMonthSalesInWords { get; set; }

        public string TotalSales { get; set; }
        public string TotalSalesInWords { get; set; }

        public ObservableCollection<DashboardMasterMenuItem> MenuItems { get; set; }

        public string dpSrc { get; set; }
        public string userName { get; set; }

        DashboardMasterMenuItem _SelectedMenuItem;
        public DashboardMasterMenuItem SelectedMenuItem
        {
            get
            {
                return _SelectedMenuItem;
            }
            set
            {
                if (value != null)
                {
                    dashboardView.IsPresented = false;

                    _SelectedMenuItem = value;

                    if (_SelectedMenuItem.Id == 0)
                    {
                        navigation.PushAsync(new Properties());
                    }
                    else if (_SelectedMenuItem.Id == 1)
                    {
                        navigation.PushAsync(new PartnersPage());
                    }
                    else if (_SelectedMenuItem.Id == 2)
                    {
                        navigation.PushAsync(new DealersPage());
                    }
                    else if (_SelectedMenuItem.Id == 3)
                    {
                        navigation.PushAsync(new TransactionsPage());
                    }
                    else if (_SelectedMenuItem.Id == 4)
                    {
                        navigation.PushAsync(new AdvanceSearchPage());
                    }
                    else if (_SelectedMenuItem.Id == 5)
                    {
                        navigation.PushAsync(new SettingsPage());
                    }
                    else if (_SelectedMenuItem.Id == 6)
                    {
                        Application.Current.MainPage = new NavigationPage(new LoginPage());
                    }
                }
                _SelectedMenuItem = null;

                OnPropertyChanged();
            }
        }
        #endregion

        #region Constructiors
        public DashboardViewModel(INavigation navigation)
        {
            this.navigation = navigation;
            chart = new LineChart() { Entries = entries };

            SoldProperties = "200";
            SoldPropertiesInWords = "2 Hundred";
            AvailableProperties = "200";
            AvailablePropertiesInWords = "2 Hundred";
            ThisWeekSales = "55,30,000";
            ThisWeekSalesInWords = "55 Lakhs, 30 Thousands";
            ThisMonthSales = "4,55,30,000";
            ThisMonthSalesInWords = "4 Crore, 55 Lakhs, 30 Thousands";
            TotalSales = "10,10,55,30,000";
            TotalSalesInWords = "10 Arab, 10 Crore, 55 Lakhs, 30 Thousands";

            MenuItems = new ObservableCollection<DashboardMasterMenuItem>(new[]
                {
                    new DashboardMasterMenuItem { Id = 0, Title = "Properties" },
                    new DashboardMasterMenuItem { Id = 1, Title = "Partners" },
                    new DashboardMasterMenuItem { Id = 2, Title = "Dealers" },
                    new DashboardMasterMenuItem { Id = 3, Title = "Transactions" },
                    new DashboardMasterMenuItem { Id = 4, Title = "Advance Search" },
                    new DashboardMasterMenuItem { Id = 5, Title = "Settings" },
                    new DashboardMasterMenuItem { Id = 6, Title = "Logout" },
                });

            dpSrc = "dp.png";
            userName = "Nadeem Ahmad";
        }
        #endregion

        #region Commands
        public Command OpenProfilePageCommand
        {
            get
            {
                return new Command(() =>
                {
                    dashboardView.IsPresented = false;
                    navigation.PopToRootAsync();
                    navigation.PushAsync(new UserProfile());
                });
            }
        }
        #endregion

        #region Functions
        private static string GetHexString(Xamarin.Forms.Color color)
        {
            var red = (int)(color.R * 255);
            var green = (int)(color.G * 255);
            var blue = (int)(color.B * 255);
            var alpha = (int)(color.A * 255);
            var hex = $"#{alpha:X2}{red:X2}{green:X2}{blue:X2}";

            return hex;
        }
        #endregion
    }
}
