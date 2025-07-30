using ScoresAndCounters.Helpers;

namespace ScoresAndCounters.Models
{
    public class CounterItemModel
    {
        public int CounterValue { get; set; }
        public int CounterCustomIncDec { get; set; }

        public CounterItemModel() 
        {
            CounterValue = AppConstants.InitialCounterValue;
        }
    }
}
