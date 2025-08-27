using ScoresAndCounters.ViewModels;

namespace ScoresAndCounters.Views;

public partial class SettingsPage : ContentPage
{
	public SettingsPage(SettingsPageViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}