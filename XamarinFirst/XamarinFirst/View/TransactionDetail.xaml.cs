﻿using System;
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
    public partial class TransactionDetail : ContentPage
    {
        public TransactionDetail()
        {
            InitializeComponent();

            BindingContext = new TransactionDetailPageViewModel(Navigation);
        }

        //private void ImageButton_Clicked(object sender, EventArgs e)
        //{
        //    DisplayAlert("Notification", "Screenshot Captured", "OK");
        //}
    }
}