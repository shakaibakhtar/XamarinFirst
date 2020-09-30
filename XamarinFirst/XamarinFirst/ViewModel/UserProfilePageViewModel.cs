using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinFirst.ViewModel
{
    public class UserProfilePageViewModel
    {
        #region Properites & Variables
        INavigation navigation;
        public string dpSrc { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string designation { get; set; }
        public string location { get; set; }
        #endregion

        #region Constructors
        public UserProfilePageViewModel(INavigation navigation)
        {
            this.navigation = navigation;

            dpSrc = "dp.png";
            name = "John Smith";
            email = "johnsmith@gmail.com";
            phone = "+923123456789";
            designation = "Real Estate Agent";
            location = "Islamabad";
        }
        #endregion
    }
}
