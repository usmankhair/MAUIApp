using App.Mobile.MAUI.Pages;
using App.Mobile.MAUI.ViewModel;

namespace App.Mobile.MAUI;

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

        RegisterViewModels(builder);

        return builder.Build();
	}


	private static void RegisterViewModels(MauiAppBuilder mauiAppBuilder)
	{
		mauiAppBuilder.Services.AddSingleton<MainPage>();
        mauiAppBuilder.Services.AddSingleton<MainViewModel>();

        mauiAppBuilder.Services.AddTransient<DetailPage>();
        mauiAppBuilder.Services.AddTransient<DetailViewModel>();

		mauiAppBuilder.Services.AddSingleton(Connectivity.Current);

    }
}
