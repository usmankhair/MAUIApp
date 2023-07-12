using App.Mobile.MAUI.ViewModel;

namespace App.Mobile.MAUI.Pages;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;
	}
}