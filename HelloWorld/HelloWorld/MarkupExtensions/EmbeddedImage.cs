using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

// This is a custom markup extension created to be used inside a .xaml file
// To access this markup. Add xmlns:local="clr-namespace:HelloWorld.MarkupExtensions" to .xaml file under ContentPage
namespace HelloWorld.MarkupExtensions
{
    [ContentProperty("ResourceId")]
    class EmbeddedImage : IMarkupExtension
    {
        public string ResourceId { get; set; }  // ResourceId passed in xaml
        object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider)
        {
            if (String.IsNullOrWhiteSpace(ResourceId)) {
                return null;
            }
            return ImageSource.FromResource(ResourceId);
        }
    }
}
