using Microcharts;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Entry = Microcharts.Entry;

namespace XamarinFirst.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DashboardDetail : ContentPage
    {
        static string color = GetHexString((Xamarin.Forms.Color)Application.Current.Resources["ThemeBarChartColor"]);

        List<Entry> entries = new List<Entry>()
        {
            new Entry(250)
            {
                Label = "Monday",
                ValueLabel = "250",
                Color = SKColor.Parse(color)
            },
            new Entry(150)
            {
                Label = "Tuesday",
                ValueLabel = "150",
                Color = SKColor.Parse(color)
            },
            new Entry(75)
            {
                Label = "Wednesday",
                ValueLabel = "75",
                Color = SKColor.Parse(color)
            },
            new Entry(125)
            {
                Label = "Thursday",
                ValueLabel = "125",
                Color = SKColor.Parse(color)
            },
            new Entry(100)
            {
                Label = "Friday",
                ValueLabel = "100",
                Color = SKColor.Parse(color)
            },
            new Entry(200)
            {
                Label = "Saturday",
                ValueLabel = "200",
                Color = SKColor.Parse(color)
            },
            new Entry(300)
            {
                Label = "Sunday",
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

        private void btnTransactions_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TransactionsPage());
        }

        private void btnPartners_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PartnersPage());
        }

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