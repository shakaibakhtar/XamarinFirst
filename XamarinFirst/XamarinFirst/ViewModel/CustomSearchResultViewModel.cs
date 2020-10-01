using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using XamarinFirst.Model;
using XamarinFirst.View;

namespace XamarinFirst.ViewModel
{
    public class CustomSearchResultViewModel:BaseViewModel
    {
        INavigation navigation;
        public ObservableCollection<CustomSearchResultModel> SearchResults { get; set; }

        CustomSearchResultModel _SelectedProperty;
        public CustomSearchResultModel SelectedProperty
        {
            get
            {
                return _SelectedProperty;
            }
            set
            {
                if(value != null)
                {
                    _SelectedProperty = value;
                    navigation.PushAsync(new PropertyDetailPage());
                }

                _SelectedProperty = null;
                OnPropertyChanged();
            }
        }

        public CustomSearchResultViewModel(INavigation navigation)
        {
            this.navigation = navigation;

            SearchResults = new ObservableCollection<CustomSearchResultModel>();

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
