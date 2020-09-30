using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using XamarinFirst.Model;
using XamarinFirst.View;

namespace XamarinFirst.ViewModel
{
    public class DealersViewModel:BaseViewModel
    {
        #region Properties & Variables
        INavigation navigation;
        public ObservableCollection<DealersModel> Dealers { get; set; }
        DealersModel _SelectedDealer;
        public DealersModel SelectedDealer
        {
            get
            {
                return _SelectedDealer;
            }
            set
            {
                if (value != null)
                {
                    _SelectedDealer = value;
                    navigation.PushAsync(new UserProfile());
                }

                _SelectedDealer = null;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Constructors
        public DealersViewModel(INavigation navigation)
        {
            this.navigation = navigation;
            Dealers = new ObservableCollection<DealersModel>();

            for (int i = 0; i < 15; i++)
            {
                DealersModel dealer = new DealersModel();
                dealer.Image = "dp.png";
                dealer.Name = "Shabbir Ahmad " + i;
                dealer.Designation = "Dealer " + i;

                Dealers.Add(dealer);
            }
        }
        #endregion
    }
}
