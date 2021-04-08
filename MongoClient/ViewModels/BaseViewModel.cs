using Resume.Mongo.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MongoClient.ViewModels
{
    public abstract class BaseViewModel
    {
        private string connectionString;
        public MongoServices Service { get; set; }
        public string ConnectionString
        {
            get
            {
                return this.connectionString;
            }
            set
            {
                this.connectionString = value;
                this.Service = new MongoServices(value);
            }
        }

        public BaseViewModel(MongoServices service)
        {
            this.Service = service;
        }
    }
}
