using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Xamarin.Forms;

namespace Aula1Alfa1
{
	public partial class Pagina2 : ContentPage
	{
		// essa collection será observada. Toda vez que um
		// elemento for incluido ou atualizado, a tela será atualizada
		public ObservableCollection<Pessoa> Nomes { get; set; }

		public Pagina2()
		{
			BindingContext = this;

			Nomes = new ObservableCollection<Pessoa>() {
				new Pessoa {Nome = "Lucas", Sobrenome = "Lanceloti"},
				new Pessoa {Nome = "Luzia" }
			};
			
			InitializeComponent();
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			Nomes.Add(new Pessoa { 
				Nome = DateTime.Now.Ticks.ToString() 
			});
			
			// volta uma página
			//Navigation.PopAsync();

			// volta todas as paginas
			//Navigation.PopToRootAsync();
		}
	}

	public class Pessoa
	{
		public string Nome { get; set; }
		public string Sobrenome
		{
			get;
			set;
		}
		public string NomeCompleto
		{
			get
			{
				return Nome + " " + Sobrenome;
			}
		}
	}
}
