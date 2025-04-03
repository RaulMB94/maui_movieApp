using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MovieApp.Models;
using MovieApp.Services;
using MovieApp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.ViewModels
{
    public partial class LandingPageViewModel : ObservableObject
    {
        public ObservableCollection<Movie> Movies { get; set; } = new();
        public ObservableCollection<StreamingPlatform> StreamingPlatforms { get; set; } = new();

        [ObservableProperty]
        int selectedCountriesIndex;

        [ObservableProperty]
        int selectedOrderByIndex;

        [ObservableProperty]
        ObservableCollection<object> selectedPlatforms = new(); 

        [ObservableProperty]
        ObservableCollection<object> selectedGenres = new();

        public List<string> Countries { get; set; }
        public List<string> OrderBy { get; set; }
        public List<Genre> Genres { get; set; }

        private readonly MovieAppService _movieAppService;

        public LandingPageViewModel() 
        {
            _movieAppService = new MovieAppService();
            
            LoadData();
        }
        

        private void LoadData()
        {
            OrderBy = new List<string>()
            {
                "Más recientes",
                "Más populares",
                "Mejor puntuación",
                "Por título (A-Z)",
                "Por título (Z-A)"
            };
            Genres = new List<Genre>(_movieAppService.GetGenres());
            Countries = new List<string>(_movieAppService.GetCountries());
            StreamingPlatforms = new ObservableCollection<StreamingPlatform>(_movieAppService.GetStreamingPlatforms());
            
            SelectedCountriesIndex = 0;
            SelectedOrderByIndex = 0;

            Movies = new ObservableCollection<Movie>(FilterMovies());

        }

        private IEnumerable<Movie> FilterMovies()
        {
            var allMovies = _movieAppService.GetMovies();
            var sPlatforms = SelectedPlatforms.Cast<StreamingPlatform>();
            var sGenres = SelectedGenres.Cast<Genre>();
            var filteredMovies = allMovies.Where(
                x => (!sPlatforms.Any() || x.StreamingId.Any(id => sPlatforms.Select(sp => sp.Id).Contains(id))) &&
                (!sGenres.Any() || x.GenresId.Any(id => sGenres.Select(sg => sg.Id).Contains(id))) 
                );
            // Aplica el orden seleccionado
            return new List<Movie>(
                SelectedOrderByIndex switch
                {
                    0 => filteredMovies.OrderByDescending(m => m.ReleaseDate),
                    1 => filteredMovies.OrderByDescending(m => m.Popularity),
                    2 => filteredMovies.OrderByDescending(m => m.VoteCount),
                    3 => filteredMovies.OrderBy(m => m.Title),
                    4 => filteredMovies.OrderByDescending(m => m.Title),
                    _ => filteredMovies
                });
        }


        [RelayCommand]
        void ApplyFiltersClickButton()
        {
            if(Movies.Count > 0)
                Movies.Clear();
            foreach(var  movie in FilterMovies())
            {
                Movies.Add(movie);
            }
            
        }

        [RelayCommand]
        void ShowMoreMoviesClick()
        {

        }

        [RelayCommand]
        async Task GoToMovieDetails(Movie movie)
        {
            if (movie is null)
                return;

            await Shell.Current.GoToAsync(nameof(MovieDetails), true, new Dictionary<string, object>
            {
                {"Movie", movie }
            });
        }
    }
}
