using MongoClient.ViewModels;
using Ninject.Modules;
using Resume.Mongo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoClient
{
    class NinJectBindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IMongoServices>().To<IMongoServices>().InSingletonScope();
            Bind<MainViewModel>().ToSelf();
        }
    }
}
