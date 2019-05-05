using Lists.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lists
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BasicList : ContentPage
	{
		public BasicList ()
		{
			InitializeComponent ();

            //var names = new List<string>
            //{
            //    "Mosh", "John", "Bob"
            //};

            //listView.ItemsSource = names;

            listView.ItemsSource = new List<Contact>
            {
                new Contact {Name = "Mosh", ImageUrl = "http://lorempixel.com/100/100/people/1"},
                new Contact {Name = "John", ImageUrl = "http://lorempixel.com/100/100/people/2", Status = "Hey. Let's talk"},
                new Contact {Name = "Bob", ImageUrl = "http://lorempixel.com/100/100/people/3"},
            };
		}
	}
}