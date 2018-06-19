using App.Core;
using App.ViewModels;
using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Home : ContentPage
	{
        HomeViewModel homeViewModel;
        public Home ()
		{
			InitializeComponent ();
            homeViewModel = new HomeViewModel();
            BindingContext = homeViewModel;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await homeViewModel.GetNews();
        }
    }
}