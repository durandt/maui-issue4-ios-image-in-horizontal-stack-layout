using System.ComponentModel;
using maui_issue2_ios_stacklayout_scroll.ViewModels;

namespace maui_issue2_ios_stacklayout_scroll;

public partial class MainPage : ContentPage
{
    private MainViewModel MainViewModel { get; }

	public MainPage(MainViewModel mainViewModel)
	{
		InitializeComponent();
		BindingContext = mainViewModel;
        MainViewModel = mainViewModel;
    }

    private void AddManyItemsButton_OnClicked(object sender, EventArgs e)
    {
        for (var i = 0; i < 30; i++)
        {
            MainViewModel.AddItem();
        }
    }

    private void InvalidateMeasureButton_OnClicked(object sender, EventArgs e)
    {
        InvalidateMeasure();
    }

    private void VerticalStackLayout_PropertyChanged(object sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName == HeightProperty.PropertyName)
        {
            if (MainViewModel.FixBug)
            {
                (_ScrollView as IView)?.InvalidateMeasure();
            }
        }
    }
}


