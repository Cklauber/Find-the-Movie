using FindTheMovie.Model;
using FindTheMovie.ViewModel;
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
using Xamarin.Forms;

namespace FindTheMovie.View
{
    public partial class MovieList: ContentPage
    {
        private const string baseMovieUrl = "https://api.themoviedb.org/3/search/movie?api_key=f55b3dc8fcc438ec2915a5da84a0cd8d&query=";
        private const string baseImgUrl = "https://image.tmdb.org/t/p/w200/";
        private HttpClient _client = new HttpClient();
        private ObservableCollection<Movie> _movies = new ObservableCollection<Movie>();

        MovieListViewModel vm = new MovieListViewModel();
        public MovieList()
        {

            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
        private async void SearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            
            if (SearchBar.Text.Length >= 3)
            {

                _movies = await vm.GetMoviesAsync(SearchBar.Text);
                movieListView.ItemsSource = _movies;
            }
        }

        private async void MovieListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(movieListView.SelectedItem != null)
            {
                Movie selected = e.SelectedItem as Movie;
                await Navigation.PushAsync(new MovieView(selected));
            }
            movieListView.SelectedItem = null;
        }
    }
}
