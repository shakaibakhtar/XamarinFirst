using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XamarinFirst.ViewModel;

namespace XamarinFirst.Model
{
    public class UserModel : BaseViewModel
    {
        ImageSource _DPSrc;
        public ImageSource DPSrc
        {
            get
            {
                return _DPSrc;
            }
            set
            {
                if(value != null)
                {
                    _DPSrc = value;
                }
                else
                {
                    _DPSrc = "dp.png";
                }

                OnPropertyChanged();
            }
        }
        public string Username { get; set; }
        public string Contact { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
