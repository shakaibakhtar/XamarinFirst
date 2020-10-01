using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFirst.ViewModel;

namespace XamarinFirst.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AccountSettingsPage : ContentPage
    {
        public AccountSettingsPage()
        {
            InitializeComponent();

            BindingContext = new AccountSettingsViewModel(Navigation);
        }

        //private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        //{
        //    Navigation.PushAsync(new UploadImagePage());
        //}

        //private void btnSave_Clicked(object sender, EventArgs e)
        //{
        //    DisplayAlert("Notification", "Name = " + txtName.Text + "\nContact = " + txtContact.Text + "\nPassword = " + txtPassword.Text, "OK");
        //}
    }
}