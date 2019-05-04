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
	public partial class GreetPage : ContentPage
	{
		public GreetPage()
		{
			InitializeComponent ();


            Content = new Label
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Text = "Hello World"
            };  // A way to create user interfaces using code (Same as writing <Label HorizontalOptions="Center" VerticalOptions="Center" Text="Hello World"></Label> in .xaml file)
        }

        // // Button onclick event
        //private void Button_Clicked(object sender, EventArgs e)
        //{
        //    DisplayAlert("Title", "Hello World", "OK");
        //}


    }
}