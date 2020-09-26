using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFirst.ViewModel;

namespace XamarinFirst.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OnBoarding : ContentPage
    {
        public OnBoarding()
        {
            InitializeComponent();
            BindingContext = new OnBoardingViewModel(Navigation, Tabcomponent);
        }
    }
}