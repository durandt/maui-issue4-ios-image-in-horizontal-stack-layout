using maui_issue4_ios_image_in_horizontal_stack_layout.ViewModels;

namespace maui_issue4_ios_image_in_horizontal_stack_layout;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new MainPage(new MainViewModel()));
	}
}

