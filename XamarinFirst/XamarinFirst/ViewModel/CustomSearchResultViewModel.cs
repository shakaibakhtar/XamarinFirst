using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using XamarinFirst.Model;

namespace XamarinFirst.ViewModel
{
    class CustomSearchResultViewModel
    {
        public ObservableCollection<CustomSearchResultModel> SearchResults { get; set; } = new ObservableCollection<CustomSearchResultModel>();

        public CustomSearchResultViewModel()
        {
            for (int i = 0; i < 15; i++)
            {
                CustomSearchResultModel searchResult = new CustomSearchResultModel();
                searchResult.imageLink = "property2.png";
                searchResult.propertyTitle = ((i % 2) + 1) + " Storey Home";
                searchResult.propertyAddress = "Street 4, Block-D, Main Commercial, Lohi Beer, Soan Gardens, Islamabad";
                searchResult.propertyPrice = "30,000,000 PKR";

                SearchResults.Add(searchResult);
            }
        }
    }
}
