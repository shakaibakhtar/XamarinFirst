using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFirst.ViewModel;

namespace XamarinFirst.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserSignUpPage : ContentPage
    {
        public UserSignUpPage()
        {
            InitializeComponent();

            BindingContext = new UserSignUpViewModel(Navigation);
        }
    }
}