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
    public partial class Dashboard : MasterDetailPage
    {
        public Dashboard()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as DashboardMasterMenuItem;
            if (item == null)
                return;

            Detail.Navigation.PopToRootAsync();

            if(item.Id == 0)
            {
                Detail.Navigation.PushAsync(new Properties());
            }
            else if (item.Id == 1)
            {
                Detail.Navigation.PushAsync(new PartnersPage());
            }
            else if (item.Id == 2)
            {
                Detail.Navigation.PushAsync(new DealersPage());
            }
            else if (item.Id == 3)
            {
                Detail.Navigation.PushAsync(new TransactionsPage());
            }
            else if (item.Id == 4)
            {
                Detail.Navigation.PushAsync(new SettingsPage());
            }

            ((ListView)sender).SelectedItem = null;
            IsPresented = false;

            //var page = (Page)Activator.CreateInstance(item.TargetType);
            //page.Title = item.Title;

            //Detail = new NavigationPage(page);
            //IsPresented = false;

            //MasterPage.ListView.SelectedItem = null;
        }

        protected override bool OnBackButtonPressed()
        {
            Application.Current.MainPage = new NavigationPage(new LoginPage());
            return true;
        }
    }
}