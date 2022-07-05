using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfWolfStore.Model
{
    public class User
    {

        private string username;

        public string Username
        {
            get => username;
            set { username = value; }
        }

        private string password;

        public string Password
        {
            get => password;
            set { password = value; }
        }

        private MailAddress email;

        public MailAddress Email
        {
            get => email;
            set { email = value; }
        }


        private List<Product> card;

        public List<Product> Card
        {
            get { return card; }
            set { card = value; }
        }



        public void Buy() => Card.Clear();

        public void AddToCard(Product product) { if (!Card.Contains(product)) Card.Add(product); }

        public void RemoveFromCard(Product product) => Card.Remove(product);


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

        public User(string username, string password) : this()
        {
            Username = username;
            Password = password;
        }

        public override string ToString() => $"{Username} ~ {Password} ~ {email}";
    }
}
