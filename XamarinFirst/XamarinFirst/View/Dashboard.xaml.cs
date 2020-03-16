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
            MasterPage.ListView.ItemTapped += ListView_ItemTapped;
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            ((ListView)sender).SelectedItem = null;
            IsPresented = false;

            //var page = (Page)Activator.CreateInstance(item.TargetType);
            //page.Title = item.Title;

            //Detail = new NavigationPage(page);
            //IsPresented = false;

            //MasterPage.ListView.SelectedItem = null;
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as DashboardMasterMenuItem;
            if (item == null)
                return;

            await Detail.Navigation.PopToRootAsync();

            if (item.Id == 0)
            {
                await Detail.Navigation.PushAsync(new Properties());
            }
            else if (item.Id == 1)
            {
                await Detail.Navigation.PushAsync(new PartnersPage());
            }
            else if (item.Id == 2)
            {
                await Detail.Navigation.PushAsync(new DealersPage());
            }
            else if (item.Id == 3)
            {
                await Detail.Navigation.PushAsync(new TransactionsPage());
            }
            else if (item.Id == 4)
            {
                await Detail.Navigation.PushAsync(new AdvanceSearchPage());
            }
            else if (item.Id == 5)
            {
                await Detail.Navigation.PushAsync(new SettingsPage());
            }


            //IsPresented = false;
        }

        protected override bool OnBackButtonPressed()
        {
            if (Detail.Navigation.NavigationStack.ToList().Count > 1)
                Detail.Navigation.PopAsync();
            else if (IsPresented)
                IsPresented = !IsPresented;
            else
                Application.Current.MainPage = new NavigationPage(new LoginPage());
            return true;
        }
    }
}