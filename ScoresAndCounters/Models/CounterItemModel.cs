using ScoresAndCounters.Helpers;

namespace ScoresAndCounters.Models
{
    public class CounterItemModel
    {
        public int CounterValue { get; set; }
        public int CounterIncDec { get; set; }
        public int CounterCustomIncDec { get; set; }

        public CounterItemModel() 
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
