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
	public partial class PullToRefresh : ContentPage
	{
		public PullToRefresh ()
		{
			InitializeComponent ();

            listView.ItemsSource = new List<Contact>
            {
                new Contact {Name = "Mosh", ImageUrl = "http://lorempixel.com/100/100/people/1"},
                new Contact {Name = "John", ImageUrl = "http://lorempixel.com/100/100/people/2", Status = "Hey. Let's talk"},
                new Contact {Name = "Bob", ImageUrl = "http://lorempixel.com/100/100/people/3"},
            };
        }

        List<Contact> GetContacts()
        {
            return new List<Contact>
            {
                new Contact {Name = "Mosh", ImageUrl = "http://lorempixel.com/100/100/people/1"},
                new Contact {Name = "John", ImageUrl = "http://lorempixel.com/100/100/people/2", Status = "Hey. Let's talk"},
                new Contact {Name = "Bob", ImageUrl = "http://lorempixel.com/100/100/people/3"},
                new Contact {Name = "Mark", ImageUrl = "http://lorempixel.com/100/100/people/4"},
            };
        }
        private void ListView_Refreshing(object sender, EventArgs e)
        {
            listView.ItemsSource = GetContacts();

            listView.EndRefresh();
        }
    }
}