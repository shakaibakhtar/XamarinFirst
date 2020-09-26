using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFirst.Model
{
    public class PropertyModel
    {
        public string PlotNo { get; set; }
        public string PlotSize { get; set; }
        public string PlotStatus { get; set; }
        public string PlotStatusColor { get; set; }
        public string PropertyImage { get; set; }
        public string PropertyName { get; set; }
        public double Demand { get; set; }
        public string PropertyAddress { get; set; }

        public PropertyModel()
        {}

        public PropertyModel(string PlotNo, string PlotSize, string PlotStatus)
        {
            this.PlotNo = PlotNo;
            this.PlotSize = PlotSize;
            this.PlotStatus = PlotStatus;
        }

        //public int SalePrice { get; set; }
        //public string AssignedTo { get; set; }
        //public string AssignedBy { get; set; }
        //public string Description { get; set; }
        //public string Characteristics { get; set; }
    }
}
