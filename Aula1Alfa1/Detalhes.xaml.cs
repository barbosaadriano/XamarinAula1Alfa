using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Aula1Alfa1
{
	public partial class Detalhes : CarouselPage
	{
		public Anuncio Anuncio { get; set; }
		
		public Detalhes(Anuncio anuncio)
		{
			this.Anuncio = anuncio;
			BindingContext = this;
			ItemsSource = Anuncio.All;			
			InitializeComponent();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
		}
	}
}
