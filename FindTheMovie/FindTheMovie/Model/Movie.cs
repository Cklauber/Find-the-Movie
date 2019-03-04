using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FindTheMovie.Model
{
    public class Movie
    {
        /**
         * Private attributes
         **/
        private int id;
        private string title;
        private string overview;
        private string posterPath;
        private string releaseDate;
        public string backdropPath;

        /**
         *<summary>This is the model for our Movie</summary> 
         * <param name="Title">@string for the movie's title</param>
         * <param name="Overview">@string for the movie's description </param>
         * <param name="PosterPath">@string Url for the movie thumbnail</param>
         * * <param name="ReleaseDate">@string Date for the date the release date of the movie</param>
         */
        //public Movie(int Id, string Title = null, string Overview = null, string PosterPath = null, string ReleaseDate = null)
        //{
        //    this.id = Id;
        //    this.title = Title;
        //    this.overview = Overview;
        //    this.posterPath = PosterPath;
        //    this.releaseDate = ReleaseDate;
        //}
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        [JsonProperty("title")]
        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }
        [JsonProperty("overview")]
        public string Overview
        {
            get { return this.overview; }
            set { this.overview = value; }
        }
        [JsonProperty("poster_path")]
        public string PosterPath
        {
            get { return this.posterPath; }
            set { this.posterPath = "http://image.tmdb.org/t/p/w500" + value; }
        }

        [JsonProperty("release_date")]
        public string ReleaseDate
        {
            get { return this.releaseDate; }
            set { this.releaseDate = value; }
        }

        [JsonProperty("backdrop_path")]
        public string BackdropPath
        {
            get { return this.backdropPath; }
            set { this.backdropPath = "http://image.tmdb.org/t/p/w200" + value; }
        }

    }
}
