using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Freelancers.BLL;
using FreeLancers.Models;
using FreeLancers.Service.Contracts;
using Freelancers.BLL.Common;

namespace FreeLancer.Services
{
    public class UserService : IUserService
    {
        public UserContract GetById(int userId)
        {
            using (var dbConnector = new DBConnector())
            {
                UserManager userManager = new UserManager(dbConnector.DataContext);
                var user = userManager.GetById(userId);
                return UsersTranslator.ConvertToUserContract(user);
            }
        }

        public List<UserContract> GetAll()
        {
            using (var dbConnector = new DBConnector())
            {
                UserManager userManager = new UserManager(dbConnector.DataContext);
                var users = userManager.GetAll();
                return UsersTranslator.ConvertToUserContract(users).ToList();
            }
        }

        public void Add(UserContract user)
        {
            using (var dbConnector = new DBConnector())
            {
                UserManager userManager = new UserManager(dbConnector.DataContext);
                var userEntity = UsersTranslator.ConvertToUserEntity(user);
                userManager.Add(userEntity);
            }
        }

        public void Delete(UserContract user)
        {
            using (var dbConnector = new DBConnector())
            {
                UserManager userManager = new UserManager(dbConnector.DataContext);
                var userEntity = UsersTranslator.ConvertToUserEntity(user);
                userManager.Delete(userEntity);
            }
        }

        public void DeleteById(int userId)
        {
            using (var dbConnector = new DBConnector())
            {
                UserManager userManager = new UserManager(dbConnector.DataContext);
                userManager.Delete(userId);
            }
        }

        public void Update(UserContract user)
        {
            using (var dbConnector = new DBConnector())
            {
                UserManager userManager = new UserManager(dbConnector.DataContext);
                var userEntity = UsersTranslator.ConvertToUserEntity(user);
                userManager.Update(userEntity);
            }
        }

        public List<UserContract> Search(Func<dynamic, bool> criteria)
        {
            using (var dbConnector = new DBConnector())
            {
                UserManager userManager = new UserManager(dbConnector.DataContext);
                Func<User, bool> userCriteria = (Func<User, bool>)criteria;
                return UsersTranslator.ConvertToUserContract(userManager.Search(userCriteria)).ToList();
            }
        }

        public List<UserContract> GetUsersByRoleId(int roleId)
        {
            using (var dbConnector = new DBConnector())
            {
                UserManager userManager = new UserManager(dbConnector.DataContext);
                var users = userManager.GetUsersByRoleId(roleId);
                return UsersTranslator.ConvertToUserContract(users).ToList();
            }
        }

        public UserContract ValidateLogin(string email, string password)
        {
            using (var dbConnector = new DBConnector())
            {
                UserManager userManager = new UserManager(dbConnector.DataContext);
                var user = userManager.ValidateLogin(email, password);
                return UsersTranslator.ConvertToUserContract(user);
            }
        }

        public UserContract ValidateLogin(string email)
        {
            using (var dbConnector = new DBConnector())
            {
                UserManager userManager = new UserManager(dbConnector.DataContext);
                var user = userManager.ValidateLogin(email);
                return UsersTranslator.ConvertToUserContract(user);
            }
        }

        public bool HasPassword(UserContract user)
        {
            using (var dbConnector = new DBConnector())
            {
                UserManager userManager = new UserManager(dbConnector.DataContext);
                var convertedUser = UsersTranslator.ConvertToUserEntity(user);
                return userManager.HasPassword(convertedUser);
            }
        }
    }
}
