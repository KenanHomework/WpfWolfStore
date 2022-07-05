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
    public class Store 
    {

        #region Properties

        public User User { get; set; }

        public List<Product> Products { get; set; }
        public bool Remember { get; set; }

        #endregion

        #region Methods

        public void Load()
        {
            try
            {
                Store temp = JSONService.Read<Store>("data/store.json");
                User = temp.User;
                Products = temp.Products;
                Remember = temp.Remember;

            }
            catch (Exception)
            { }
        }

        public void Save() => JSONService.Write("data/store.json", this);

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
                User = user;
                return UserProcessResult.Success;
            }

            return result;
        }

        public void Exit() => User = null;

        #endregion

        public Store(User user, bool load = true) : this(load)
        {
            User = user;

        }
        public Store(bool load) : this()
        {
            if (load)
                Load();
        }
        public Store()
        {
            if (!Directory.Exists("Data"))
                Directory.CreateDirectory("Data");
            User = null;
            Products = new();
            Remember = false;
        }
        ~Store()
        {
            Save();
        }
    }
}
