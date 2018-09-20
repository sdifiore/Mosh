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
	public partial class ImagePage : ContentPage
	{
		public ImagePage ()
		{
			InitializeComponent ();

            image.Source = new UriImageSource
            {
                Uri = new Uri("http://www.bigfoto.com/sites/main/aegeri-lake-switzerland.JPG"),
                CachingEnabled = false,
            };
            
		}
	}
}