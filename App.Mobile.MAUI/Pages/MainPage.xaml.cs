using App.Mobile.MAUI.ViewModel;

namespace App.Mobile.MAUI.Pages;

public partial class MainPage : ContentPage
{

	public MainPage(MainViewModel viewModel)
	{
		InitializeComponent();

        BindingContext = viewModel;

    }
}

