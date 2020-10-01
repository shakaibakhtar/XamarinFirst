using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XamarinFirst.Model
{
    public class clsCity
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int CurrencyId { get; set; }
        public string CurrencyName { get; set; }
        public string Country { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public string CreatedByString { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public string UpdatedByString { get; set; }
    }
}