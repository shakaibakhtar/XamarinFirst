using dotMorten.Xamarin.Forms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFirst.ViewModel;

namespace XamarinFirst.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AdvanceSearchPage : ContentPage
    {
        AdvanceSearchPageViewModel vm = new AdvanceSearchPageViewModel();
        public AdvanceSearchPage()
        {
            InitializeComponent();
            // downarrow.ges
        }

        private void AutoSuggestBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            // Only get results when it was a user typing, 
            // otherwise assume the value got filled in by TextMemberPath 
            // or the handler for SuggestionChosen.
            if (args.Reason == AutoSuggestionBoxTextChangeReason.UserInput)
            {
                try
                {

                    var dataEmpty = vm.DropDownItems.Where(i => i.ToLower().Contains(sender.Text.ToLower())).ToList<string>();

                    if (string.IsNullOrWhiteSpace(sender.Text))
                        sender.ItemsSource = dataEmpty;
                    else if (dataEmpty.Max().Length == 0)
                        sender.ItemsSource = dataEmpty;
                    else
                        sender.ItemsSource = vm.DropDownItems.Where(i => i.ToLower().Contains(sender.Text.ToLower())).ToList<string>();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    sender.ItemsSource = null;
                }
                //sender.ItemsSource = dataset;
            }
        }


        private void AutoSuggestBox_SuggestionChosen(AutoSuggestBox sender, AutoSuggestBoxSuggestionChosenEventArgs args)
        {
            // Set sender.Text. You can use args.SelectedItem to build your text string.
        }


        private void AutoSuggestBox_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        {
            if (args.ChosenSuggestion != null)
            {
                // User selected an item from the suggestion list, take an action on it here.
            }
            else
            {
                // User hit Enter from the search box. Use args.QueryText to determine what to do.
            }
        }

        private void ShowAdvanceSearchView(object sender, EventArgs e)
        {
            AdvancedSearchView.IsVisible = !AdvancedSearchView.IsVisible;

            if (AdvancedSearchView.IsVisible)
            {
                lblExpandForm.Text = "Hide Advanced Search";
            }
            else
            {
                lblExpandForm.Text = "Show Advanced Search";
            }
        }

        private void BtnSearch_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Notification", "Search Logic Here", "OK");
        }

        //private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        //{

        //    try
        //    {

        //        var dataEmpty = vm.DropDownItems.Where(i => i.ToLower().Contains(list.Text.ToLower())).ToList<string>();

        //        if (string.IsNullOrWhiteSpace(list.Text))
        //            list.ItemsSource = dataEmpty;
        //        else if (dataEmpty.Max().Length == 0)
        //            list.ItemsSource = dataEmpty;
        //        else
        //            list.ItemsSource = vm.DropDownItems.Where(i => i.ToLower().Contains(list.Text.ToLower())).ToList<string>();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        list.ItemsSource = null;
        //    }
        //}

        //public async void ListOfStore() //List of Countries  
        //{
        //    try
        //    {
        //        data.Add("Afghanistan");
        //        data.Add("Austria");
        //        data.Add("Australia");
        //        data.Add("Azerbaijan");
        //        data.Add("Bahrain");
        //        data.Add("Bangladesh");
        //        data.Add("Belgium");
        //        data.Add("Botswana");
        //        data.Add("China");
        //        data.Add("Colombia");
        //        data.Add("Denmark");
        //        data.Add("Kmart");
        //        data.Add("Pakistan");
        //    }
        //    catch (Exception ex)
        //    {
        //        await DisplayAlert("", "" + ex, "Ok");
        //    }
        //}


    }
}