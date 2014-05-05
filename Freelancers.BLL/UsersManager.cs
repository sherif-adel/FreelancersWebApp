using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreeLancers.DAL;
using FreeLancers.Models;
using Freelancers.BLL.Enums;

namespace Freelancers.BLL
{
    public partial class UserManager
    {
        public List<User> GetUsersByRoleId(int roleId)
        {
            return _userDataService.GetUsersByRoleId(roleId);
        }

        public User ValidateLogin(string email, string password)
        {
            return _userDataService.ValidateLogin(email, password);
        }

        public User ValidateLogin(string email)
        {
            return _userDataService.ValidateLogin(email);
        }

        public bool HasPassword(User user)
        {
            return _userDataService.HasPassword(user);
        }
    }
}
