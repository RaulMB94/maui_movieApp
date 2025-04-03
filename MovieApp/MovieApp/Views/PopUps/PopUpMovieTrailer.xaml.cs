using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Views;
namespace MovieApp.Views.PopUps;

public partial class PopUpMovieTrailer : Popup
{
    public string Path { get; set; }
	public PopUpMovieTrailer(string trailerPath)
	{
		InitializeComponent();

        videoWebView.Source = $"https://www.youtube.com/embed/{trailerPath}";
	}

    private async void closeButton_Clicked(object sender, EventArgs e)
    {
        // Limpia recursos del WebView (si lo usas)
        if (videoWebView != null)
        {
            videoWebView.Source = null;
            videoWebView.Handler?.DisconnectHandler();
        }

            var cts = new CancellationTokenSource(TimeSpan.FromSeconds(5));

        await CloseAsync(token: cts.Token);
    }
}