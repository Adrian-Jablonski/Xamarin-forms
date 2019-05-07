﻿using Navigation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactsPage : ContentPage
    {
        public ContactsPage()
        {
            InitializeComponent();

            listView.ItemsSource = new List<Contact>
            {
                new Contact {Name = "Mosh", ImageUrl = "http://lorempixel.com/100/100/people/1", Status = "Away"},
                new Contact {Name = "John", ImageUrl = "http://lorempixel.com/100/100/people/2", Status = "Hey. Let's talk"},
                new Contact {Name = "Bob", ImageUrl = "http://lorempixel.com/100/100/people/3"},
            };
        }

        async private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return;
            }
            var contact = e.SelectedItem as Contact;
            await Navigation.PushAsync(new ContactDetailPage(contact));
            listView.SelectedItem = null;   // Unselects selected item for when user goes back to contact list page
        }
    }
}