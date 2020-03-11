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
        public DashboardDetail()
        {
           // SetValue();
            InitializeComponent();
        }

        private void btnTransactions_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TransactionsPage());
        }

        private void btnPartners_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PartnersPage());
        }
    }
}