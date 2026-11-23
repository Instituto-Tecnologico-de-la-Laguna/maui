using Microsoft.Extensions.Logging;

namespace MauiApp;

public static class MauiProgram
{
	public static Microsoft.Maui.Hosting.MauiApp CreateMauiApp()
	{
		var builder = Microsoft.Maui.Hosting.MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				// fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		// Inyección de dependencias
		builder.Services.AddSingleton<ViewModels.MainViewModel>();
		builder.Services.AddSingleton<Views.MainPage>();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
