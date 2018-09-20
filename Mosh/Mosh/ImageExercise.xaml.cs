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
	public partial class ImageExercise : ContentPage
	{
        private int _index = 0;
        private string sourceUrl = "http://lorempixel.com/1920/1080/city/";


        public ImageExercise ()
		{
			InitializeComponent ();
		}

        private void previous_Clicked(object sender, EventArgs e)
        {

            _index--;
            if (_index < 1) _index = 10;
            image.Source = sourceUrl + _index;
        }

        private void next_Clicked(object sender, EventArgs e)
        {
            _index++;
            if (_index > 10) _index = 1;
            image.Source = sourceUrl + _index;
        }
    }
}