using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using XamarinFirst.Model;
using XamarinFirst.View;

namespace XamarinFirst.ViewModel
{
    public class PartnersViewModel : BaseViewModel
    {
        #region Properties & Variables
        INavigation navigation;
        public ObservableCollection<PartnersModel> Partners { get; set; }
        PartnersModel _SelectedPartner;
        public PartnersModel SelectedPartner
        {
            get
            {
                return _SelectedPartner;
            }
            set
            {
                if (value != null)
                {
                    _SelectedPartner = value;
                    navigation.PushAsync(new UserProfile());
                }

                _SelectedPartner = null;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Constructors
        public PartnersViewModel(INavigation navigation)
        {
            this.navigation = navigation;

            Partners = new ObservableCollection<PartnersModel>();

            for (int i = 0; i < 15; i++)
            {
                PartnersModel partner = new PartnersModel();
                partner.Image = "dp.png";
                partner.Name = "Nadeem Ahmad " + i;
                partner.Designation = "+9231234567" + i;

                Partners.Add(partner);
            }
        }
        #endregion
    }
}
