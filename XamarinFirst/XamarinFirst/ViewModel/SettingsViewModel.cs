using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XamarinFirst.View;

namespace XamarinFirst.ViewModel
{
    public class SettingsViewModel:BaseViewModel
    {
        #region Properties & Variables
        INavigation navigation;

        string _SelectedSetting;
        public string SelectedSetting
        {
            get
            {
                return _SelectedSetting;
            }
            set
            {
                if (value != null)
                {
                    _SelectedSetting = value;

                    if (_SelectedSetting.Equals("Account Settings"))
                        navigation.PushAsync(new AccountSettingsPage());
                    else if (_SelectedSetting.Equals("About"))
                        Application.Current.MainPage.DisplayAlert("Notification", "About", "OK");
                    else if (_SelectedSetting.Equals("Business Settings"))
                        Application.Current.MainPage.DisplayAlert("Notification", "Business Settings", "OK");
                    else if (_SelectedSetting.Equals("Language Settings"))
                        Application.Current.MainPage.DisplayAlert("Notification", "Language Settings", "OK");
                }

                _SelectedSetting = null;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Constructors
        public SettingsViewModel(INavigation navigation)
        {
            this.navigation = navigation;
        }
        #endregion
    }
}
