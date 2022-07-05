using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfWolfStore.Model;
using WpfWolfStore.View;
using WpfWolfStore.ViewModel;

namespace WpfWolfStore
{

    public enum UserProcessResult { Success, UserNotFound, UserEmpty, IncorrectPassword, FileError }

    public partial class App : Application
    {
        //public static Container Container { get; set; }

        //public static Store WolfStore { get; set; }

        //void Register()
        //{
        //    Container = new();

        //    Container.RegisterSingleton<EnterWindow>();
        //    Container.RegisterSingleton<LoginGeneralPage>();
        //    Container.RegisterSingleton<EnterWindowVM>();
        //    Container.RegisterSingleton<LoginGeneralPageVM>();
        //    Container.RegisterSingleton<App>();

        //    Container.Verify();
        //}


    }
}
