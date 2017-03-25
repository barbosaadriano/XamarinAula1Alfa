using Xamarin.Forms;

namespace Aula1Alfa1
{
	public partial class Aula1Alfa1Page : ContentPage
	{
		public Aula1Alfa1Page()
		{
			BackgroundColor = Color.Red;

			if (Device.OS == TargetPlatform.iOS)
			{
				//Padding = new Thickness(0,20,0,0);
			}

			InitializeComponent();

			lbl.Text = "Carregado via código";
		}

		void Handle_Clicked(object sender, System.EventArgs e)
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
