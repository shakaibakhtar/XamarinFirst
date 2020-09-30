using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFirst.Model;
using XamarinFirst.ViewModel;

namespace XamarinFirst.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Properties : ContentPage
    {
        public Properties()
        {
            InitializeComponent();
            BindingContext = new PropertiesViewModel(Navigation);
        }
    }
}