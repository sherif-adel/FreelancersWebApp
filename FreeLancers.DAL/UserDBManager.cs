using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreeLancers.Models;
using FreeLancers.Log;

namespace FreeLancers.DAL
{
    public partial class UserDataService
    {

        #region Custom Operations

        public List<User> GetUsersByRoleId(int roleId)
        {
            try
            {
                return DataContext.Users.Where(user => user.RoleID == roleId).ToList();
            }
            catch (Exception ex)
            {
                ExceptionHandler.LogException(ex, System.Reflection.MethodInfo.GetCurrentMethod().Name, FreeLancers.Log.ExceptionHandler.LogThreshold.ERROR);
                throw ex;
            }
        }

        public User ValidateLogin(string email, string password)
        {
            try
            {
                return DataContext.Users.FirstOrDefault(user => user.Email == email && user.Password == password);
            }
            catch (Exception ex)
            {
                ExceptionHandler.LogException(ex, System.Reflection.MethodInfo.GetCurrentMethod().Name, FreeLancers.Log.ExceptionHandler.LogThreshold.ERROR);
                throw ex;
            }
        }

        public User ValidateLogin(string email)
        {
            try
            {
                return DataContext.Users.FirstOrDefault(user => user.Email == email);
            }
            catch (Exception ex)
            {
                ExceptionHandler.LogException(ex, System.Reflection.MethodInfo.GetCurrentMethod().Name, FreeLancers.Log.ExceptionHandler.LogThreshold.ERROR);
                throw ex;
            }
        }

        public bool HasPassword(User user)
        {
            try
            {
                var returnedUser = DataContext.Users.FirstOrDefault(x => x.Email == user.Email);
                if (string.IsNullOrEmpty(returnedUser.Password))
                    return false;
                else
                    return true;
            }
            catch (Exception ex)
            {
                ExceptionHandler.LogException(ex, System.Reflection.MethodInfo.GetCurrentMethod().Name, FreeLancers.Log.ExceptionHandler.LogThreshold.ERROR);
                throw ex;
            }
        }

        #endregion
    }
}
