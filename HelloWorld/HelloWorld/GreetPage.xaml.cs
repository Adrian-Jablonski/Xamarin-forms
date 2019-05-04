using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

// Codebehind file of GreetPage.xaml
namespace HelloWorld
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GreetPage : ContentPage
	{
		public GreetPage()
		{
			InitializeComponent ();

            slider.Value = .5;  // Sets initial slider value to .5 

            //Content = new Label
            //{
            //    HorizontalOptions = LayoutOptions.Center,
            //    VerticalOptions = LayoutOptions.Center,
            //    Text = "Hello World"
            //};  // A way to create user interfaces using code (Same as writing <Label HorizontalOptions="Center" VerticalOptions="Center" Text="Hello World"></Label> in .xaml file)
        }

        // // Button onclick event
        //private void Button_Clicked(object sender, EventArgs e)
        //{
        //    DisplayAlert("Title", "Hello World", "OK");
        //}

        // // **** Replaced by data binding in xaml file ****
        //private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        //{
        //    labelId.Text = String.Format("Value is {0:F2}", e.NewValue);    // Sets the text of field with an ID (x:Name) of labelId. F2 sets number to 2 decimal spaces
        //}

    }
}