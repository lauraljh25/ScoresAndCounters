using CommunityToolkit.Mvvm.ComponentModel;
using ScoresAndCounters.Helpers;
using ScoresAndCounters.ViewModels.CollectionViewModels;
using System.Collections.ObjectModel;

namespace ScoresAndCounters.ViewModels
{
    public class CountersPageViewModel : ObservableObject
    {
        private IPreferencesHelper _preferencesHelper;

        public ObservableCollection<CounterItemViewModel> CounterItems { get; set; }
        
        public Command AddCounterItemCommand { get; private set; }
        public Command RemoveCounterItemCommand { get; private set; }

        public CountersPageViewModel(IPreferencesHelper preferencesHelper)
        {
            CounterItems = new ObservableCollection<CounterItemViewModel>();
            AddCounterItemCommand = new Command(ExecuteAddCounterItemCommand);
            RemoveCounterItemCommand = new Command<CounterItemViewModel>(ExecuteRemoveCounterItemCommand);
            _preferencesHelper = preferencesHelper;
        }

        private void ExecuteAddCounterItemCommand(object obj)
        {
            if (CounterItems.Count < AppConstants.MaxNumberOfCounters)
            {
                CounterItems.Add(new CounterItemViewModel(_preferencesHelper));
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
