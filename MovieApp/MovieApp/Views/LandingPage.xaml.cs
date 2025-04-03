using MovieApp.ViewModels;

namespace MovieApp.Views;

public partial class LandingPage : ContentPage
{
	public LandingPage()
	{
		InitializeComponent();

		BindingContext = new LandingPageViewModel();
	}
}