using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFirst.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DashboardMaster : ContentPage
    {
        //public ListView ListView;
        
        public DashboardMaster()
        {
            InitializeComponent();
            //this.BindingContext = new DashboardMasterViewModel();
            //ListView = MenuItemsListView;
        }

        //class DashboardMasterViewModel : INotifyPropertyChanged
        //{
        //    public ObservableCollection<DashboardMasterMenuItem> MenuItems { get; set; }

        //    public DashboardMasterViewModel()
        //    {
        //        MenuItems = new ObservableCollection<DashboardMasterMenuItem>(new[]
        //        {
        //            new DashboardMasterMenuItem { Id = 0, Title = "Properties" },
        //            new DashboardMasterMenuItem { Id = 1, Title = "Partners" },
        //            new DashboardMasterMenuItem { Id = 2, Title = "Dealers" },
        //            new DashboardMasterMenuItem { Id = 3, Title = "Transactions" },
        //            new DashboardMasterMenuItem { Id = 4, Title = "Advance Search" },
        //            new DashboardMasterMenuItem { Id = 5, Title = "Settings" },
        //        });
        //    }

        //    #region INotifyPropertyChanged Implementation
        //    public event PropertyChangedEventHandler PropertyChanged;
        //    void OnPropertyChanged([CallerMemberName] string propertyName = "")
        //    {
        //        if (PropertyChanged == null)
        //            return;

        //        PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //    }
        //    #endregion
        //}

        //private void ProfilePicture_Tapped(object sender, EventArgs e)
        //{
        //    Navigation.PopToRootAsync();
        //    Navigation.PushAsync(new UserProfile());
        //}
    }
}