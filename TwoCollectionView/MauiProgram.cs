using Microsoft.Extensions.Logging;

namespace TwoCollectionView;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			//.UseDevExpress()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        builder.Services.AddSingleton<AnimalService>();
        builder.Services.AddSingleton<AnimalListPage>();
        builder.Services.AddSingleton<AnimalListViewModel>();


		return builder.Build();
	}
}
