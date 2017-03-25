using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Aula1Alfa1
{
	public partial class Pagina3 : ContentPage
	{
		public Pagina3()
		{
			InitializeComponent();
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			// fecha modal
			Navigation.PopModalAsync();
		}
	}
}
