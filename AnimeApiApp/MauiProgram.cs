using AnimeApiApp.Services;
using AnimeApiApp.Services.Interfaces;
using AnimeApiApp.ViewModels;
using Microsoft.Extensions.Logging;

namespace AnimeApiApp
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

#if DEBUG
    		builder.Logging.AddDebug();
            builder.Services.AddSingleton<ILoginService, LoginService>();
            builder.Services.AddTransient<LoginViewModel>();
#endif

            var app = builder.Build();
            Startup.ServiceProvider = app.Services;
            return app;
        }
    }
}
