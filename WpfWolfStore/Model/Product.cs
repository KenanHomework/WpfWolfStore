using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfWolfStore.Model
{
    public class Product : DependencyObject
    {
        public static int GlobalId = 0;

        #region Properties

        public int Id
        {
            get { return (int)GetValue(IdProperty); }
            set { SetValue(IdProperty, value); }
        }

        public string Name
        {
            get { return (string)GetValue(NameProperty); }
            set { SetValue(NameProperty, value); }
        }

        public string Description
        {
            get { return (string)GetValue(DescriptionProperty); }
            set { SetValue(DescriptionProperty, value); }
        }

        public float Price
        {
            get { return (float)GetValue(PriceProperty); }
            set { SetValue(PriceProperty, value); }
        }

        public string ImageAdress
        {
            get { return (string)GetValue(ImageAdressProperty); }
            set { SetValue(ImageAdressProperty, value); }
        }


        public static readonly DependencyProperty IdProperty =
             DependencyProperty.Register("Id", typeof(int), typeof(Product));

        public static readonly DependencyProperty NameProperty =
            DependencyProperty.Register("Name", typeof(string), typeof(Product));

        public static readonly DependencyProperty DescriptionProperty =
            DependencyProperty.Register("Description", typeof(string), typeof(Product));

        public static readonly DependencyProperty ImageAdressProperty =
            DependencyProperty.Register("ImageAdress", typeof(string), typeof(Product));

        public static readonly DependencyProperty PriceProperty =
            DependencyProperty.Register("Price", typeof(float), typeof(Product));

        #endregion

        public Product(string name, string description, float price, string imageAdress)
        {
            Name = name;
            Description = description;
            Price = price;
            ImageAdress = imageAdress;
            Id = ++GlobalId;
        }

        public override string ToString() => Id.ToString();
    }
}
