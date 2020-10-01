using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XamarinFirst.Model
{
    public class clsInstallment
    {
        public int? InstallmentId { get; set; }
        public int? UserId { get; set; }
        public string UserName { get; set; }
        public int? PropertyId { get; set; }
        public string PropertyName { get; set; }
        public DateTime? RecordDate { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? DownPayment { get; set; }
        public int? TotalInstallments { get; set; }
        public decimal? TotalPeriodInMonth { get; set; }
        public decimal? InstallmentPeriodInMonth { get; set; }
        public int InstallmentDetailId { get; set; }
        public int? InstallmentNo { get; set; }
        public DateTime? InstallmentDate { get; set; }
        public decimal? Amount { get; set; }
        public string TaxType { get; set; }
        public decimal? TaxRate { get; set; }
        public decimal? TaxAmount { get; set; }
        public string DiscountType { get; set; }
        public decimal? DiscountRate { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? TotalLineAmount { get; set; }
        public int? InstallmentDayOfMonth { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public string CreatedByString { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public string UpdatedByString { get; set; }
    }
}