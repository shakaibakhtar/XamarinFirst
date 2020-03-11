using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using XamarinFirst.Model;

namespace XamarinFirst.ViewModel
{
    class TransactionViewModel
    {
        public ObservableCollection<TransactionModel> Transactions { get; set; } = new ObservableCollection<TransactionModel>();

        public TransactionViewModel()
        {
            for (int i = 0; i < 15; i++)
            {
                TransactionModel transaction = new TransactionModel();
                transaction.Title = "Sold Property " + i;
                transaction.DateTime = "01/02/2020 02:0" + i + "pm";
                transaction.TransactionBy = "Ali " + i;
                transaction.Amount = "50" + i;
                transaction.Color = (i == 4) ?  "red" : "blue";

                Transactions.Add(transaction);
            }
        }
    }
}
