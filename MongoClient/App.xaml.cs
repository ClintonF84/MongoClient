using MongoClient.ViewModels;
using Ninject;
using Resume.Mongo.Data;
using Resume.Mongo.Data.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows;

namespace MongoClient
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static IKernel Container { get; set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            Container = new StandardKernel();
            Container.Load(Assembly.GetExecutingAssembly());
            base.OnStartup(e);

            MainWindow mw = new MainWindow(Container.Get<MainViewModel>());
            mw.Show();
        }
    }
}
