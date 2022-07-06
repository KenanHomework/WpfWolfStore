using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using WpfWolfStore.Model;

public class User
{

    private string username;

    public string Username
    {
        get => username;
        set { username = value; OnPropertyChanged(); }
    }

    private string password;

    public string Password
    {
        get => password;
        set { password = value; OnPropertyChanged(); }
    }

    private MailAddress email;

    public MailAddress Email
    {
        get => email;
        set { email = value; OnPropertyChanged(); }
    }


    private ObservableCollection<Product> card;

    public ObservableCollection<Product> Card
    {
        get { return card; }
        set { card = value; OnPropertyChanged(); }
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
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
        //Card = new();
    }

    public User(string username, string password) : this()
    {
        Username = username;
        Password = password;
    }

    public override string ToString() => $"{Username} ~ {Password} ~ {email}";
}
