using CommunityToolkit.Mvvm.ComponentModel;
using ScoresAndCounters.Helpers;

namespace ScoresAndCounters.ViewModels
{
    public class SettingsPageViewModel : ObservableObject
    {
        private IPreferencesHelper _preferencesHelper;

        public Command SaveCommand { get; private set; }
        public Command CancelCommand { get; private set; }
        public Command DefaultCommand { get; private set; }

        public SettingsPageViewModel(IPreferencesHelper preferencesHelper) 
        {
            _preferencesHelper = preferencesHelper;
            SetProperties();

            CustomIncDec1Label = string.Format(ResourceLibrary.CustomIncrementValueEntryLabel, 1);
            CustomIncDec2Label = string.Format(ResourceLibrary.CustomIncrementValueEntryLabel, 2);

            SaveCommand = new Command(ExecuteSaveCommand);
            CancelCommand = new Command(ExecuteCancelCommand);
            DefaultCommand = new Command(ExecuteDefaultCommand);
        }

        private void SetProperties()
        {
            CustomIncDec1 = _preferencesHelper.GetCustomIncDecValue1();
            CustomIncDec2 = _preferencesHelper.GetCustomIncDecValue2();
        }

        private async void ExecuteSaveCommand(object obj)
        {
            _preferencesHelper.SetCustomIncDecValue1(CustomIncDec1);
            _preferencesHelper.SetCustomIncDecValue2(CustomIncDec2);

            await GoBack();
        }

        private async void ExecuteCancelCommand(object obj)
        {
            await GoBack();
        }

        private void ExecuteDefaultCommand(object obj)
        {
            CustomIncDec1 = AppConstants.DefaultCustomIncDec_1;
            CustomIncDec2 = AppConstants.DefaultCustomIncDec_2;
        }

        private async Task GoBack()
        {
            await Shell.Current.GoToAsync("..");
        }

        #region Properties

        public string CustomIncDec1Label { get; private set; }

        private int _customIncDec1;
        public int CustomIncDec1
        {
            get => _customIncDec1;
            set => SetProperty(ref _customIncDec1, value);
        }
        
        public string CustomIncDec2Label { get; private set; }

        private int _customIncDec2;
        public int CustomIncDec2
        {
            get => _customIncDec2;
            set => SetProperty(ref _customIncDec2, value);
        }

        #endregion
    }
}
