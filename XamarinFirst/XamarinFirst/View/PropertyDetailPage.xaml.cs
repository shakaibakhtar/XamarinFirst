using CarouselView.FormsPlugin.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFirst.Model;

namespace XamarinFirst.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PropertyDetailPage : ContentPage
    {
        public PropertyDetailPage()
        {
            InitializeComponent();

            var tutorials = new List<PropertyModel>
            {
                new PropertyModel("welcome.png", "Commercial", "Available"),
                new PropertyModel("welcome2.png", "Commercial", "Available"),
                new PropertyModel("welcome3.png", "Commercial", "Unavailable")
            };

            //  myCarousel.ItemsSource = new ObservableCollection<int> { 1, 2, 3, 4, 5 }; // ADD/REMOVE PAGES FROM CAROUSEL ADDING/REMOVING ELEMENTS FROM THE COLLECTION
            //myCarousel.ItemTemplate = new DataTemplate (typeof(MyView));
            myCarousel.ItemsSource = tutorials;
            myCarousel.Position = 0; //default
            myCarousel.InterPageSpacing = 10;
            myCarousel.Orientation = CarouselViewOrientation.Horizontal;
            myCarousel.ShowIndicators = true;
            myCarousel.CurrentPageIndicatorTintColor = Color.FromHex("#0073E0");
            myCarousel.PositionSelected += MyCarousel_PositionSelected;
        }

        private void MyCarousel_PositionSelected(object sender, PositionSelectedEventArgs e)
        {
            if (myCarousel.Position == 2)
            {
                //GetStartedButton.IsVisible = true;
                //NextButton.IsVisible = false;
                // BackButton.IsVisible = true;
            }
            else if (myCarousel.Position == 0)
            {
                //BackButton.IsVisible = false;
            }
            else
            {
                // NextButton.IsVisible = true;
                //BtnBack.IsVisible = true;


            }
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            if (myCarousel.Position > 0)
            {
                myCarousel.Position = myCarousel.Position - 1;
            }

        }

        void Handle_Clicked_1(object sender, System.EventArgs e)
        {
            if (myCarousel.Position < 2)
            {
                myCarousel.Position += 1;
            }

        }
        //void GetStarted_Click(object sender, System.EventArgs e)
        //{

        //}

        void PositionChanged(object sender, CarouselView.FormsPlugin.Abstractions.PositionSelectedEventArgs e)
        {


        }
    }
}