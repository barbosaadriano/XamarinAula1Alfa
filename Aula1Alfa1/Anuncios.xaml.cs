using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace Aula1Alfa1
{
	public partial class Anuncios : ContentPage
	{
		public ObservableCollection<Anuncio> Dados {get;set;}

		public Anuncios()
		{
			// jamais coloque código pesado aqui, pois a tela fica em branco
			BindingContext = this;

			Dados = new ObservableCollection<Anuncio>();

			InitializeComponent();
		}

		// evento disparado quando a tela está carregada
		protected override void OnAppearing()
		{
			CarregaDados();
		}

		async Task CarregaDados()
		{
			var url = "https://classidiario.odiario.com/api/busca/?busca=";

			var web = new HttpClient();
			var json = await web.GetStringAsync(url);

			var anuncios = JsonConvert.DeserializeObject<List<Anuncio>>(json);

			foreach (var anuncio in anuncios)
			{
				Dados.Add(anuncio);
			}
		}

		void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			if (e.SelectedItem == null)
				return;
			
			var anuncio = (Anuncio)e.SelectedItem;

			Navigation.PushAsync(new Detalhes(anuncio));

			// quem sabe?
			((ListView)sender).SelectedItem = null;
		}
		public async Task <List<Anuncio>> All()
		{
		  
		  RestUrl = "https://classidiario.odiario.com/api/anuncio/1183935"
		  var uri = new Uri (string.Format (Constants.RestUrl, string.Empty));
		  var response = await client.GetAsync (uri);
		  if (response.IsSuccessStatusCode) {
			  var content = await response.Content.ReadAsStringAsync ();
			  Items = JsonConvert.DeserializeObject <List<Anuncio>> (content);
			  return items;
		  }
		}
	}
}
