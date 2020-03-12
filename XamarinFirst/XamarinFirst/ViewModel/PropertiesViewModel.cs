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
        string[] plotStatuses = {"Sold Out", "Not Sold", "Pending"};
        string[] plotStatusColors = { "#FF0000", "#06A216", "#EC5701" };
        public PropertiesViewModel()
        {
            for (int i = 0; i < 15; i++)
            {
                PropertyModel property = new PropertyModel();
                property.PlotNo = i + "A";
                property.PlotSize = "35x70";
                property.PlotStatus = plotStatuses[i%3];
                property.PlotStatusColor = plotStatusColors[i % 3];

                Properties.Add(property);
            }
        }
    }
}
