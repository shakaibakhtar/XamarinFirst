using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XamarinFirst.Model;
using XamarinFirst.View;

namespace XamarinFirst.ViewModel
{
    public class LoginPageViewModel
    {
        public UserModel User { get; set; }
        INavigation navigation;

        public LoginPageViewModel(INavigation navigation)
        {
            this.navigation = navigation;
            User = new UserModel();
        }

        #region Commands
        public Command ForgotPasswordCommand
        {
            get
            {
                return new Command(() =>
                {
                    navigation.PushAsync(new ForgotPassword());
                });
            }
        }
        
        public Command LoginCommand
        {
            get
            {
                return new Command(() =>
                {
                    Application.Current.MainPage = new NavigationPage(new Dashboard());
                });
            }
        }
        
        public Command SkipLoginCommand
        {
            get
            {
                return new Command(() =>
                {
                    //Navigate to Home Page Visitor
                    Application.Current.MainPage = new NavigationPage(new HomePageVisitor());
                });
            }
        }
        
        public Command OpenSignupPageCommand
        {
            get
            {
                return new Command(() =>
                {
                    App.Current.MainPage.DisplayAlert("Notification", "Signup Page To Be Designed!", "ok!");
                });
            }
        }
        #endregion
    }
}
