using System;
using System.Collections.Generic;
using SimpleInjector;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace WpfWolfStore.ViewModel
{
    public class EnterWindowVM
    {
        Container enterPages = new();




        public bool CurrentIsLogin
        {
            get => CurrentIsLogin;
            set
            {
                if (value)
                {
                }
                else
                {

                }
                CurrentIsLogin = value;
            }

        }

    }
}
