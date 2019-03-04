using FindTheMovie.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FindTheMovie.View
{
	public partial class MovieView : ContentPage
    {
        private Movie _movie;

        public MovieView (Movie movie)
		{
            this._movie = movie;
            InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            mainLayout.BindingContext = _movie;
            base.OnAppearing();
        }

    }
}