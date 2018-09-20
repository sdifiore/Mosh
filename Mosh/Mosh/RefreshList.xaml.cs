using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mosh.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mosh
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RefreshList : ContentPage
	{
        public RefreshList ()
		{
			InitializeComponent ();

            listView.ItemsSource = GetContacts();
        }

        private List<Contact> GetContacts()
        {
            return new List<Contact>
            {
                new Contact { Name = "Cláudia", ImageUrl = "https://www.pon.harvard.edu/wp-content/uploads/images/posts/deepak-malhotra-1001-1.gif"},
                new Contact { Name = "Manuela", ImageUrl = "https://www.pon.harvard.edu/wp-content/uploads/images/posts/hannah-riley-bowles.gif", Status = "Hey, let's talk"}
            };
        }

        private void listView_Refreshing(object sender, EventArgs e)
        {
            listView.ItemsSource = GetContacts();
            listView.EndRefresh();
        }
    }
}