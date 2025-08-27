using CommunityToolkit.Mvvm.ComponentModel;
using ScoresAndCounters.Helpers;

namespace ScoresAndCounters.ViewModels.CollectionViewModels
{
    public class CounterItemViewModel: ObservableObject
    {
        public Command IncrementCounterItemCommand { get; private set; }
        public Command DecrementCounterItemCommand { get; private set; }

        public CounterItemViewModel(IPreferencesHelper preferencesHelper) 
        {
            CounterValue = AppConstants.InitialCounterValue;
            CounterIncDec = AppConstants.CounterIncDec;

            CounterCustomIncDec1 = preferencesHelper.GetCustomIncDecValue1();
            CounterCustomIncDec2 = preferencesHelper.GetCustomIncDecValue2();

            ButtonLabelCustomInc1 = string.Format(ResourceLibrary.ValuePlus, CounterCustomIncDec1);
            ButtonLabelCustomInc2 = string.Format(ResourceLibrary.ValuePlus, CounterCustomIncDec2);

            ButtonLabelCustomDec1 = string.Format(ResourceLibrary.ValueMinus, CounterCustomIncDec1);
            ButtonLabelCustomDec2 = string.Format(ResourceLibrary.ValueMinus, CounterCustomIncDec2);

            IncrementCounterItemCommand = new Command<int>(ExecuteIncrementCounterItemCommand);
            DecrementCounterItemCommand = new Command<int>(ExecuteDecrementCounterItemCommand);
        }

        private void ExecuteIncrementCounterItemCommand(int increment)
        {
            CounterValue += increment;
        }

        private void ExecuteDecrementCounterItemCommand(int decrement)
        {
            CounterValue -= decrement;
        }

        #region Properties

        private int _counterValue;
        public int CounterValue
        {
            get => _counterValue;
            set => SetProperty(ref _counterValue, value);
        }

        public int CounterIncDec { get; private set; }
        public int CounterCustomIncDec1 { get; private set; }
        public int CounterCustomIncDec2 { get; private set; }
        public string ButtonLabelCustomInc1 { get; private set; }
        public string ButtonLabelCustomInc2 { get; private set; }
        public string ButtonLabelCustomDec1 { get; private set; }
        public string ButtonLabelCustomDec2 { get; private set; }

        #endregion
    }
}
