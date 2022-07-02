using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfWolfStore.Model
{
    public class User : DependencyObject
    {
        /* Properties */
        #region Properties

        public string Username
        {
            get { return (string)GetValue(UsernameProperty); }
            set { SetValue(UsernameProperty, value); }
        }

        public string Password
        {
            get { return (string)GetValue(PasswordProperty); }
            set { SetValue(PasswordProperty, value); }
        }

        public MailAddress Email
        {
            get { return (MailAddress)GetValue(EmailProperty); }
            set { SetValue(EmailProperty, value); }
        }


        // Using a DependencyProperty as the backing store for Username.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty UsernameProperty =
            DependencyProperty.Register("Username", typeof(string), typeof(User));

        // Using a DependencyProperty as the backing store for Email.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty EmailProperty =
            DependencyProperty.Register("Email", typeof(MailAddress), typeof(User));

        // Using a DependencyProperty as the backing store for Password.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PasswordProperty =
            DependencyProperty.Register("Password", typeof(string), typeof(User));

        public User(string username, string password, MailAddress email)
        {
            Username = username;
            Password = password;
            Email = email;
        }
        public User(string username, string password, string email)
        {
            Username = username;
            Password = password;
            Email = new(email);
        }

        User()
        {
            Username = string.Empty;
            Password = string.Empty;
        }

        #endregion




    }
}
