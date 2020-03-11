using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFirst.Model
{
    class PropertyModel
    {
        public string PlotNo { get; set; }
        public string PlotType { get; set; }
        public string Availability { get; set; }

        public PropertyModel()
        {}

        public PropertyModel(string PlotNo, string PlotType, string Availability)
        {
            this.PlotNo = PlotNo;
            this.PlotType = PlotType;
            this.Availability = Availability;
        }

        //public int SalePrice { get; set; }
        //public string AssignedTo { get; set; }
        //public string AssignedBy { get; set; }
        //public string Description { get; set; }
        //public string Characteristics { get; set; }
    }
}
