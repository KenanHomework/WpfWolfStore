using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfWolfStore.Model
{
    public class Product
    {
        public static int GlobalId = 0;

        #region Properties

        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; OnPropertyChanged(); }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged(); }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; OnPropertyChanged(); }
        }

        private float price;

        public float Price
        {
            get { return price; }
            set { price = value; OnPropertyChanged(); }
        }

        private string imageAdress;

        public string ImageAdress
        {
            get { return imageAdress; }
            set { imageAdress = value; OnPropertyChanged(); }
        }




        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        #endregion

        public Product(string name, string description, float price, string imageAdress)
        {
            Name = name;
            Description = description;
            Price = price;
            ImageAdress = imageAdress;
            ID = ++GlobalId;
        }

        public Product() { }

        public override string ToString() => ID.ToString();
    }
}
