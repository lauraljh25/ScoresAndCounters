using Microsoft.Extensions.Logging;
using ScoresAndCounters.Helpers;
using ScoresAndCounters.ViewModels;
using ScoresAndCounters.Views;

namespace ScoresAndCounters
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            RegisterDependencies(builder);

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }

        private static void RegisterDependencies(MauiAppBuilder builder)
        {
            //helpers
            builder.Services.AddTransient<IPreferencesHelper, PreferencesHelper>();
            
            //viewModels
            builder.Services.AddSingleton<SettingsPageViewModel>();
            
            //views
            builder.Services.AddSingleton<SettingsPage>();
        }
    }
}
