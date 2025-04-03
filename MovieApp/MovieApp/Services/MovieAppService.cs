using MovieApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Services
{
    public class MovieAppService
    {
        public IEnumerable<Movie> GetMovies() 
        {

            return new List<Movie>() 
            {
                new Movie()
                {
                    Id = 1,
                    Title = "Raya and the Last Dragon",
                    OriginalLanguage = "en",
                    Overview = "Long ago, in the fantasy world of Kumandra, humans and dragons lived together in harmony. But when an evil force threatened the land, the dragons sacrificed themselves to save humanity. Now, 500 years later, that same evil has returned and it’s up to a lone warrior, Raya, to track down the legendary last dragon to restore the fractured land and its divided people.",
                    Popularity = 3686.429M,
                    PosterPath = new Uri("https://image.tmdb.org/t/p/w600_and_h900_bestv2/lPsD10PP4rgUGiGR4CCXA6iY0QQ.jpg"),
                    ReleaseDate = new(2021, 03, 03),
                    VoteAverage = 8.5f,
                    VoteCount = 1407,
                    GenresId = [1, 8, 13],
                    StreamingId = [1,2,3,5,6],
                    VideoPath = "R3AECE35Anw"
                },
                new Movie()
                {
                    Id = 2,
                    Title = "Inception",
                    OriginalLanguage = "en",
                    Overview = "A thief who steals corporate secrets through use of dream-sharing technology is given the inverse task of planting an idea into the mind of a CEO.",
                    Popularity = 2200.148M,
                    PosterPath = new Uri("https://image.tmdb.org/t/p/w600_and_h900_bestv2/tXQvtRWfkUUnWJAn2tN3jERIUG.jpg"),
                    ReleaseDate = new(2010, 07, 16),
                    VoteAverage = 8.8f,
                    VoteCount = 23000,
                    GenresId = [2, 4, 6],
                    StreamingId = [1,2,3,5,6],
                    VideoPath = "RV9L7ui9Cn8"
                },
                new Movie()
                {
                    Id = 3,
                    Title = "The Dark Knight",
                    OriginalLanguage = "en",
                    Overview = "Batman raises the stakes in his war on crime. With the help of Lt. Jim Gordon and District Attorney Harvey Dent, Batman sets out to dismantle the remaining criminal organizations that plague the streets. The partnership proves to be effective, but they soon find themselves prey to a reign of chaos unleashed by a rising criminal mastermind known to the terrified citizens of Gotham as the Joker.",
                    Popularity = 3000.543M,
                    PosterPath = new Uri("https://image.tmdb.org/t/p/w600_and_h900_bestv2/qJ2tW6WMUDux911r6m7haRef0WH.jpg"),
                    ReleaseDate = new(2008, 07, 18),
                    VoteAverage = 9.0f,
                    VoteCount = 27000,
                    GenresId = [2],
                    StreamingId = [1,2,5,6],
                    VideoPath = "EXeTwQWrcwY"
                },
                new Movie()
                {
                    Id = 4,
                    Title = "Avatar",
                    OriginalLanguage = "en",
                    Overview = "A paraplegic Marine dispatched to the moon Pandora on a unique mission becomes torn between following his orders and protecting the world he feels is his home.",
                    Popularity = 2600.321M,
                    PosterPath = new Uri("https://image.tmdb.org/t/p/w600_and_h900_bestv2/tXmTHdrZgNsULqCbThK2Dt2X9Wt.jpg"),
                    ReleaseDate = new(2009, 12, 18),
                    VoteAverage = 7.8f,
                    VoteCount = 21000,
                    GenresId = [2, 6],
                    StreamingId = [3,5,6,7],
                    VideoPath = "5PSNL1qE6VY"
                },
                new Movie()
                {
                    Id = 5,
                    Title = "Interstellar",
                    OriginalLanguage = "en",
                    Overview = "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.",
                    Popularity = 2800.761M,
                    PosterPath = new Uri("https://image.tmdb.org/t/p/w600_and_h900_bestv2/gEU2QniE6E77NI6lCU6MxlNBvIx.jpg"),
                    ReleaseDate = new(2014, 11, 07),
                    VoteAverage = 8.6f,
                    VoteCount = 17000,
                    GenresId = [4, 6, 8],
                    StreamingId = [1,2,3,5,6,7,8],
                    VideoPath = "UoSSbmD9vqc"
                },
                new Movie()
                {
                    Id = 6,
                    Title = "Frozen",
                    OriginalLanguage = "en",
                    Overview = "When the newly crowned Queen Elsa accidentally uses her power to turn things into ice to curse her home in infinite winter, her sister Anna teams up with a mountain man, his playful reindeer, and a snowman to change the weather condition.",
                    Popularity = 3400.890M,
                    PosterPath = new Uri("https://image.tmdb.org/t/p/w600_and_h900_bestv2/hAKhrHvzQDUHQP5zd5HFeqF2BCN.jpg"),
                    ReleaseDate = new(2013, 11, 27),
                    VoteAverage = 7.9f,
                    VoteCount = 15000,
                    GenresId = [1, 3, 7, 10, 13],
                    StreamingId = [1,4,3,5,6,10],
                    VideoPath = "TbQm5doF_Uc"
                },
                new Movie()
                {
                    Id = 7,
                    Title = "Parasite",
                    OriginalLanguage = "ko",
                    Overview = "Greed and class discrimination threaten the newly formed symbiotic relationship between the wealthy Park family and the destitute Kim clan.",
                    Popularity = 1900.670M,
                    PosterPath = new Uri("https://image.tmdb.org/t/p/w600_and_h900_bestv2/4N55tgxDW0RRATyrZHbx0q9HUKv.jpg"),
                    ReleaseDate = new(2019, 05, 30),
                    VoteAverage = 8.5f,
                    VoteCount = 13000,
                    GenresId = [3, 4, 11],
                    StreamingId = [1,2,3,5,6],
                    VideoPath = "isOGD_7hNIY"
                },
                new Movie()
                {
                    Id = 8,
                    Title = "Titanic",
                    OriginalLanguage = "en",
                    Overview = "A seventeen-year-old aristocrat falls in love with a kind but poor artist aboard the luxurious, ill-fated R.M.S. Titanic.",
                    Popularity = 3100.532M,
                    PosterPath = new Uri("https://image.tmdb.org/t/p/w600_and_h900_bestv2/VMOt5scbGmBKDvkfHjZN6Ki54i.jpg"),
                    ReleaseDate = new(1997, 12, 19),
                    VoteAverage = 7.8f,
                    VoteCount = 21000,
                    GenresId = [4, 9, 15],
                    StreamingId = [1,2,3,5,6,10,11],
                    VideoPath = "tA_qMdzvCvk"
                },
                new Movie()
                {
                    Id = 9,
                    Title = "The Lion King",
                    OriginalLanguage = "en",
                    Overview = "A young lion prince flees his kingdom after the murder of his father, only to learn the true meaning of responsibility and bravery.",
                    Popularity = 2300.792M,
                    PosterPath = new Uri("https://image.tmdb.org/t/p/w600_and_h900_bestv2/b0MxU37dNmMwKtoPVYPKOZSIrIn.jpg"),
                    ReleaseDate = new(1994, 06, 15),
                    VoteAverage = 8.5f,
                    VoteCount = 12000,
                    GenresId = [1, 3, 7, 10, 13],
                    StreamingId = [1,2,3,4],
                    VideoPath = "lFzVJEksoDY"
                },
                new Movie()
                {
                    Id = 10,
                    Title = "Spider-Man: No Way Home",
                    OriginalLanguage = "en",
                    Overview = "Peter Parker seeks Doctor Strange's help to make everyone forget his identity, leading to unexpected consequences.",
                    Popularity = 3700.285M,
                    PosterPath = new Uri("https://image.tmdb.org/t/p/w600_and_h900_bestv2/1g0dhYtq4irTY1GPXvft6k4YLjm.jpg"),
                    ReleaseDate = new(2021, 12, 17),
                    VoteAverage = 8.2f,
                    VoteCount = 22000,
                    GenresId = [4, 9, 15],
                    StreamingId = [1,2,3,5,6],
                    VideoPath = "ldMn-1iQzKE"
                }
            };
            
        }

        public IEnumerable<Genre> GetGenres()
        {
            return new List<Genre>()
            {
                new(){Id = 1, Name = "Familia"},
                new(){Id = 2, Name = "Acción"},
                new(){Id = 3, Name = "Comedia"},
                new(){Id = 4, Name = "Drama"},
                new(){Id = 5, Name = "Terror"},
                new(){Id = 6, Name = "Ciencia ficción"},
                new(){Id = 7, Name = "Animación"},
                new(){Id = 8, Name = "Aventura"},
                new(){Id = 9, Name = "Romance"},
                new(){Id = 10, Name = "Musical"},
                new(){Id = 11, Name = "Suspense"},
                new(){Id = 12, Name = "Misterio"},
                new(){Id = 13, Name = "Fantasía"},
                new(){Id = 14, Name = "Documental"},
                new(){Id = 15, Name = "Historia"},
                new(){Id = 16, Name = "Bélico"},
                new(){Id = 17, Name = "Western"},
                new(){Id = 18, Name = "Deporte"},
                new(){Id = 19, Name = "Crimen"},
                new(){Id = 20, Name = "Biografía"},
            };
        }

        public IEnumerable<StreamingPlatform> GetStreamingPlatforms()
        {
            return new List<StreamingPlatform>
            {
                new StreamingPlatform { Id = 1, Name = "Netflix", ImagePath = new("https://media.themoviedb.org/t/p/original/pbpMk2JmcoNnQwx5JGpXngfoWtp.jpg")},
                new StreamingPlatform { Id = 2, Name = "Amazon Prime Video", ImagePath = new("https://media.themoviedb.org/t/p/original/68MNrwlkpF7WnmNPXLah69CR5cb.jpg")},
                new StreamingPlatform { Id = 3, Name = "Disney+", ImagePath = new("https://media.themoviedb.org/t/p/original/7rwgEs15tFwyR9NPQ5vpzxTj19Q.jpg")},
                new StreamingPlatform { Id = 4, Name = "HBO Max", ImagePath = new("https://media.themoviedb.org/t/p/original/fksCUZ9QDWZMUwL2LgMtLckROUN.jpg")},
                new StreamingPlatform { Id = 5, Name = "Rakuten", ImagePath = new("https://media.themoviedb.org/t/p/original/bZvc9dXrXNly7cA0V4D9pR8yJwm.jpg")},
                new StreamingPlatform { Id = 6, Name = "Apple TV+", ImagePath = new("https://media.themoviedb.org/t/p/original/2E03IAZsX4ZaUqM7tXlctEPMGWS.jpg")},
                new StreamingPlatform { Id = 7, Name = "Movistar Plus", ImagePath = new("https://media.themoviedb.org/t/p/original/jse4MOi92Jgetym7nbXFZZBI6LK.jpg")},
                new StreamingPlatform { Id = 8, Name = "Paramount+", ImagePath = new("https://media.themoviedb.org/t/p/original/h5DcR0J2EESLitnhR8xLG1QymTE.jpg")},
                new StreamingPlatform { Id = 9, Name = "YouTube", ImagePath = new("https://media.themoviedb.org/t/p/original/rMb93u1tBeErSYLv79zSTR07UdO.jpg")},
                new StreamingPlatform { Id = 10, Name = "Crunchyroll", ImagePath = new("https://media.themoviedb.org/t/p/original/fzN5Jok5Ig1eJ7gyNGoMhnLSCfh.jpg")},
                new StreamingPlatform { Id = 11, Name = "Filmin", ImagePath = new("https://media.themoviedb.org/t/p/original/kO2SWXvDCHAquaUuTJBuZkTBAuU.jpg")}
            };
        }

        public IEnumerable<string> GetCountries()
        {
            return new string[] { "España", "Francia", "Italia", "Alemania", "Reino Unido" };
        }


    }
}
