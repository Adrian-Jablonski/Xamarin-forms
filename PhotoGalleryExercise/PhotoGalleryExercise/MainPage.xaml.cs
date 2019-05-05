using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PhotoGalleryExercise
{
    public partial class MainPage : ContentPage
    {
        private int imageNumber = 1;
        public MainPage()
        {
            InitializeComponent();
            LoadImage();
        }

        private void LoadImage()
        {
            var imageSource = new UriImageSource { Uri = new Uri("http://lorempixel.com/1920/1080/city/" +  imageNumber) };
            galleryImage.Source = imageSource;
        }

        private void PreviousImage(object sender, EventArgs e)
        {
            imageNumber = (imageNumber == 1) ? 10 : imageNumber -= 1;
            LoadImage();
        }

        private void NextImage(object sender, EventArgs e)
        {
            imageNumber = (imageNumber == 10) ? 1 : imageNumber += 1;
            LoadImage();
        }
    }
}
