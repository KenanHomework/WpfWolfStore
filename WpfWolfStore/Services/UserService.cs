using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WpfWolfStore;
using WpfWolfStore.Model;

namespace WpfWolfStore.Services
{
    public class UserService
    {
        public static UserProcessResult Search(string username, string password)
        {
            User user;
            try { user = ReadUser(username); }
            catch (Exception) { return UserProcessResult.UserEmpty; }

            if (user == null)
                return UserProcessResult.UserNotFound;

            if (user.Password != password)
                return UserProcessResult.IncorrectPassword;

            return UserProcessResult.Success;
        }

        public static UserProcessResult Search(User user)
        {
            try { user = ReadUser(user.Username); }
            catch (Exception) { return UserProcessResult.UserEmpty; }

            if (user == null)
                return UserProcessResult.UserNotFound;

            if (user.Password != user.Password)
                return UserProcessResult.IncorrectPassword;

            return UserProcessResult.Success;
        }

        public static void WriteUser(User user)
        {
            if (!Directory.Exists("Data"))
                Directory.CreateDirectory("Data");
            JSONService.Write($"Data/{user.Username}.json", user);
        }

        public static User ReadUser(string username)
        {
            if (!File.Exists($"Data/{username}.json"))
                return null;

            try
            {
                return JSONService.Read<User>($"Data/{username}.json");
            }
            catch (Exception) { throw; }
        }
    }
}
