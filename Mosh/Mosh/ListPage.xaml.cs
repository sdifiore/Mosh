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
	public partial class ListPage : ContentPage
	{
		public ListPage ()
		{
			InitializeComponent ();

            var names = new List<Contact>
            {
                new Contact { Name = "Cláudia", ImageUrl = "https://www.pon.harvard.edu/wp-content/uploads/images/posts/deepak-malhotra-1001-1.gif"},
                new Contact { Name = "Manuela", ImageUrl = "https://www.pon.harvard.edu/wp-content/uploads/images/posts/hannah-riley-bowles.gif", Status = "Hey, let's talk"}
            };

            listView.ItemsSource = names;
		}
	}
}