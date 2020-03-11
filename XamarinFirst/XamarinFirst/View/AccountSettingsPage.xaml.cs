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
    public partial class AccountSettingsPage : ContentPage
    {
        public AccountSettingsPage()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new UploadImagePage());
        }

        private void btnSave_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Notification", "Name = " + txtName.Text + "\nContact = " + txtContact.Text + "\nPassword = " + txtPassword.Text, "OK");
        }
    }
}