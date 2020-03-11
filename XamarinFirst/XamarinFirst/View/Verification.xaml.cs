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
    public partial class Verification : ContentPage
    {
        public Verification()
        {
            InitializeComponent();
        }

        private void ok_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Notification", "Success Or Fail Dialog", "OK");
            Navigation.PopToRootAsync();
        }
    }
}