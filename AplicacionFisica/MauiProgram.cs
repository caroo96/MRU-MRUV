using Microsoft.Extensions.Logging;

namespace AplicacionFisica
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
                    fonts.AddFont("Open24DisplaySt.ttf", "Open24DisplaySt");
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("BebasRegular.ttf", "BebasRegular");
                    fonts.AddFont("LemonFruit.otf", "LemonFruit");
                    fonts.AddFont("SimpleDay.otf", "SimpleDay");                    
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
