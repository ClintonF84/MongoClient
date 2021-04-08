using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Resume.Mongo.Data.Services;
using System.Windows;
using System.Windows.Controls;

namespace MongoClient.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public ObservableCollection<string> dbNames;

        public MainViewModel(MongoServices service) : base(service)
        {
            this.dbNames = new ObservableCollection<string>();
        }
    }
}
