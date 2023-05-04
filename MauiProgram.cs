namespace WeeksAhead;

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

		var services = builder.Services;

		services.AddSingleton<HomePage>();
		services.AddSingleton<LoginPage>();

		services.AddSingleton<HomeViewModel>();
		services.AddSingleton<LoginViewModel>();

		return builder.Build();
	}
}
