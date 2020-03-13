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

        string[] BankNames = { "Bank Alfalah Ltd.", "Habib Bank Ltd." };
        string[] Dates = { "04 March, 2020", "08 March, 2020" };
        string[] AccNumbers = { "1862-212874152", "0230-697833147" };
        string[] Amounts = { "8000000", "5000000" };
        string[] Icons = { "creditIcon.png", "debitIcon.png" };
        string[] Colors = { "#00B41E", "#D40404" };
        string[] TransactionType = { "C", "D" };

        public TransactionViewModel()
        {
            for (int i = 0; i < 15; i++)
            {
                TransactionModel transaction = new TransactionModel();
                transaction.BankName = BankNames[i % 2];
                transaction.Date = Dates[i % 2];
                transaction.AccountNo = AccNumbers[i % 2];
                transaction.Amount = Amounts[i % 2];
                transaction.Icon = Icons[i % 2];
                transaction.Color = Colors[i % 2];
                transaction.TransactionType = TransactionType[i % 2];

                Transactions.Add(transaction);
            }
        }
    }
}
