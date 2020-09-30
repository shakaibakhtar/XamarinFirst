using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XamarinFirst.Model;

namespace XamarinFirst.ViewModel
{
    public class PropertyDetailViewModel: BaseViewModel
    {
        #region Properties & Variables
        INavigation navigation;
        public List<PropertyModel> PropertyImages { get; set; }

        public string PlotNo { get; set; }
        public string Price { get; set; }
        public string PropertyType { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public bool HasGas { get; set; }
        public bool HasElectricity { get; set; }
        public bool HasWater { get; set; }
        public bool HasParking { get; set; }

        int _myPosition;
        public int myPosition
        {
            get
            {
                return _myPosition;
            }
            set
            {
                _myPosition = value;

                OnPropertyChanged();
            }
        }
        #endregion

        #region Constructors
        public PropertyDetailViewModel(INavigation navigation)
        {
            this.navigation = navigation;

            myPosition = 0;

            PropertyImages = new List<PropertyModel>
            {
                new PropertyModel() { PropertyImage = "property1.png" },
                new PropertyModel() { PropertyImage = "property2.png" },
            };

            PlotNo = "11-A";
            Price = "30,000,000";
            PropertyType = "Type of property";
            Address = "Street 4, Block-D, Main Commercial, Lohi Beer, Soan Gardens, Islamabad";
            Description = "Mehdi Marketing Services, Block-D, Main Commercial, Soan Gardens";

            HasGas = true;
            HasElectricity = true;
            HasWater = true;
            HasParking = true;
        }
        #endregion
    }
}
