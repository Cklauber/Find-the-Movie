using FindTheMovie.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FindTheMovie.ViewModel
{
    class MovieListViewModel
    {
        private const string baseMovieUrl = "https://api.themoviedb.org/3/search/movie?api_key=f55b3dc8fcc438ec2915a5da84a0cd8d&query=";
        private const string baseImgUrl = "https://image.tmdb.org/t/p/w200/";
        private HttpClient _client = new HttpClient();
        private ObservableCollection<Movie> movieList;
        public ObservableCollection<Movie> MovieList { get => movieList; } 


        //public async IEnumerable<Movie> GetMovies(string Query)
        public async Task<ObservableCollection<Movie>> GetMoviesAsync(string query)
        {
            JObject content = JObject.Parse(await _client.GetStringAsync(baseMovieUrl + query));

            IList<JToken> results = content["results"].Children().ToList();

            movieList = new ObservableCollection<Movie>();

            foreach(JToken result in results)
            {
                movieList.Add(result.ToObject<Movie>());
            }

            return movieList;
        }
    }
}
