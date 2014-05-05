using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreeLancers.Models;

namespace FreeLancers.DAL
{
    public partial class UserDataService
    {

        #region Custom Operations

        public List<User> GetUsersByRoleId(int roleId)
        {
            return DataContext.Users.Where(user => user.RoleID == roleId).ToList();
        }

        public User ValidateLogin(string email, string password)
        {
            return DataContext.Users.FirstOrDefault(user => user.Email == email && user.Password == password);
        }

        public User ValidateLogin(string email)
        {
            return DataContext.Users.FirstOrDefault(user => user.Email == email);
        }

        public bool HasPassword(User user)
        {
            var returnedUser = DataContext.Users.FirstOrDefault(x => x.Email == user.Email);
            if (string.IsNullOrEmpty(returnedUser.Password))
                return false;
            else
                return true;
        }

        #endregion
    }
}
