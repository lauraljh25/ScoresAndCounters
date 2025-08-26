using CommunityToolkit.Mvvm.ComponentModel;
using ScoresAndCounters.Helpers;
using ScoresAndCounters.ViewModels.CollectionViewModels;
using System.Collections.ObjectModel;

namespace ScoresAndCounters.ViewModels
{
    public class CountersPageViewModel : ObservableObject
    {
        public ObservableCollection<CounterItemViewModel> CounterItems { get; set; }
        
        public Command AddCounterItemCommand { get; private set; }
        public Command RemoveCounterItemCommand { get; private set; }

        public CountersPageViewModel()
        {
            CounterItems = new ObservableCollection<CounterItemViewModel>();
            AddCounterItemCommand = new Command(ExecuteAddCounterItemCommand);
            RemoveCounterItemCommand = new Command<CounterItemViewModel>(ExecuteRemoveCounterItemCommand);
        }

        private void ExecuteAddCounterItemCommand(object obj)
        {
            if (CounterItems.Count < AppConstants.MaxNumberOfCounters)
            {
                CounterItems.Add(new CounterItemViewModel());
                OnPropertyChanged(nameof(CounterItems));
            }
        }

        private void ExecuteRemoveCounterItemCommand(CounterItemViewModel counterItem)
        {
            CounterItems.Remove(counterItem);
            OnPropertyChanged(nameof(CounterItems));
        }
    }
}
