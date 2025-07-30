using ScoresAndCounters.Views;

namespace ScoresAndCounters.ViewModels
{
    public class HomePageViewModel
    {
        public Command NewCounterCommand { get; private set; }
        public HomePageViewModel()
        {
            Title = "Scores And Counters";
            NewCounterButtonLabel = "New Counter +";
            ContinueButtonLabel = "Continue";
            SettingsButtonLabel = "Settings";
            ShowContineButton = false;
            NewCounterCommand = new Command(ExecuteNewCounterCommand);
        }

        private async void ExecuteNewCounterCommand(object obj)
        {
            await Shell.Current.GoToAsync(nameof(CountersPage));
        }

        #region Properties

        public string Title { get; private set; }
        public string NewCounterButtonLabel { get; private set; }
        public string ContinueButtonLabel { get; private set; }
        public string SettingsButtonLabel { get; private set; }
        public bool ShowContineButton { get; set; }

        #endregion
    }
}
