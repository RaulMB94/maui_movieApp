using MovieApp.ViewModels;

namespace MovieApp.Views;

public partial class MovieDetails : ContentPage
{
	private MovieDetailsViewModel _vm;
	public MovieDetails(MovieDetailsViewModel viewModel)
	{
		InitializeComponent();
		_vm = viewModel;
		BindingContext = _vm;
		
		
	}

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
		_vm.LoadData();
    }
}
