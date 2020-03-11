using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using XamarinFirst.Model;

namespace XamarinFirst.ViewModel
{
    class PartnersViewModel
    {
        public ObservableCollection<PartnersModel> Partners { get; set; } = new ObservableCollection<PartnersModel>();

        public PartnersViewModel()
        {
            for (int i = 0; i < 15; i++)
            {
                PartnersModel partner = new PartnersModel();
                partner.Image = "Logo.png";
                partner.Name = "Nadeem Ahmad " + i;
                partner.Designation = "Partner " + i;

                Partners.Add(partner);
            }
        }
    }
}
