using App.Mobile.MAUI.Pages;

namespace App.Mobile.MAUI;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		AddRoutes();

    }

	private void AddRoutes()
	{
		Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));

        Routing.RegisterRoute(nameof(DetailPage), typeof(DetailPage));
    }

	//private void AddTabBar()
	//{
	//	var statusTab = new ShellContent { Title = "Status", Content = new StackLayoutDetails() };

 //       Items.Add(statusTab);

 //       var callTab = new ShellContent {  Title = "Calls", Content = new StackLayoutDetails() };

 //       Items.Add(callTab);

 //       CurrentItem = statusTab;

 //   }

 //   private void Init()
 //   {
 //       CurrentItem = new ShellContent { Title = "Stack Layout Design", Content = new StackLayoutDetails() };
 //   }
}
