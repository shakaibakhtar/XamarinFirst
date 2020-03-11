using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFirst
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new XamarinFirst.View.SplashScreen();
            //MainPage = new NavigationPage(new LoginPage());
            //MainPage = new NavigationPage(new XamarinFirst.View.Properties());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
