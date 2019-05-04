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
	public partial class GridPage : ContentPage
	{
		public GridPage ()
		{
			InitializeComponent ();

            var grid = new Grid
            {
                RowSpacing = 20,
                ColumnSpacing = 40
            };
            grid.Children.Add(new Label { Text = "Label 1" }, 0, 0);    // Label, row, column
		}
	}
}