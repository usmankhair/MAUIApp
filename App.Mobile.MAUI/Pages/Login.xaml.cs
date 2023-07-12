namespace App.Mobile.MAUI.Pages;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private void OnLoginButtonClicked(object sender, EventArgs e)
    {
        // Perform the login logic

        // Navigate to the AppShell page
        Application.Current.MainPage = new AppShell();
    }
}