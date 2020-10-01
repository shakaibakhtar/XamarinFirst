using System;
using System.Collections.Generic;
using System.Text;
using XamarinFirst.ViewModel;

namespace XamarinFirst.Model
{
    public class DashboardModel:BaseViewModel
    {
        public Decimal SoldPropertiesCount { get; set; }
        public string SoldPropertiesCountString { get; set; }
        public Decimal AvailablePropertiesCount { get; set; }
        public string AvailablePropertiesCountString { get; set; }
        public Decimal WeekSales { get; set; }
        public string WeekSalesString { get; set; }
        public Decimal MonthSales { get; set; }
        public string MonthSalesString { get; set; }
        public Decimal TotalSales { get; set; }
        public string TotalSalesString { get; set; }

        public List<clsGraph> Graph { get; set; }
    }
}
