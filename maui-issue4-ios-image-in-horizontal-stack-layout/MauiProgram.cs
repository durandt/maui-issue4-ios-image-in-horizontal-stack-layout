﻿using maui_issue4_ios_image_in_horizontal_stack_layout.ViewModels;
using Microsoft.Extensions.Logging;

namespace maui_issue4_ios_image_in_horizontal_stack_layout;

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
#endif

		builder.Services.AddTransient<MainViewModel>();
        builder.Services.AddTransient<MainPage>();

        return builder.Build();
	}
}

