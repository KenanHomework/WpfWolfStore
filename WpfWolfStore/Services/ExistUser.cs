using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfWolfStore.Model;

namespace WpfWolfStore.Services
{
    public abstract class ExistUser
    {
        public enum ExistResult { UserExist, UserNotFound, IncorrectPassword, UserEmpty };

        public static ExistResult Search(string username, string password)
        {
            User user;
            try { user = UserDataOperations.ReadUser(username); }
            catch (Exception) { return ExistResult.UserEmpty; }

            if (user == null)
                return ExistResult.UserNotFound;

            if (user.Password != password)
                return ExistResult.IncorrectPassword;

            return ExistResult.UserExist;
        }

    }
}
