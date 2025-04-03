using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Uri PosterPath {  get; set; }
        public DateOnly ReleaseDate { get; set; }
        public float VoteAverage { get; set; }
        public int VoteCount { get; set; }
        public string OriginalLanguage { get; set; }
        public string Overview {  get; set; }
        public decimal Popularity {  get; set; }
        public int[] GenresId { get; set; }
        public int[] StreamingId { get; set; }
        public string VideoPath { get; set; }
    }
}
