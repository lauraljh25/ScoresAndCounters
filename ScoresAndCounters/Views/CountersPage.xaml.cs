using ScoresAndCounters.ViewModels;

namespace ScoresAndCounters.Views;

public partial class CountersPage : ContentPage
{
	public CountersPage(CountersPageViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}