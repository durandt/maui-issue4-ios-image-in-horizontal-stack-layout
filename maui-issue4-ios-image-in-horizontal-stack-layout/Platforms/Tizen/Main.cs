using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace maui_issue4_ios_image_in_horizontal_stack_layout;

class Program : MauiApplication
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

	static void Main(string[] args)
	{
		var app = new Program();
		app.Run(args);
	}
}

