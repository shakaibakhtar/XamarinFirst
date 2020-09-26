using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XamarinFirst.Model;

namespace XamarinFirst.ViewModel
{
    public class HomePageVisitorViewModel
    {
        INavigation navigation;
        public List<HousingSocietyModel> HousingSocieties { get; set; }
        public List<PropertyModel> FeaturedProperties { get; set; }
        public List<CustomSearchResultModel> RecentProperties { get; set; }

        public HomePageVisitorViewModel(INavigation navigation)
        {
            this.navigation = navigation;

            HousingSocieties = new List<HousingSocietyModel>
            {
                new HousingSocietyModel{ SocietyImage = "property1.png", SocietyName = "Society 1" },
                new HousingSocietyModel{ SocietyImage = "property2.png", SocietyName = "Society 2" },
                new HousingSocietyModel{ SocietyImage = "property1.png", SocietyName = "Society 3" },
                new HousingSocietyModel{ SocietyImage = "property2.png", SocietyName = "Society 4" },
                new HousingSocietyModel{ SocietyImage = "property1.png", SocietyName = "Society 5" }
            };
            FeaturedProperties = new List<PropertyModel>
            {
                new PropertyModel { PropertyImage = "property1.png", PropertyName = "Property 1", PropertyAddress = "Street 4, Block-D, Main Commercial, Lohi Beer, Soan Gardens, Islamabad", Demand = 50000000 },
                new PropertyModel { PropertyImage = "property2.png", PropertyName = "Property 2", PropertyAddress = "Street 4, Block-D, Main Commercial, Lohi Beer, Soan Gardens, Islamabad", Demand = 500000000 },
                new PropertyModel { PropertyImage = "property1.png", PropertyName = "Property 3", PropertyAddress = "Street 4, Block-D, Main Commercial, Lohi Beer, Soan Gardens, Islamabad", Demand = 50000000 },
                new PropertyModel { PropertyImage = "property2.png", PropertyName = "Property 4", PropertyAddress = "Street 4, Block-D, Main Commercial, Lohi Beer, Soan Gardens, Islamabad", Demand = 50000000 },
                new PropertyModel { PropertyImage = "property1.png", PropertyName = "Property 5", PropertyAddress = "Street 4, Block-D, Main Commercial, Lohi Beer, Soan Gardens, Islamabad", Demand = 500000 }
            };

            RecentProperties = new List<CustomSearchResultModel>
            {
                new CustomSearchResultModel { imageLink = "property1.png", propertyTitle = "1 Storey Home", propertyAddress = "Street 4, Block-D, Main Commercial, Lohi Beer, Soan Gardens, Islamabad", propertyPrice = "30000000" },
                new CustomSearchResultModel { imageLink = "property2.png", propertyTitle = "1 Storey Home", propertyAddress = "Street 4, Block-D, Main Commercial, Lohi Beer, Soan Gardens, Islamabad", propertyPrice = "30000000" },
                new CustomSearchResultModel { imageLink = "property1.png", propertyTitle = "1 Storey Home", propertyAddress = "Street 4, Block-D, Main Commercial, Lohi Beer, Soan Gardens, Islamabad", propertyPrice = "30000000" },
                new CustomSearchResultModel { imageLink = "property2.png", propertyTitle = "1 Storey Home", propertyAddress = "Street 4, Block-D, Main Commercial, Lohi Beer, Soan Gardens, Islamabad", propertyPrice = "30000000" },
                new CustomSearchResultModel { imageLink = "property1.png", propertyTitle = "1 Storey Home", propertyAddress = "Street 4, Block-D, Main Commercial, Lohi Beer, Soan Gardens, Islamabad", propertyPrice = "30000000" },
                new CustomSearchResultModel { imageLink = "property2.png", propertyTitle = "1 Storey Home", propertyAddress = "Street 4, Block-D, Main Commercial, Lohi Beer, Soan Gardens, Islamabad", propertyPrice = "30000000" },
                new CustomSearchResultModel { imageLink = "property1.png", propertyTitle = "1 Storey Home", propertyAddress = "Street 4, Block-D, Main Commercial, Lohi Beer, Soan Gardens, Islamabad", propertyPrice = "30000000" },
                new CustomSearchResultModel { imageLink = "property2.png", propertyTitle = "1 Storey Home", propertyAddress = "Street 4, Block-D, Main Commercial, Lohi Beer, Soan Gardens, Islamabad", propertyPrice = "30000000" }
            };
        }
    }
}
