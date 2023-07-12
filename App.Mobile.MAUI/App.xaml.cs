using App.Mobile.MAUI.Pages;

namespace App.Mobile.MAUI;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new Login();
	}
}
