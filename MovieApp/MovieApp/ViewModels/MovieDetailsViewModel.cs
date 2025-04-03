using CommunityToolkit.Mvvm.ComponentModel;
using MovieApp.Models;
using MovieApp.Services;
using MovieApp.Views.PopUps;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.Input;

namespace MovieApp.ViewModels
{
    [QueryProperty("Movie", "Movie")]
    public partial class MovieDetailsViewModel : ObservableObject
    {
        [ObservableProperty]
        Movie movie;

        public ObservableCollection<Genre> Genres { get; set; } = new(); 
        public ObservableCollection<StreamingPlatform> Platforms { get; set; } = new(); 

        private readonly MovieAppService _movieAppService;
        public MovieDetailsViewModel() 
        { 
            _movieAppService = new MovieAppService();

        }

        public void LoadData()
        {
            foreach (var id in Movie.GenresId) 
            {
                var genre = _movieAppService.GetGenres().Where(x => x.Id.Equals(id)).FirstOrDefault();
                if (genre != null)
                    Genres.Add(genre);
            }

            foreach (var id in Movie.StreamingId)
            {
                var platform = _movieAppService.GetStreamingPlatforms().Where(x => x.Id.Equals(id)).FirstOrDefault();
                if (platform != null)
                    Platforms.Add(platform);
            }
        }

        [RelayCommand]
        public async Task ShowPopupTrailer()
        {
            var popup = new PopUpMovieTrailer(Movie.VideoPath);
            var result = await Application.Current?.MainPage.ShowPopupAsync(popup);
        }
    }
}
