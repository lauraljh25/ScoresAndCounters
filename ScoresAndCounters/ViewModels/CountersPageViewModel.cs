using ScoresAndCounters.Models;
using System.Collections.ObjectModel;

namespace ScoresAndCounters.ViewModels
{
    public class CountersPageViewModel
    {
        public ObservableCollection<CounterItemModel> CounterItemModels { get; set; }
        
        public Command AddCounterItemCommand { get; set; }
        
        public CountersPageViewModel()
        {
            CounterItemModels = new ObservableCollection<CounterItemModel>();
            AddCounterItemCommand = new Command(ExecuteAddCounterItemCommand);
        }

        private void ExecuteAddCounterItemCommand(object obj)
        {
            CounterItemModels.Add(new CounterItemModel());
        }
    }
}
