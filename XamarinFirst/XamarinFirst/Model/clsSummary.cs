using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XamarinFirst.Model
{
    public class clsSummary
    {
        public int? AccountHeadId { get; set; }
        public string AccountHeadTitle { get; set; }
        public int? TypeId { get; set; }
        public string TypeTitle { get; set; }
        public string Code { get; set; }
        //
        public int? AccountHeadLineId { get; set; }
        public string AccountHeadLineTitle { get; set; }
        public int? Padding { get; set; }
        public decimal? Balance { get; set; }
        public string RedirectLink { get; set; }
        public decimal? Credit { get; set; }
        public decimal? Debit { get; set; }
        //retained
        public string Detail { get; set; }
        public string BalanceRetained { get; set; }
        public DateTime? Date { get; set; }
        //
        public string ReferenceNo { get; set; }
        public string BalanceForShow { get; set; }
        public int ChartOfAccountId { get; set; }
        public string DebitForShow { get; set; }
        public string CreditForShow { get; set; }
        public int? RetainedEarningId { get; set; }
        //
        public int? ModuleId { get; set; }
        public int? SubModuleId { get; set; }
        public int? CampusId { get; set; }
        public string CampusName { get; set; }
        public string FormatType { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public List<clsSummary> Income = new List<clsSummary>();
        public List<clsSummary> Expense = new List<clsSummary>();
        public string InstituteName { get; set; }
        public string InstituteAddress { get; set; }
        public int? SchoolId { get; set; }
        public List<clsSummary> CampusList = new List<clsSummary>();
        public string DateinString { get; set; }
        public decimal? Amount { get; set; }
        public string Description { get; set; }
        public List<clsSummary> DateListIncome = new List<clsSummary>();
        public List<clsSummary> DateListExpense = new List<clsSummary>();
    }
}