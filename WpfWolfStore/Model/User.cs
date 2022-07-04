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

        public List<Product> Card
        {
            get { return (List<Product>)GetValue(CardProperty); }
            set { SetValue(CardProperty, value); }
        }


        public static readonly DependencyProperty CardProperty =
            DependencyProperty.Register("Card", typeof(List<Product>), typeof(User));

        public static readonly DependencyProperty UsernameProperty =
            DependencyProperty.Register("Username", typeof(string), typeof(User));

        public static readonly DependencyProperty EmailProperty =
            DependencyProperty.Register("Email", typeof(MailAddress), typeof(User));

        public static readonly DependencyProperty PasswordProperty =
            DependencyProperty.Register("Password", typeof(string), typeof(User));

        #endregion

        #region Methods

        public void Buy() => Card.Clear();

        public void AddToCard(Product product) { if (!Card.Contains(product)) Card.Add(product); }

        public void RemoveFromCard(Product product) => Card.Remove(product);

        #endregion

        public User(string username, string password, MailAddress email) : this()
        {
            Username = username;
            Password = password;
            Email = email;
        }
        public User(string username, string password, string email) : this()
        {
            Username = username;
            Password = password;
            Email = new(email);
        }

        User()
        {
            Username = string.Empty;
            Password = string.Empty;
            Card = new();
        }

        public User(string username, string password):this()
        {
            Username = username;
            Password = password;
        }
    }
}
