using System;
using Xamarin.Forms;
using Xamarin06_Sam.ViewModels;

namespace Xamarin06_Sam.Views
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private void ToolbarItem_Clicked(object sender, EventArgs e)
		{
			MainPageViewModel foo = this.BindingContext as MainPageViewModel;
//			foo.Title = "OK";
			foo.Image = "OK.png";
		}
	}
}
