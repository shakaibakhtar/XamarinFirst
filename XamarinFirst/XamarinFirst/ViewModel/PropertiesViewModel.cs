using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using XamarinFirst.Model;

namespace XamarinFirst.ViewModel
{
    class PropertiesViewModel
    {
        public ObservableCollection<PropertyModel> Properties { get; set; } = new ObservableCollection<PropertyModel>();

        public PropertiesViewModel()
        {
            for (int i = 0; i < 15; i++)
            {
                PropertyModel property = new PropertyModel();
                property.PlotNo = i + "A";
                property.PlotType = "Commercial";
                property.Availability = "Available";

                Properties.Add(property);
            }
        }
    }
}
