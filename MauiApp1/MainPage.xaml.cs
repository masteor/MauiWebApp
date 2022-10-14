using Microsoft.Maui.Layouts;

namespace MauiApp1;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void Entry_Completed(object sender, EventArgs e)
	{
		App.wwwpage = ((Entry)sender).Text;
		AppShell.Current.Title = ((Entry)sender).Text;
		webView.Source = App.wwwpage;

    }

    // <WebView x:Name="webView" Source="https://di.fm" />
}

