using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


// Need to add all platform specific images by adding the images to the platforms resource folder. 
// For android go to HelloWorld.Android/Resources. Then add each image quality to drawable each folder. 
// For iOS go to HelloWorld.iOS/Resources and add all image qualities to resources folder
// Images names should be the same for each platform
namespace HelloWorld
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PlatformSpecificImages : ContentPage
	{
		public PlatformSpecificImages ()
		{
			InitializeComponent ();

		}
	}
}