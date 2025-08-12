using CommunityToolkit.Mvvm.ComponentModel;
using ScoresAndCounters.ViewModels.CollectionViewModels;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ScoresAndCounters.ViewModels
{
    public class CountersPageViewModel : ObservableObject
    {
        public ObservableCollection<CounterItemViewModel> CounterItems { get; set; }
        
        public Command AddCounterItemCommand { get; private set; }
        public Command IncrementCounterItemCommand { get; private set; }
        public Command DecrementCounterItemCommand { get; private set; }
        public Command RemoveCounterItemCommand { get; private set; }

        public CountersPageViewModel()
        {
            CounterItems = new ObservableCollection<CounterItemViewModel>();
            AddCounterItemCommand = new Command(ExecuteAddCounterItemCommand);
            IncrementCounterItemCommand = new Command<CounterItemViewModel>(ExecuteIncrementCounterItemCommand);
            DecrementCounterItemCommand = new Command<CounterItemViewModel>(ExecuteDecrementCounterItemCommand);
            RemoveCounterItemCommand = new Command<CounterItemViewModel>(ExecuteRemoveCounterItemCommand);
        }

        private void ExecuteAddCounterItemCommand(object obj)
        {
            CounterItems.Add(new CounterItemViewModel());
            OnPropertyChanged(nameof(CounterItems));
        }

        private void ExecuteIncrementCounterItemCommand(CounterItemViewModel counterItem)
        {
            counterItem.Increment();
        }

        private void ExecuteDecrementCounterItemCommand(CounterItemViewModel counterItem)
        {
            counterItem.Decrement();
        }

        private void ExecuteRemoveCounterItemCommand(CounterItemViewModel counterItem)
        {
            CounterItems.Remove(counterItem);
            OnPropertyChanged(nameof(CounterItems));
        }
    }
}
