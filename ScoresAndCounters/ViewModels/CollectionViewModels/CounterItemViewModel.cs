using ScoresAndCounters.Helpers;

namespace ScoresAndCounters.ViewModels.CollectionViewModels
{
    public class CounterItemViewModel
    {
        public int CounterValue { get; set; }
        public int CounterIncDec { get; set; }
        public int CounterCustomIncDec { get; set; }

        public CounterItemViewModel() 
        {
            CounterValue = AppConstants.InitialCounterValue;
            CounterIncDec = AppConstants.CounterIncDec;
        }

        public void Increment()
        {
            CounterValue += CounterIncDec;
        }

        public void Decrement()
        {
            CounterValue -= CounterIncDec;
        }
    }
}
