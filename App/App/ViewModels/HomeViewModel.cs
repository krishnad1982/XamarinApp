using App.Core;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;

namespace App.ViewModels
{
    public class HomeViewModel: INotifyPropertyChanged
    {
        private readonly HttpUtility _httpUtility;

        public HomeViewModel()
        {
            _httpUtility = new HttpUtility();
        }

        public ObservableCollection<Articles> Articles { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public async Task GetNews()
        {
            var articles= await _httpUtility.GetNews();
            Articles = new ObservableCollection<Articles>(articles.Articles);
            OnPropertyChanged("Articles");
        }
    }
}
