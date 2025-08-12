using CommunityToolkit.Mvvm.ComponentModel;
using ScoresAndCounters.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ScoresAndCounters.ViewModels
{
    public class CountersPageViewModel : ObservableObject
    {
        public ObservableCollection<CounterItemModel> CounterItems { get; set; }
        
        public Command AddCounterItemCommand { get; private set; }
        public Command IncrementCounterItemCommand { get; private set; }
        public Command DecrementCounterItemCommand { get; private set; }
        public Command RemoveCounterItemCommand { get; private set; }

        public CountersPageViewModel()
        {
            CounterItems = new ObservableCollection<CounterItemModel>();
            AddCounterItemCommand = new Command(ExecuteAddCounterItemCommand);
            IncrementCounterItemCommand = new Command<CounterItemModel>(ExecuteIncrementCounterItemCommand);
            DecrementCounterItemCommand = new Command<CounterItemModel>(ExecuteDecrementCounterItemCommand);
            RemoveCounterItemCommand = new Command<CounterItemModel>(ExecuteRemoveCounterItemCommand);
        }

        private void ExecuteAddCounterItemCommand(object obj)
        {
            CounterItems.Add(new CounterItemModel());
            OnPropertyChanged(nameof(CounterItems));
        }

        private void ExecuteIncrementCounterItemCommand(CounterItemModel counterItem)
        {
            counterItem.Increment();
        }

        private void ExecuteDecrementCounterItemCommand(CounterItemModel counterItem)
        {
            counterItem.Decrement();
        }

        private void ExecuteRemoveCounterItemCommand(CounterItemModel counterItem)
        {
            CounterItems.Remove(counterItem);
            OnPropertyChanged(nameof(CounterItems));
        }
    }
}
