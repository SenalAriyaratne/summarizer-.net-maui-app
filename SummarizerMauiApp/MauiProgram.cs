using Microsoft.Extensions.Logging;
using SummarizerMauiApp.ViewModels;
using SummarizerMauiApp.Views;

namespace SummarizerMauiApp
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
                    fonts.AddFont("Font-Awesome-Solid-900.otf", "FontAwesome");
                    fonts.AddFont("MaterialIconsRound-Regular.otf", "MaterialDesign");
                    fonts.AddFont("Pacifico-Regular.ttf", "Pacificoreg");
                });

            //Page Registration
            builder.Services.AddSingleton<HomePage>();

            //View Model Registration
            builder.Services.AddTransient<BaseViewModel>();
            builder.Services.AddTransient<HomeViewModel>();

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
