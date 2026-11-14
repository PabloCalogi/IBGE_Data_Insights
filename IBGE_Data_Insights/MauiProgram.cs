using Microsoft.Extensions.Logging;
using IBGE_Data_Insights.Views;
using IBGE_Data_Insights.Services;
using CommunityToolkit.Maui;

namespace IBGE_Data_Insights;
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>().ConfigureFonts(fonts =>
        {
            fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
        }).UseMauiCommunityToolkit();
#if DEBUG
        builder.Logging.AddDebug();
#endif
        builder.Services.AddSingleton<IbgeService>();
        builder.Services.AddTransient<MainPage>();
        return builder.Build();
    }
}