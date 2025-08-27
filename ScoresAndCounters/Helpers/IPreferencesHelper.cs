namespace ScoresAndCounters.Helpers
{
    public interface IPreferencesHelper
    {
        int GetCustomIncDecValue1();
        int GetCustomIncDecValue2();
        void SetCustomIncDecValue1(int customIncDecValue);
        void SetCustomIncDecValue2(int customIncDecValue);
    }
}