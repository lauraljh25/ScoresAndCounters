using ScoresAndCounters.Views;

namespace ScoresAndCounters.ViewModels
{
    public class HomePageViewModel
    {
        public Command NewCounterCommand { get; private set; }
        public Command SettingsCommand { get; private set; }

        public HomePageViewModel()
        {
            ShowContineButton = false;
            NewCounterCommand = new Command(ExecuteNewCounterCommand);
            SettingsCommand = new Command(ExecuteSettingsCommand);
        }

        private async void ExecuteNewCounterCommand(object obj)
        {
            await Shell.Current.GoToAsync(nameof(CountersPage));
        }

        private async void ExecuteSettingsCommand(object obj)
        {
            await Shell.Current.GoToAsync(nameof(SettingsPage));
        }

        #region Properties

        public bool ShowContineButton { get; set; }

        #endregion
    }
}
