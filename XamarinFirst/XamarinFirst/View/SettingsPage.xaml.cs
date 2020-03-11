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
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItemIndex == 0)
                Navigation.PushAsync(new AccountSettingsPage());
            else if (e.SelectedItemIndex == 1)
                DisplayAlert("Notification", "About", "OK");
            else if (e.SelectedItemIndex == 2)
                DisplayAlert("Notification", "Business Settings", "OK");
            else if (e.SelectedItemIndex == 3)
                DisplayAlert("Notification", "Language Settings", "OK");

            ((ListView)sender).SelectedItem = null;
        }
    }
}