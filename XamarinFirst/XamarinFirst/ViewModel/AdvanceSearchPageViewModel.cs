using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace XamarinFirst.ViewModel
{
    class AdvanceSearchPageViewModel
    {
        public ObservableCollection<string> Cities { get; set; } = new ObservableCollection<string>();
        public ObservableCollection<string> Areas { get; set; } = new ObservableCollection<string>();
        public ObservableCollection<string> Blocks { get; set; } = new ObservableCollection<string>();
        public ObservableCollection<string> Streets { get; set; } = new ObservableCollection<string>();
        public ObservableCollection<string> Plots { get; set; } = new ObservableCollection<string>();
        public ObservableCollection<string> PropertyTypes { get; set; } = new ObservableCollection<string>();
        public ObservableCollection<string> PropertyStatus { get; set; } = new ObservableCollection<string>();
        public ObservableCollection<string> PropertySpecifications { get; set; } = new ObservableCollection<string>();
        public ObservableCollection<string> Owners { get; set; } = new ObservableCollection<string>();
        public ObservableCollection<string> Buyers { get; set; } = new ObservableCollection<string>();
        public ObservableCollection<string> SizeUnits { get; set; } = new ObservableCollection<string>();
        public ObservableCollection<string> Currencies { get; set; } = new ObservableCollection<string>();

        public AdvanceSearchPageViewModel()
        {
            FetchCities();
            FetchAreas();
            FetchBlocks();
            FetchStreets();
            FetchPlots();
            FetchPropertyTypes();
            FetchPropertyStatuses();
            FetchOwners();
            FetchBuyers();
            FetchPropertySpecifications();
            FetchSizeUnits();
            FetchCurrencies();
        }


        private void FetchCities()
        {
            try
            {
                Cities.Add("Islamabad");
                Cities.Add("Lahore");
                Cities.Add("Gujranwala");
                Cities.Add("Gujrat");
                Cities.Add("Jalalpur Jattan");
                Cities.Add("Faislabad");
                Cities.Add("Kharian");
                Cities.Add("Sarae Alamgir");
                Cities.Add("Jhelum");
                Cities.Add("Dina");
                Cities.Add("Mandra");
                Cities.Add("Rawat");
                Cities.Add("Rawalpindi");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void FetchAreas()
        {
            try
            {
                Areas.Add("Soan Gardens");
                Areas.Add("PWD");
                Areas.Add("Agochs");
                Areas.Add("DHA");
                Areas.Add("Bahria Town");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void FetchBlocks()
        {
            try
            {
                Blocks.Add("Block-A");
                Blocks.Add("Block-B");
                Blocks.Add("Block-C");
                Blocks.Add("Block-E");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void FetchStreets()
        {
            try
            {
                Streets.Add("Street 1");
                Streets.Add("Street 2");
                Streets.Add("Street 3");
                Streets.Add("Street 4");
                Streets.Add("Street 5");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void FetchPlots()
        {
            try
            {
                Plots.Add("1A");
                Plots.Add("45A");
                Plots.Add("42C");
                Plots.Add("99");
                Plots.Add("405");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void FetchPropertyTypes()
        {
            try
            {
                PropertyTypes.Add("Residential");
                PropertyTypes.Add("Commercial");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void FetchPropertyStatuses()
        {
            try
            {
                PropertyStatus.Add("Sold");
                PropertyStatus.Add("Unsold");
                PropertyStatus.Add("Pending");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void FetchPropertySpecifications()
        {
            try
            {
                PropertySpecifications.Add("Bathroom");
                PropertySpecifications.Add("Bedroom");
                PropertySpecifications.Add("Parking");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void FetchOwners()
        {
            try
            {
                Owners.Add("Fahad Nouman");
                Owners.Add("Khawar Mehdi");
                Owners.Add("Babar Javed");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void FetchBuyers()
        {
            try
            {
                Buyers.Add("Fahad Nouman");
                Buyers.Add("Khawar Mehdi");
                Buyers.Add("Muhammad Awais");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void FetchSizeUnits()
        {
            try
            {
                SizeUnits.Add("Marla");
                SizeUnits.Add("Sq Ft");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void FetchCurrencies()
        {
            try
            {
                Currencies.Add("PKR");
                Currencies.Add("$");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
