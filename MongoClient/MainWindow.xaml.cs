using MongoClient.ViewModels;
using Resume.Mongo.Data.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MongoClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainViewModel vm;

        //public MainWindow()
        //{

        //}
        public MainWindow(MainViewModel vm)
        {
            InitializeComponent();
            this.vm = vm;
            this.getData_Btn.Click += this.GetData;
            this.db_Cbx.ItemsSource = this.vm.dbNames;
            this.connectionString_Tb.TextChanged += this.TextChange;
            this.AddDb_Btn.Click += this.Add_DB;
        }

        public void GetData(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(this.vm.ConnectionString))
            {
                foreach (var item in this.vm.Service.GetDatabaseNames().Result)
                {
                    this.vm.dbNames.Add(item);
                }
            }
        }

        public void Add_DB(object sender, EventArgs e)
        {
            this.vm.dbNames.Add(this.newDbName_Tbx.Text.Trim());
        }

        public void TextChange(object sender, TextChangedEventArgs e)
        {
            var textBx = sender as TextBox;

            this.vm.ConnectionString = textBx.Text.Trim();
        }


    }
}
