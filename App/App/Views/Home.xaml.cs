﻿using App.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Home : ContentPage
	{
		public Home ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            HomeViewModel hm = new HomeViewModel();
            var d=hm.News;
            base.OnAppearing();
        }
    }
}