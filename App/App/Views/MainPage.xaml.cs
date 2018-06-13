using App.Models;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        public List<MainMenuItems> MainMenuItems { get; set; }
        public MainPage()
        {
            BindingContext = this;

            // Build the Menu
            MainMenuItems = new List<MainMenuItems>
            {
               new MainMenuItems() { Title = "About", Icon = "menu_about.png", TargetType = typeof(About) },
               new MainMenuItems() { Title = "Contact", Icon = "menu_contact.png", TargetType = typeof(Contact) }
            };

            // Set the default page, this is the "home" page.
            Detail = new NavigationPage(new About());

            InitializeComponent();
        }

        private void MenuListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MainMenuItems;
            if (item != null)
            {
                if (item.Title.Equals("About"))
                {
                    Detail = new NavigationPage(new About());
                }
                else if (item.Title.Equals("Contact"))
                {
                    Detail = new NavigationPage(new Contact());
                }

                MenuListView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}