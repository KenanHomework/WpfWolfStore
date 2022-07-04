using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfWolfStore.View;
using WpfWolfStore.ViewModel;

namespace WpfWolfStore
{
  
    public enum UserProcessResult { Success,UserNotFound,UserEmpty, IncorrectPassword, FileError}

    public partial class App : Application
    {
        public Container container = new();

        public App()
        {
            Register();
            AssignDataContexts();
        }

        void Register()
        {
            container.RegisterSingleton<EnterWindow>();
            container.RegisterSingleton<LoginGeneralPage>();
            container.RegisterSingleton<EnterWindowVM>();
            container.RegisterSingleton<LoginGeneralPageVM>();

            container.Verify();
        }

        void AssignDataContexts()
        {
            container.GetInstance<EnterWindow>().DataContext = container.GetInstance<EnterWindowVM>();
            container.GetInstance<LoginGeneralPage>().DataContext = container.GetInstance<LoginGeneralPageVM>();
        }
    }
}
