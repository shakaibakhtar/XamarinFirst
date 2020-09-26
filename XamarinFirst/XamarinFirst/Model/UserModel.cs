using System;
using System.Collections.Generic;
using System.Text;
using XamarinFirst.ViewModel;

namespace XamarinFirst.Model
{
    public class UserModel:BaseViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
