using App.Models;
using App.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace App.ViewModels
{
    public class HomeViewModel
    {

        public string Name { get; set; } = "Krishna";
        public List<Articles> _articles;
        private readonly HttpUtility _httpUtility;

        public HomeViewModel()
        {
            _httpUtility = new HttpUtility();
        }

        public List<Articles> News
        {
            get
            {
                GetNews();
                return _articles;
            }
            set
            {
                _articles = value;
            }
        }

        private async void GetNews()
        {
            var news = await _httpUtility.GetNews();
            _articles = news.Articles;
        }
    }
}
