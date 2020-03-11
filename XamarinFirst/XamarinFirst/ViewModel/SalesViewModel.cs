using System;
using System.Collections.Generic;
using System.Text;
using XamarinFirst.Model;

namespace XamarinFirst.ViewModel
{
    class SalesViewModel
    {
        public List<SalesModel> SalesData { get; set; }

        public SalesViewModel()
        {
            SalesData = new List<SalesModel>();

            SalesData.Add(new SalesModel { Year = "2014", Sale = 342 });
            SalesData.Add(new SalesModel { Year = "2015", Sale = 393 });
            SalesData.Add(new SalesModel { Year = "2016", Sale = 431 });
            SalesData.Add(new SalesModel { Year = "2017", Sale = 500 });
            SalesData.Add(new SalesModel { Year = "2018", Sale = 520 });
            SalesData.Add(new SalesModel { Year = "2019", Sale = 578 });
        }
    }
}
