﻿using Xamarin.Forms;

namespace Aula1Alfa1
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			//MainPage = new Aula1Alfa1Page();
			MainPage = new NavigationPage(new Aula1Alfa1Page());
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
