using Lists.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lists
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContextActions : ContentPage
	{
        private ObservableCollection<Contact> _contacts;    // Observable collection will fire an event that will notify ListView of the change so the list will automatically update
		public ContextActions ()
		{
			InitializeComponent ();

            _contacts = new ObservableCollection<Contact>   
            {
                new Contact {Name = "Mosh", ImageUrl = "http://lorempixel.com/100/100/people/1"},
                new Contact {Name = "John", ImageUrl = "http://lorempixel.com/100/100/people/2", Status = "Hey. Let's talk"},
                new Contact {Name = "Bob", ImageUrl = "http://lorempixel.com/100/100/people/3"},
            };

            listView.ItemsSource = _contacts;
        }

        private void Call_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Contact;

            DisplayAlert("Call", contact.Name, "OK");
        }

        private void Delete_Clicked(object sender, EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as Contact;
            _contacts.Remove(contact);
        }
    }
}