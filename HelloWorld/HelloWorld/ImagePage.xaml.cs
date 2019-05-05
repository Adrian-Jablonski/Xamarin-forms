using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ImagePage : ContentPage
	{
		public ImagePage ()
		{
			InitializeComponent ();

            //var imageSource = (UriImageSource) ImageSource.FromUri(new Uri("http://..."));

            var imageSource = new UriImageSource { Uri = new Uri("http://lorempixel.com/1920/1080/nature/3/") };
            imageSource.CachingEnabled = false; // Defaults to true when created in xaml
            // imageSource.CacheValidity = TimeSpan.FromHours(1);  // Defaults cache to 1 day

            image.Source = imageSource;


		}
	}
}