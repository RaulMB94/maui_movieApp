using MovieApp.ViewModels;
using MovieApp.Views;

namespace MovieApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(MovieDetails), typeof(MovieDetails));
        }
    }
}
