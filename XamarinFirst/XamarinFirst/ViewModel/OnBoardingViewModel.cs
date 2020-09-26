using System;
using System.Collections.Generic;
using System.Text;
using Xam.TabView.Control;
using Xamarin.Forms;

namespace XamarinFirst.ViewModel
{
    public class OnBoardingViewModel
    {
        private int currentTabIndex;
        public INavigation navigation { get; set; }
        public XFTabControl TabControl { get; set; }

        public OnBoardingViewModel(INavigation navigation, XFTabControl tabControl)
        {
            currentTabIndex = 0;

            this.navigation = navigation;
            this.TabControl = tabControl;
            //RegisterVM = new RegisterViewModel(navigation, tabControl);
        }


        public Command GotoNextCommand
        {
            get
            {
                return new Command(() =>
                {
                    Device.BeginInvokeOnMainThread(() =>
                    {
                        if (currentTabIndex < 2)
                        {
                            currentTabIndex++;
                        }
                        else if(currentTabIndex == 2)
                        {
                            Application.Current.MainPage = new NavigationPage(new LoginPage());
                        }
                        TabControl.SelectTabPage(currentTabIndex);
                    });
                });
            }
        }

        public Command GotoPreviousCommand
        {
            get
            {
                return new Command(() =>
                {
                    Device.BeginInvokeOnMainThread(() =>
                    {
                        if (currentTabIndex > 0)
                        {
                            currentTabIndex--;
                        }
                        TabControl.SelectTabPage(currentTabIndex);
                    });
                });
            }
        }
    }
}
