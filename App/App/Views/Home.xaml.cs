using App.Core;
using App.ViewModels;
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
			InitializeComponent();
            homeViewModel = new HomeViewModel();
            BindingContext = homeViewModel;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await homeViewModel.GetNews();
        }

        private async void My_Articles_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as Articles;
            var details = new ArticleDetails
            {
                BindingContext = item
            };
            await Navigation.PushAsync(details);
        }
    }
}