using Xamarin.Forms;

namespace Aula1Alfa1
{
	public partial class Aula1Alfa1Page : ContentPage
	{
		public string Email { get; set; }
		public string Senha { get; set; }
		public Command CmdNavegar { get; set; }

		public Aula1Alfa1Page()
		{
			InitializeComponent();

			// via x:Name
			lbl.Text = "Carregado via código";

			Email = "leandro@lanceloti.com.br";

			CmdNavegar = new Command(Navegar);

			//mvvm
			BindingContext = this;
		}

		void Navegar()
		{
			//DisplayAlert("Clicou", "Você clicou no botão", "ok");
			Navigation.PushAsync(new Pagina2());
		}

		void VaiPopUp(object sender, System.EventArgs e)
		{
			Navigation.PushModalAsync(new Pagina3());
		}
	}
}
