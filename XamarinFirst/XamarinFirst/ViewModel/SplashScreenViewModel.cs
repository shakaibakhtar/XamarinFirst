using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinFirst.View;

namespace XamarinFirst.ViewModel
{
    public class SplashScreenViewModel
    {
        public INavigation navigation { get; set; }

        public SplashScreenViewModel(INavigation navigation)
        {
            this.navigation = navigation;
            LongRunningOperationAsync();
        }

        public async Task LongRunningOperationAsync()
        {
            await Task.Delay(2000);
            Application.Current.MainPage = new NavigationPage(new OnBoarding());
        }
    }
}
