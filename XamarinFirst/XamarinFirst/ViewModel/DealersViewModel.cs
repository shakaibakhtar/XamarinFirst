using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using XamarinFirst.Model;

namespace XamarinFirst.ViewModel
{
    class DealersViewModel
    {
        public ObservableCollection<DealersModel> Dealers { get; set; } = new ObservableCollection<DealersModel>();

        public DealersViewModel()
        {
            for (int i = 0; i < 15; i++)
            {
                DealersModel dealer = new DealersModel();
                dealer.Image = "Logo.png";
                dealer.Name = "Shabbir Ahmad " + i;
                dealer.Designation = "Dealer " + i;

                Dealers.Add(dealer);
            }
        }
    }
}
