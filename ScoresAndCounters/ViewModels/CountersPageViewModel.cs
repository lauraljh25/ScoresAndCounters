using CommunityToolkit.Mvvm.ComponentModel;
using ScoresAndCounters.Models;
using System.Collections.ObjectModel;

namespace ScoresAndCounters.ViewModels
{
    public class CountersPageViewModel : ObservableObject
    {
        public ObservableCollection<CounterItemModel> CounterItems { get; set; }
        
        public Command AddCounterItemCommand { get; private set; }
        
        public CountersPageViewModel()
        {
            CounterItems = new ObservableCollection<CounterItemModel>();
            AddCounterItemCommand = new Command(ExecuteAddCounterItemCommand);
        }

        private void ExecuteAddCounterItemCommand(object obj)
        {
            CounterItems.Add(new CounterItemModel());
            OnPropertyChanged(nameof(CounterItems));
        }
    }
}
