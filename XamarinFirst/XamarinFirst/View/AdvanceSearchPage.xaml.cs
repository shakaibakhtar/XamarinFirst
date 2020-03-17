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

        private async void BtnSearch_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CustomSearchResultPage());
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
                    var dataEmpty = vm.Cities.Where(i => i.ToLower().Contains(sender.Text.ToLower())).ToList<string>();

                    if (string.IsNullOrWhiteSpace(sender.Text))
                        sender.ItemsSource = dataEmpty;
                    else if (dataEmpty.Max().Length == 0)
                        sender.ItemsSource = dataEmpty;
                    else
                        sender.ItemsSource = vm.Cities.Where(i => i.ToLower().Contains(sender.Text.ToLower())).ToList<string>();
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

        private void listCity_TextChanged(object sender, AutoSuggestBoxTextChangedEventArgs e)
        {
            // Only get results when it was a user typing, 
            // otherwise assume the value got filled in by TextMemberPath 
            // or the handler for SuggestionChosen.
            var senderASB = (AutoSuggestBox)sender;
            if (e.Reason == AutoSuggestionBoxTextChangeReason.UserInput)
            {
                try
                {
                    var dataEmpty = vm.Cities.Where(i => i.ToLower().Contains(senderASB.Text.ToLower())).ToList<string>();

                    if (string.IsNullOrWhiteSpace(senderASB.Text))
                        senderASB.ItemsSource = dataEmpty;
                    else if (dataEmpty.Max().Length == 0)
                        senderASB.ItemsSource = dataEmpty;
                    else
                        senderASB.ItemsSource = vm.Cities.Where(i => i.ToLower().Contains(senderASB.Text.ToLower())).ToList<string>();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    senderASB.ItemsSource = null;
                }
                //sender.ItemsSource = dataset;
            }
        }
        private void listCity_QuerySubmitted(object sender, AutoSuggestBoxQuerySubmittedEventArgs e)
        {
            var senderASB = (AutoSuggestBox)sender;
            if (e.ChosenSuggestion != null)
            {
                // User selected an item from the suggestion list, take an action on it here.
            }
            else
            {
                // User hit Enter from the search box. Use args.QueryText to determine what to do.
            }
        }
        private void listCity_SuggestionChosen(object sender, AutoSuggestBoxSuggestionChosenEventArgs e)
        {
            // Set sender.Text. You can use args.SelectedItem to build your text string.
            var senderASB = (AutoSuggestBox)sender;
        }

        private void listArea_TextChanged(object sender, AutoSuggestBoxTextChangedEventArgs e)
        {
            var senderASB = (AutoSuggestBox)sender;
            if (e.Reason == AutoSuggestionBoxTextChangeReason.UserInput)
            {
                try
                {
                    var dataEmpty = vm.Areas.Where(i => i.ToLower().Contains(senderASB.Text.ToLower())).ToList<string>();

                    if (string.IsNullOrWhiteSpace(senderASB.Text))
                        senderASB.ItemsSource = dataEmpty;
                    else if (dataEmpty.Max().Length == 0)
                        senderASB.ItemsSource = dataEmpty;
                    else
                        senderASB.ItemsSource = vm.Areas.Where(i => i.ToLower().Contains(senderASB.Text.ToLower())).ToList<string>();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    senderASB.ItemsSource = null;
                }
                //sender.ItemsSource = dataset;
            }
        }
        private void listArea_QuerySubmitted(object sender, AutoSuggestBoxQuerySubmittedEventArgs e)
        {
            var senderASB = (AutoSuggestBox)sender;
            if (e.ChosenSuggestion != null)
            {
                // User selected an item from the suggestion list, take an action on it here.
            }
            else
            {
                // User hit Enter from the search box. Use args.QueryText to determine what to do.
            }
        }
        private void listArea_SuggestionChosen(object sender, AutoSuggestBoxSuggestionChosenEventArgs e)
        {
            // Set sender.Text. You can use args.SelectedItem to build your text string.
            var senderASB = (AutoSuggestBox)sender;
        }

        private void listBlock_TextChanged(object sender, AutoSuggestBoxTextChangedEventArgs e)
        {
            var senderASB = (AutoSuggestBox)sender;
            if (e.Reason == AutoSuggestionBoxTextChangeReason.UserInput)
            {
                try
                {
                    var dataEmpty = vm.Blocks.Where(i => i.ToLower().Contains(senderASB.Text.ToLower())).ToList<string>();

                    if (string.IsNullOrWhiteSpace(senderASB.Text))
                        senderASB.ItemsSource = dataEmpty;
                    else if (dataEmpty.Max().Length == 0)
                        senderASB.ItemsSource = dataEmpty;
                    else
                        senderASB.ItemsSource = vm.Blocks.Where(i => i.ToLower().Contains(senderASB.Text.ToLower())).ToList<string>();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    senderASB.ItemsSource = null;
                }
                //sender.ItemsSource = dataset;
            }
        }
        private void listBlock_QuerySubmitted(object sender, AutoSuggestBoxQuerySubmittedEventArgs e)
        {
            var senderASB = (AutoSuggestBox)sender;
            if (e.ChosenSuggestion != null)
            {
                // User selected an item from the suggestion list, take an action on it here.
            }
            else
            {
                // User hit Enter from the search box. Use args.QueryText to determine what to do.
            }
        }
        private void listBlock_SuggestionChosen(object sender, AutoSuggestBoxSuggestionChosenEventArgs e)
        {
            // Set sender.Text. You can use args.SelectedItem to build your text string.
            var senderASB = (AutoSuggestBox)sender;
        }

        private void listStreet_TextChanged(object sender, AutoSuggestBoxTextChangedEventArgs e)
        {
            var senderASB = (AutoSuggestBox)sender;
            if (e.Reason == AutoSuggestionBoxTextChangeReason.UserInput)
            {
                try
                {
                    var dataEmpty = vm.Streets.Where(i => i.ToLower().Contains(senderASB.Text.ToLower())).ToList<string>();

                    if (string.IsNullOrWhiteSpace(senderASB.Text))
                        senderASB.ItemsSource = dataEmpty;
                    else if (dataEmpty.Max().Length == 0)
                        senderASB.ItemsSource = dataEmpty;
                    else
                        senderASB.ItemsSource = vm.Streets.Where(i => i.ToLower().Contains(senderASB.Text.ToLower())).ToList<string>();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    senderASB.ItemsSource = null;
                }
                //sender.ItemsSource = dataset;
            }
        }
        private void listStreet_QuerySubmitted(object sender, AutoSuggestBoxQuerySubmittedEventArgs e)
        {
            var senderASB = (AutoSuggestBox)sender;
            if (e.ChosenSuggestion != null)
            {
                // User selected an item from the suggestion list, take an action on it here.
            }
            else
            {
                // User hit Enter from the search box. Use args.QueryText to determine what to do.
            }
        }
        private void listStreet_SuggestionChosen(object sender, AutoSuggestBoxSuggestionChosenEventArgs e)
        {
            // Set sender.Text. You can use args.SelectedItem to build your text string.
            var senderASB = (AutoSuggestBox)sender;
        }

        private void listPlot_TextChanged(object sender, AutoSuggestBoxTextChangedEventArgs e)
        {
            var senderASB = (AutoSuggestBox)sender;
            if (e.Reason == AutoSuggestionBoxTextChangeReason.UserInput)
            {
                try
                {
                    var dataEmpty = vm.Plots.Where(i => i.ToLower().Contains(senderASB.Text.ToLower())).ToList<string>();

                    if (string.IsNullOrWhiteSpace(senderASB.Text))
                        senderASB.ItemsSource = dataEmpty;
                    else if (dataEmpty.Max().Length == 0)
                        senderASB.ItemsSource = dataEmpty;
                    else
                        senderASB.ItemsSource = vm.Plots.Where(i => i.ToLower().Contains(senderASB.Text.ToLower())).ToList<string>();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    senderASB.ItemsSource = null;
                }
                //sender.ItemsSource = dataset;
            }
        }
        private void listPlot_QuerySubmitted(object sender, AutoSuggestBoxQuerySubmittedEventArgs e)
        {
            var senderASB = (AutoSuggestBox)sender;
            if (e.ChosenSuggestion != null)
            {
                // User selected an item from the suggestion list, take an action on it here.
            }
            else
            {
                // User hit Enter from the search box. Use args.QueryText to determine what to do.
            }
        }
        private void listPlot_SuggestionChosen(object sender, AutoSuggestBoxSuggestionChosenEventArgs e)
        {
            // Set sender.Text. You can use args.SelectedItem to build your text string.
            var senderASB = (AutoSuggestBox)sender;
        }

        private void listPropertyType_TextChanged(object sender, AutoSuggestBoxTextChangedEventArgs e)
        {
            var senderASB = (AutoSuggestBox)sender;
            if (e.Reason == AutoSuggestionBoxTextChangeReason.UserInput)
            {
                try
                {
                    var dataEmpty = vm.PropertyTypes.Where(i => i.ToLower().Contains(senderASB.Text.ToLower())).ToList<string>();

                    if (string.IsNullOrWhiteSpace(senderASB.Text))
                        senderASB.ItemsSource = dataEmpty;
                    else if (dataEmpty.Max().Length == 0)
                        senderASB.ItemsSource = dataEmpty;
                    else
                        senderASB.ItemsSource = vm.PropertyTypes.Where(i => i.ToLower().Contains(senderASB.Text.ToLower())).ToList<string>();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    senderASB.ItemsSource = null;
                }
                //sender.ItemsSource = dataset;
            }
        }
        private void listPropertyType_QuerySubmitted(object sender, AutoSuggestBoxQuerySubmittedEventArgs e)
        {
            var senderASB = (AutoSuggestBox)sender;
            if (e.ChosenSuggestion != null)
            {
                // User selected an item from the suggestion list, take an action on it here.
            }
            else
            {
                // User hit Enter from the search box. Use args.QueryText to determine what to do.
            }
        }
        private void listPropertyType_SuggestionChosen(object sender, AutoSuggestBoxSuggestionChosenEventArgs e)
        {
            // Set sender.Text. You can use args.SelectedItem to build your text string.
            var senderASB = (AutoSuggestBox)sender;
        }

        private void listPropertyStatus_TextChanged(object sender, AutoSuggestBoxTextChangedEventArgs e)
        {
            var senderASB = (AutoSuggestBox)sender;
            if (e.Reason == AutoSuggestionBoxTextChangeReason.UserInput)
            {
                try
                {
                    var dataEmpty = vm.PropertyStatus.Where(i => i.ToLower().Contains(senderASB.Text.ToLower())).ToList<string>();

                    if (string.IsNullOrWhiteSpace(senderASB.Text))
                        senderASB.ItemsSource = dataEmpty;
                    else if (dataEmpty.Max().Length == 0)
                        senderASB.ItemsSource = dataEmpty;
                    else
                        senderASB.ItemsSource = vm.PropertyStatus.Where(i => i.ToLower().Contains(senderASB.Text.ToLower())).ToList<string>();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    senderASB.ItemsSource = null;
                }
                //sender.ItemsSource = dataset;
            }
        }
        private void listPropertyStatus_QuerySubmitted(object sender, AutoSuggestBoxQuerySubmittedEventArgs e)
        {
            var senderASB = (AutoSuggestBox)sender;
            if (e.ChosenSuggestion != null)
            {
                // User selected an item from the suggestion list, take an action on it here.
            }
            else
            {
                // User hit Enter from the search box. Use args.QueryText to determine what to do.
            }
        }
        private void listPropertyStatus_SuggestionChosen(object sender, AutoSuggestBoxSuggestionChosenEventArgs e)
        {
            // Set sender.Text. You can use args.SelectedItem to build your text string.
            var senderASB = (AutoSuggestBox)sender;
        }

        private void listPropertySpecifications_TextChanged(object sender, AutoSuggestBoxTextChangedEventArgs e)
        {
            var senderASB = (AutoSuggestBox)sender;
            if (e.Reason == AutoSuggestionBoxTextChangeReason.UserInput)
            {
                try
                {
                    var dataEmpty = vm.PropertySpecifications.Where(i => i.ToLower().Contains(senderASB.Text.ToLower())).ToList<string>();

                    if (string.IsNullOrWhiteSpace(senderASB.Text))
                        senderASB.ItemsSource = dataEmpty;
                    else if (dataEmpty.Max().Length == 0)
                        senderASB.ItemsSource = dataEmpty;
                    else
                        senderASB.ItemsSource = vm.PropertySpecifications.Where(i => i.ToLower().Contains(senderASB.Text.ToLower())).ToList<string>();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    senderASB.ItemsSource = null;
                }
                //sender.ItemsSource = dataset;
            }
        }
        private void listPropertySpecifications_QuerySubmitted(object sender, AutoSuggestBoxQuerySubmittedEventArgs e)
        {
            var senderASB = (AutoSuggestBox)sender;
            if (e.ChosenSuggestion != null)
            {
                // User selected an item from the suggestion list, take an action on it here.
            }
            else
            {
                // User hit Enter from the search box. Use args.QueryText to determine what to do.
            }
        }
        private void listPropertySpecifications_SuggestionChosen(object sender, AutoSuggestBoxSuggestionChosenEventArgs e)
        {
            // Set sender.Text. You can use args.SelectedItem to build your text string.
            var senderASB = (AutoSuggestBox)sender;
        }

        private void listOwners_TextChanged(object sender, AutoSuggestBoxTextChangedEventArgs e)
        {
            var senderASB = (AutoSuggestBox)sender;
            if (e.Reason == AutoSuggestionBoxTextChangeReason.UserInput)
            {
                try
                {
                    var dataEmpty = vm.Owners.Where(i => i.ToLower().Contains(senderASB.Text.ToLower())).ToList<string>();

                    if (string.IsNullOrWhiteSpace(senderASB.Text))
                        senderASB.ItemsSource = dataEmpty;
                    else if (dataEmpty.Max().Length == 0)
                        senderASB.ItemsSource = dataEmpty;
                    else
                        senderASB.ItemsSource = vm.Owners.Where(i => i.ToLower().Contains(senderASB.Text.ToLower())).ToList<string>();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    senderASB.ItemsSource = null;
                }
                //sender.ItemsSource = dataset;
            }
        }
        private void listOwners_QuerySubmitted(object sender, AutoSuggestBoxQuerySubmittedEventArgs e)
        {
            var senderASB = (AutoSuggestBox)sender;
            if (e.ChosenSuggestion != null)
            {
                // User selected an item from the suggestion list, take an action on it here.
            }
            else
            {
                // User hit Enter from the search box. Use args.QueryText to determine what to do.
            }
        }
        private void listOwners_SuggestionChosen(object sender, AutoSuggestBoxSuggestionChosenEventArgs e)
        {
            // Set sender.Text. You can use args.SelectedItem to build your text string.
            var senderASB = (AutoSuggestBox)sender;
        }

        private void listBuyers_TextChanged(object sender, AutoSuggestBoxTextChangedEventArgs e)
        {
            var senderASB = (AutoSuggestBox)sender;
            if (e.Reason == AutoSuggestionBoxTextChangeReason.UserInput)
            {
                try
                {
                    var dataEmpty = vm.Buyers.Where(i => i.ToLower().Contains(senderASB.Text.ToLower())).ToList<string>();

                    if (string.IsNullOrWhiteSpace(senderASB.Text))
                        senderASB.ItemsSource = dataEmpty;
                    else if (dataEmpty.Max().Length == 0)
                        senderASB.ItemsSource = dataEmpty;
                    else
                        senderASB.ItemsSource = vm.Buyers.Where(i => i.ToLower().Contains(senderASB.Text.ToLower())).ToList<string>();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    senderASB.ItemsSource = null;
                }
                //sender.ItemsSource = dataset;
            }
        }
        private void listBuyers_QuerySubmitted(object sender, AutoSuggestBoxQuerySubmittedEventArgs e)
        {
            var senderASB = (AutoSuggestBox)sender;
            if (e.ChosenSuggestion != null)
            {
                // User selected an item from the suggestion list, take an action on it here.
            }
            else
            {
                // User hit Enter from the search box. Use args.QueryText to determine what to do.
            }
        }
        private void listBuyers_SuggestionChosen(object sender, AutoSuggestBoxSuggestionChosenEventArgs e)
        {
            // Set sender.Text. You can use args.SelectedItem to build your text string.
            var senderASB = (AutoSuggestBox)sender;
        }

        private void listSizeUnits_TextChanged(object sender, AutoSuggestBoxTextChangedEventArgs e)
        {
            var senderASB = (AutoSuggestBox)sender;
            if (e.Reason == AutoSuggestionBoxTextChangeReason.UserInput)
            {
                try
                {
                    var dataEmpty = vm.SizeUnits.Where(i => i.ToLower().Contains(senderASB.Text.ToLower())).ToList<string>();

                    if (string.IsNullOrWhiteSpace(senderASB.Text))
                        senderASB.ItemsSource = dataEmpty;
                    else if (dataEmpty.Max().Length == 0)
                        senderASB.ItemsSource = dataEmpty;
                    else
                        senderASB.ItemsSource = vm.SizeUnits.Where(i => i.ToLower().Contains(senderASB.Text.ToLower())).ToList<string>();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    senderASB.ItemsSource = null;
                }
                //sender.ItemsSource = dataset;
            }
        }
        private void listSizeUnits_QuerySubmitted(object sender, AutoSuggestBoxQuerySubmittedEventArgs e)
        {
            var senderASB = (AutoSuggestBox)sender;
            if (e.ChosenSuggestion != null)
            {
                // User selected an item from the suggestion list, take an action on it here.
            }
            else
            {
                // User hit Enter from the search box. Use args.QueryText to determine what to do.
            }
        }
        private void listSizeUnits_SuggestionChosen(object sender, AutoSuggestBoxSuggestionChosenEventArgs e)
        {
            // Set sender.Text. You can use args.SelectedItem to build your text string.
            var senderASB = (AutoSuggestBox)sender;
        }

        private void listCurrencies_TextChanged(object sender, AutoSuggestBoxTextChangedEventArgs e)
        {
            var senderASB = (AutoSuggestBox)sender;
            if (e.Reason == AutoSuggestionBoxTextChangeReason.UserInput)
            {
                try
                {
                    var dataEmpty = vm.Currencies.Where(i => i.ToLower().Contains(senderASB.Text.ToLower())).ToList<string>();

                    if (string.IsNullOrWhiteSpace(senderASB.Text))
                        senderASB.ItemsSource = dataEmpty;
                    else if (dataEmpty.Max().Length == 0)
                        senderASB.ItemsSource = dataEmpty;
                    else
                        senderASB.ItemsSource = vm.Currencies.Where(i => i.ToLower().Contains(senderASB.Text.ToLower())).ToList<string>();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    senderASB.ItemsSource = null;
                }
                //sender.ItemsSource = dataset;
            }
        }
        private void listCurrencies_QuerySubmitted(object sender, AutoSuggestBoxQuerySubmittedEventArgs e)
        {
            var senderASB = (AutoSuggestBox)sender;
            if (e.ChosenSuggestion != null)
            {
                // User selected an item from the suggestion list, take an action on it here.
            }
            else
            {
                // User hit Enter from the search box. Use args.QueryText to determine what to do.
            }
        }
        private void listCurrencies_SuggestionChosen(object sender, AutoSuggestBoxSuggestionChosenEventArgs e)
        {
            // Set sender.Text. You can use args.SelectedItem to build your text string.
            var senderASB = (AutoSuggestBox)sender;
        }
    }
}