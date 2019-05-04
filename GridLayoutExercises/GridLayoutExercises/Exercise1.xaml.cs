using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GridLayoutExercises
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Exercise1 : ContentPage
	{
		public Exercise1 ()
		{
			InitializeComponent ();
		}

        private void Dial_Number(object sender, EventArgs e)
        {
            dialedNumber.Text += (sender as Button).Text;   // Gets text of clicked button
        }
    }
}