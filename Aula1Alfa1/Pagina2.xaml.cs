using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Aula1Alfa1
{
	public partial class Pagina2 : ContentPage
	{
		public Pagina2()
		{
			InitializeComponent();
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			// volta uma página
			Navigation.PopAsync();

			// volta todas as paginas
			//Navigation.PopToRootAsync();
		}
	}
}
