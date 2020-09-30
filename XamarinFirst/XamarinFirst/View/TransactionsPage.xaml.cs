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
    public partial class TransactionsPage : ContentPage
    {
        public TransactionsPage()
        {
            InitializeComponent();
            BindingContext = new TransactionViewModel(Navigation);
        }

        //private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        //{
        //    if(e.SelectedItem == null)
        //    {
        //        return; // catch deselection
        //    }

        //    TransactionModel transaction = e.SelectedItem as TransactionModel;
        //    Navigation.PushAsync(new TransactionDetail());
        //    ((ListView)sender).SelectedItem = null;
        //    //DisplayAlert(transaction.Title, transaction.DateTime + "==>" + transaction.TransactionBy + " ==> " + transaction.Amount, "OK");
        //}
    }
}