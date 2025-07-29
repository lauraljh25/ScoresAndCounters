using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoresAndCounters.ViewModels
{
    public class HomePageViewModel
    {
        public HomePageViewModel()
        {
            Title = "Scores And Counters";
            NewCounterButtonLabel = "New Counter +";
            ContinueButtonLabel = "Continue";
            SettingsButtonLabel = "Settings";
            ShowContineButton = false; 
        }

        #region Properties

        public string Title { get; private set; }
        public string NewCounterButtonLabel { get; private set; }
        public string ContinueButtonLabel { get; private set; }
        public string SettingsButtonLabel { get; private set; }
        public bool ShowContineButton { get; set; }

        #endregion
    }
}
