using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XamarinFirst.Model;

namespace XamarinFirst.ViewModel
{
    public class TransactionDetailPageViewModel : BaseViewModel
    {
        #region Properties & Variables
        INavigation navigation;

        public TransactionModel Transaction { get; set; }
        #endregion

        #region Constructors
        public TransactionDetailPageViewModel(INavigation navigation)
        {
            this.navigation = navigation;

            Transaction = new TransactionModel() { Title = "Sold Property", Amount = "10000", Date = "1:45 PM, 10 Jan, 2020", MadeByUser = "Nouman", TransactionType = "Office Expense", AccountDebited = "1862-57482453", AccountCredited = "0230-558564778", Note = "Paid for kitchen material" };
        }
        #endregion

        #region Commands
        public Command TakeSSCommand
        {
            get
            {
                return new Command(() =>
                {
                    Application.Current.MainPage.DisplayAlert("Notification", "Screenshot Captured", "OK");
            });
            }
        }
        #endregion
    }
}
