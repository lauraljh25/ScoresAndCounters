using ScoresAndCounters.Views;

namespace ScoresAndCounters.ViewModels
{
    public class HomePageViewModel
    {
        public Command NewCounterCommand { get; private set; }
        public HomePageViewModel()
        {
            ShowContineButton = false;
            NewCounterCommand = new Command(ExecuteNewCounterCommand);
        }

        private async void ExecuteNewCounterCommand(object obj)
        {
            await Shell.Current.GoToAsync(nameof(CountersPage));
        }

        #region Properties

        public bool ShowContineButton { get; set; }

        #endregion
    }
}
