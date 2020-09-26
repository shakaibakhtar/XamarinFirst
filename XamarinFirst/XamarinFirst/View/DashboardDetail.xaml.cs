using Microcharts;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFirst.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DashboardDetail : ContentPage
    {
        static string color = GetHexString((Xamarin.Forms.Color)Application.Current.Resources["ThemeBarChartColor"]);

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
        public DashboardDetail()
        {
            // SetValue();
            InitializeComponent();
            var chart = new LineChart() { Entries = entries };
            this.SalesChart.Chart = chart;
        }

        //private void btnTransactions_Clicked(object sender, EventArgs e)
        //{
        //    Navigation.PushAsync(new TransactionsPage());
        //}

        //private void btnPartners_Clicked(object sender, EventArgs e)
        //{
        //    Navigation.PushAsync(new PartnersPage());
        //}

        private static string GetHexString(Xamarin.Forms.Color color)
        {
            var red = (int)(color.R * 255);
            var green = (int)(color.G * 255);
            var blue = (int)(color.B * 255);
            var alpha = (int)(color.A * 255);
            var hex = $"#{alpha:X2}{red:X2}{green:X2}{blue:X2}";

            return hex;
        }
    }
}