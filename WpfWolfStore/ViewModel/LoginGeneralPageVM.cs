using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfWolfStore.Interfaces;

namespace WpfWolfStore.ViewModel
{
    public class LoginGeneralPageVM : DependencyObject, IEnterPage
    {

        #region Properties

        public string Username
        {
            get { return (string)GetValue(MyPropertyProperty); }
            set { SetValue(MyPropertyProperty, value); }
        }

        public string Password
        {
            get { return (string)GetValue(PasswordProperty); }
            set { SetValue(PasswordProperty, value); }
        }

        public static readonly DependencyProperty MyPropertyProperty =
            DependencyProperty.Register("MyProperty", typeof(string), typeof(LoginGeneralPageVM));

        public static readonly DependencyProperty PasswordProperty =
            DependencyProperty.Register("Password", typeof(string), typeof(LoginGeneralPageVM));

        #endregion

        public LoginGeneralPageVM()
        {
            Username = String.Empty;
            Password = String.Empty;
        }

        public bool AllInfoCorrect()
        {
            throw new NotImplementedException();
        }
    }
}
