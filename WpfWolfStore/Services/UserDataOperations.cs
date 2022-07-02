using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WpfWolfStore.Model;

namespace WpfWolfStore.Services
{
    public abstract class UserDataOperations
    {
        public static void WriteUser(User user)
        {
            if (!Directory.Exists("Data"))
                Directory.CreateDirectory("Data");
            JSONService.Write($"Data/{user.Username}.json", JsonSerializer.Serialize(user));
        }

        public static User ReadUser(string username)
        {
            if (!File.Exists($"Data/{username}.json"))
                return null;

            try
            {
                return JsonSerializer.Deserialize<User>(File.ReadAllText($"Data/{username}.json"));
            }
            catch (Exception) { throw; }
        }
    }
}
