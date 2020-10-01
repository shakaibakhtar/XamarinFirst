using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XamarinFirst.Model
{
    public class clsChartOfAccount
    {
        public int? AccountHeadId { get; set; }
        public string AccountHeadTitle { get; set; }
        public Nullable<int> TypeId { get; set; }
        public string TypeTitle { get; set; }
        public string Category { get; set; }
        public string Status { get; set; }
        public string Code { get; set; }
        public int? AccountHeadLineId { get; set; }
        public int AccountHeadLineId2 { get; set; }
        public string AccountHeadLineTitle { get; set; }
        public int? Padding { get; set; }
        public string StartingBalanceType { get; set; }
        public decimal? StartingBalance { get; set; }
        public decimal? StartingBalanceDebit { get; set; }
        public decimal? StartingBalanceCredit { get; set; }
        public decimal? Balance { get; set; }
        public string AccountType { get; set; }
        public int TransactionId { get; set; }
        public DateTime? Date { get; set; }
        public string TransactionType { get; set; }
        public string TransactionTypeWithAmount{ get; set; }
        public string ReferenceNo { get; set; }
        public string PaidBy { get; set; }
        public string ReceivedBy { get; set; }
        public string Description { get; set; }
        public int TransactionLineId { get; set; }
        public Nullable<int> SerialNo { get; set; }
        public string Detail { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public decimal? Amount { get; set; }
        public int JournalLedgerId { get; set; }
        public string Narration { get; set; }
        public int JournalLedgerLineId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public string CreatedByString { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public string UpdatedByString { get; set; }
       
    }
}