using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFirst.Model
{
    public class TransactionModel
    {
        public string BankName { get; set; }
        public string Date { get; set; }
        public string Amount { get; set; }
        public string AccountNo { get; set; }
        public string Icon { get; set; }
        public string Color { get; set; }
        public string TransactionType { get; set; }

        public string Title { get; set; }
        public string MadeByUser { get; set; }
        public string AccountDebited { get; set; }
        public string AccountCredited { get; set; }
        public string Note { get; set; }
    }
}
