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
    public partial class ForgotPassword : ContentPage
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void submit_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Notification", "Password Sent To: " + entry_email.Text, "Ok");
            Navigation.PushAsync(new Verification());
        }
    }
}