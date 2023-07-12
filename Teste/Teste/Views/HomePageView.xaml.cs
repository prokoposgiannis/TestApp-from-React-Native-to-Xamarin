using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Teste.Views
{	
	public partial class HomePageView : ContentPage
	{	
		public HomePageView ()
		{
			InitializeComponent ();

        image.Source = ImageSource.FromResource("Teste.Images.googleMap.png");
		}


	}
}

