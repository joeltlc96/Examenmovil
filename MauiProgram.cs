using CommunityToolkit.Maui;
using Examen.Services;
using Examen.Views;
using Microsoft.Extensions.Logging;

namespace Examen
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
                }).UseMauiCommunityToolkit();

            builder.Services.AddSingleton<IMessageService, MessageService>();
            builder.Services.AddTransient<MainPage>();
            builder.Services.AddTransient<Register>();
            builder.Services.AddTransient<Mostrar>();



#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
