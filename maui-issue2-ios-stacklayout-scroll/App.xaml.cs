using maui_issue2_ios_stacklayout_scroll.ViewModels;

namespace maui_issue2_ios_stacklayout_scroll;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new MainPage(new MainViewModel()));
	}
}

