using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFirst.ViewModel;

namespace XamarinFirst.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DealersPage : ContentPage
    {
        public DealersPage()
        {
            InitializeComponent();
            BindingContext = new DealersViewModel();
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return; // catch deselection
            }

            ((ListView)sender).SelectedItem = null;
            Navigation.PushAsync(new UserProfile());
        }
    }
}