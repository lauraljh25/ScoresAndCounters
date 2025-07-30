using ScoresAndCounters.Views;

namespace ScoresAndCounters
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
        }

        private void RegisterRoutes()
        {
            Routing.RegisterRoute(nameof(CountersPage), typeof(CountersPage));
        }
    }
}
