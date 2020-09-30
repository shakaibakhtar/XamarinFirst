using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using XamarinFirst.Model;
using XamarinFirst.View;

namespace XamarinFirst.ViewModel
{
    class PropertiesViewModel:BaseViewModel
    {
        #region Properties & Variables
        public ObservableCollection<PropertyModel> Properties { get; set; }
        string[] plotStatuses = { "Sold Out", "Not Sold", "Pending" };
        string[] plotStatusColors = { "#FF0000", "#06A216", "#EC5701" };
        INavigation navigation;

        PropertyModel _SelectedProperty;
        public PropertyModel SelectedProperty
        {
            get
            {
                return _SelectedProperty;
            }
            set
            {
                _SelectedProperty = value;
                navigation.PushAsync(new PropertyDetailPage());
                _SelectedProperty = null;

                OnPropertyChanged();
            }
        }
        #endregion

        #region Constructors
        public PropertiesViewModel(INavigation navigation)
        {
            this.navigation = navigation;

            Properties = new ObservableCollection<PropertyModel>();

            for (int i = 0; i < 15; i++)
            {
                PropertyModel property = new PropertyModel();
                property.PlotNo = i + "A";
                property.PlotSize = "35x70";
                property.PlotStatus = plotStatuses[i % 3];
                property.PlotStatusColor = plotStatusColors[i % 3];

                Properties.Add(property);
            }
        }
        #endregion
    }
}
