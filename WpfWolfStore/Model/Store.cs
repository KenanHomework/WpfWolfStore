using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfWolfStore.Services;

namespace WpfWolfStore.Model
{
    public class Store : DependencyObject
    {

        #region Properties

        public User User
        {
            get { return (User)GetValue(UserProperty); }
            set { SetValue(UserProperty, value); }
        }

        public List<Product> Products
        {
            get { return (List<Product>)GetValue(ProductsProperty); }
            set { SetValue(ProductsProperty, value); }
        }

        public bool Remember
        {
            get { return (bool)GetValue(RememberProperty); }
            set { SetValue(RememberProperty, value); }
        }



        public static readonly DependencyProperty RememberProperty =
            DependencyProperty.Register("Remember", typeof(bool), typeof(Store));

        public static readonly DependencyProperty UserProperty =
            DependencyProperty.Register("User", typeof(User), typeof(Store));

        public static readonly DependencyProperty ProductsProperty =
            DependencyProperty.Register("Products", typeof(List<Product>), typeof(Store));


        #endregion

        #region Methods

        public void Load()
        {
            try
            {
                Store temp = JSONService.Read<Store>("/data/store.json");
                User = temp.User;
                Products = temp.Products;
                Remember = temp.Remember;

            }
            catch (Exception)
            { }
        }

        public void Save() => JSONService.Write("/data/store.json", this);

        public UserProcessResult Login(User user)
        {
            UserProcessResult result = UserService.Search(user);
            if (result == UserProcessResult.Success)
                User = UserService.ReadUser(user.Username);

            return result;
        }

        public UserProcessResult SigIn(User user)
        {
            UserProcessResult result = UserService.Search(user);
            if (result == UserProcessResult.UserNotFound)
            {
                User = UserService.ReadUser(user.Username);
                return UserProcessResult.Success;
            }

            return result;
        }

        public void Exit() => User = null;

        #endregion

        public Store(User user) : this()
        {
            User = user;
        }

        public Store()
        {
            if (!Directory.Exists("Data"))
                Directory.CreateDirectory("Data");
            User = null;
            Products = new();
            Remember = false;
        }
    }
}
