using Mosh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mosh
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SearchBar : ContentPage
	{
		public SearchBar ()
		{
			InitializeComponent ();

            listView.ItemsSource = GetContacts();
        }

        private IEnumerable<Contact> GetContacts(string searchText = null)
        {
            var contacts = new List<Contact>
            {
                new Contact { Name = "Cláudia", ImageUrl = "https://www.pon.harvard.edu/wp-content/uploads/images/posts/deepak-malhotra-1001-1.gif"},
                new Contact { Name = "Manuela", ImageUrl = "https://www.pon.harvard.edu/wp-content/uploads/images/posts/hannah-riley-bowles.gif", Status = "Hey, let's talk"}
            };

            if (String.IsNullOrWhiteSpace(searchText))
                return contacts;


            return contacts.Where(c => c.Name.ToLower().StartsWith(searchText.ToLower()));
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            listView.ItemsSource = GetContacts(e.NewTextValue);
        }
    }
}