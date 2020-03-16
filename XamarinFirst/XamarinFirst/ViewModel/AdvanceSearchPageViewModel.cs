using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace XamarinFirst.ViewModel
{
    class AdvanceSearchPageViewModel
    {
        public ObservableCollection<string> DropDownItems { get; set; } = new ObservableCollection<string>();

        public AdvanceSearchPageViewModel()
        {
            try
            {
                DropDownItems.Add("Islamabad");
                DropDownItems.Add("Lahore");
                DropDownItems.Add("Gujranwala");
                DropDownItems.Add("Gujrat");
                DropDownItems.Add("Jalalpur Jattan");
                DropDownItems.Add("Faislabad");
                DropDownItems.Add("Kharian");
                DropDownItems.Add("Sarae Alamgir");
                DropDownItems.Add("Jhelum");
                DropDownItems.Add("Dina");
                DropDownItems.Add("Mandra");
                DropDownItems.Add("Rawat");
                DropDownItems.Add("Rawalpindi");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
