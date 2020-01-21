using BasicMvvm;
using BasicMvvm.Commands;
using JigayasaApp.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using Windows.UI.Popups;

namespace JigayasaApp.ViewModels
{
    public class MainViewModel : BindableBase
    {
        public DelegateCommand Mycommand { get; set; }

        public MainViewModel()
        {
            Mycommand = new DelegateCommand(OnPropertySChanged);
        }

        private void OnPropertySChanged()
        {
            MessageDialog messageDialog = new MessageDialog("I am Clicked", "JIgya");
            _ = messageDialog.ShowAsync();
        }
        private ObservableCollection<QueryConfig> _myList;


        public ObservableCollection<QueryConfig> MyList
        {
            get { return _myList; }
            set
            {
                _myList = value;
                OnPropertyChanged();
            }
        }

        private string _mylabel;


        public string Mylabel
        {
            get { return _mylabel; }
            set
            {
                _mylabel = value;
                GetMyDataAsync();
                OnPropertyChanged();
            }
        }

        private async System.Threading.Tasks.Task GetMyDataAsync()
        {
            HttpClient client = new HttpClient();
            var json = await client.GetStringAsync("http://localhost:54891/api/QueryConfigs");
            var l = JsonConvert.DeserializeObject<List<QueryConfig>>(json);
            MyList = new ObservableCollection<QueryConfig>(l);
        }
        private QueryConfig _myItem;

        /////////////////////////////////public properties by Avnish's property generator utility////////////////////////

        public QueryConfig MyItem
        {
            get { return _myItem; }
            set
            {
                _myItem = value;
                OnPropertyChanged();
            }
        }
        private string _welcome;

        public string Welcome
        {
            get { return _welcome; }
            set
            {
                _welcome = value;
                Mylabel = value;
                OnPropertyChanged();

            }
        }

    }
}
