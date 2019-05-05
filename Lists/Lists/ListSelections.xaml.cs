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
	public partial class ListSelections : ContentPage
	{
		public ListSelections ()
		{
			InitializeComponent ();

            listView.ItemsSource = new List<Contact>
            {
                new Contact {Name = "Mosh", ImageUrl = "http://lorempixel.com/100/100/people/1"},
                new Contact {Name = "John", ImageUrl = "http://lorempixel.com/100/100/people/2", Status = "Hey. Let's talk"},
                new Contact {Name = "Bob", ImageUrl = "http://lorempixel.com/100/100/people/3"},
            };
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var contact = e.SelectedItem as Contact;

            DisplayAlert("Selected", contact.Name, "OK");

            // // Disables selection of item
            // listView.SelectedItem = null;
        }
        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var contact = e.Item as Contact;
            DisplayAlert("Tapped", contact.Name, "OK");
        }

    }
}