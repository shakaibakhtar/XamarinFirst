using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinFirst.View;

namespace XamarinFirst
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class LoginPage : ContentPage
    {
        private bool _canClose = false;

        public LoginPage()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ForgotPassword());
            //DisplayAlert("Oh No!", "You Forgot Your Password!", "Recover It!");
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            DisplayAlert("Notification", "Do You Want To Login With FACEBOOK!", "Login!");
        }

        private void bilal_Clicked(object sender, EventArgs e)
        {
            //if success
            Application.Current.MainPage = new NavigationPage(new Dashboard());
            //else
            //Navigation.PopAsync();
        }

        private void signup_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Notification", "Signup Clicked!", "Great!");
        }

        protected override bool OnBackButtonPressed()
        {
            base.OnBackButtonPressed();
            //if (!_canClose)
            //{
            //    ShowExitDialog();
            //}
            //return !_canClose;
            return false;
        }

        //private async void ShowExitDialog()
        //{
        //    var answer = await DisplayAlert("Exit", "Do you wan't to exit the App?", "Yes", "No");
        //    if (answer)
        //    {
        //        _canClose = true;
        //    }
        //}
    }
}
