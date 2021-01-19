using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XamarinFirst.Model;
using XamarinFirst.View;

namespace XamarinFirst.ViewModel
{
    public class UserSignUpViewModel : BaseViewModel
    {
        #region Properites
        public INavigation navigation { get; set; }

        clsUser _User;
        public clsUser User
        {
            get
            {
                return _User;
            }
            set
            {
                if (value != null)
                {
                    _User = value;
                }
                OnPropertyChanged();
            }
        }

        string _ConfirmPassword;
        public string ConfirmPassword
        {
            get
            {
                return _ConfirmPassword;
            }
            set
            {
                _ConfirmPassword = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Constructors
        public UserSignUpViewModel(INavigation navigation)
        {
            this.navigation = navigation;
            User = new clsUser();
        }
        #endregion

        #region Commands
        public Command SignupCommand
        {
            get
            {
                return new Command(() =>
                {
                    if (ValidateFields())
                    {
                        Application.Current.MainPage = new NavigationPage(new Dashboard());
                    }
                });
            }
        }
        #endregion

        #region Functions
        private bool ValidateFields()
        {
            bool isValid = false;

            if (User.Password == ConfirmPassword)
            {
                isValid = true;
            }
            else
            {
                Application.Current.MainPage.DisplayAlert("Error", "Password & Confirm Password must be same.", "OK");
            }

            return isValid;
        }
        #endregion
    }
}
