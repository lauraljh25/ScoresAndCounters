using CommunityToolkit.Mvvm.ComponentModel;
using ScoresAndCounters.Helpers;

namespace ScoresAndCounters.ViewModels.CollectionViewModels
{
    public class CounterItemViewModel: ObservableObject
    {
        private int _counterValue;
        public int CounterValue 
        {
            get => _counterValue;
            set => SetProperty(ref _counterValue, value);
        }
        public int CounterIncDec { get; set; }
        public int CounterCustomIncDec { get; set; }

        public Command IncrementCounterItemCommand { get; private set; }
        public Command DecrementCounterItemCommand { get; private set; }

        public CounterItemViewModel() 
        {
            CounterValue = AppConstants.InitialCounterValue;
            CounterIncDec = AppConstants.CounterIncDec;

            IncrementCounterItemCommand = new Command(ExecuteIncrementCounterItemCommand);
            DecrementCounterItemCommand = new Command(ExecuteDecrementCounterItemCommand);
        }

        private void ExecuteIncrementCounterItemCommand()
        {
            CounterValue += CounterIncDec;
        }

        private void ExecuteDecrementCounterItemCommand()
        {
            CounterValue -= CounterIncDec;
        }
    }
}
