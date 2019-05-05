using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

// Need to use the following plugin for rounded images https://github.com/jamesmontemagno/ImageCirclePlugin
// Right click main project package -> Manage NuGet Packages -> Search for "Xam.Plugins.Forms.ImageCircle"
// Repeate for Android and iOS project package

// Next go to HelloWorld.iOS/AppDelegate.cs. Add ImageCircleRenderer.Init() to FinishedLaunching under Xamarin.Forms.Forms.Init();
// Then go to HelloWorld.Android/MainActivity.cs. Add ImageCircleRenderer.Init() to OnCreate under global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

// In xaml. Add the following xmlns ' xmlns:ic="clr-namespace:ImageCircle.Forms.Plugin.Abstractions;assembly=ImageCircle.Forms.Plugin" '    // See github documentation

namespace HelloWorld
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RoundedImages : ContentPage
	{
		public RoundedImages ()
		{
			InitializeComponent ();
		}
	}
}