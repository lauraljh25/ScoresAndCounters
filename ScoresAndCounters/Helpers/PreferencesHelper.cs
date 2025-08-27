namespace ScoresAndCounters.Helpers
{
    public class PreferencesHelper : IPreferencesHelper
    {
        public void SetCustomIncDecValue1(int customIncDecValue)
        {
            Preferences.Default.Set("custom_inc_dec_value_1", customIncDecValue);
        }

        public int GetCustomIncDecValue1()
        {
            return Preferences.Default.Get("custom_inc_dec_value_1", AppConstants.DefaultCustomIncDec_1);
        }

        public void SetCustomIncDecValue2(int customIncDecValue)
        {
            Preferences.Default.Set("custom_inc_dec_value_2", customIncDecValue);
        }

        public int GetCustomIncDecValue2()
        {
            return Preferences.Default.Get("custom_inc_dec_value_2", AppConstants.DefaultCustomIncDec_2);
        }
    }
}
