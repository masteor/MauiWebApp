namespace MauiApp1;

public partial class App : Application
{
	internal static string wwwpage = "https://www.di.fm/channels/ambient";

	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
