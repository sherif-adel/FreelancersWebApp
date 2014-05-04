using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using FreeLancers.Service.Translators;
using Freelancers.BLL;
using FreeLancers.Models;
using FreeLancers.Service.Contracts;

namespace FreeLancer.Services
{
	public class UserService : IUserService
	{
		public UserContract GetById(int userId)
		{
			var user = UsersManager.GetById(userId);
			return UsersTranslator.ConvertToUserContract(user);
		}

		public List<UserContract> GetAll()
		{
			var users = UsersManager.GetAll();
			return UsersTranslator.ConvertToUserContract(users).ToList();
		}

		public void Add(UserContract user)
		{
			var userEntity = UsersTranslator.ConvertToUserEntity(user);
			UsersManager.Add(userEntity);
		}

		public void Delete(UserContract user)
		{
			var userEntity = UsersTranslator.ConvertToUserEntity(user);
			UsersManager.Delete(userEntity);
		}

		public void DeleteById(int userId)
		{
			UsersManager.DeleteById(userId);
		}

		public void Update(UserContract user)
		{
			var userEntity = UsersTranslator.ConvertToUserEntity(user);
			UsersManager.Update(userEntity);
		}

		public List<UserContract> Search(System.Linq.Expressions.Expression<Func<UserContract, bool>> criteria)
		{
		//	var userEntity = UsersTranslator.ConverToUserEntity((UserContract)criteria.Parameters[0]);
		//	var param = Expression.Parameter(typeof(User), "p");
		//	var body = criteria.Body;

		//	var lambda = Expression.Lambda<Func<User, bool>>(
		//		body, param);

		//	var users = UsersManager.Search(lambda);
		//	return UsersTranslator.ConverToUserContract(users);

            //  THIS LINE IS TO BUILD WITH NO ERRORS (FOR IMPLEMENTATION ISSUES)
            return UsersTranslator.ConvertToUserContract(UserManager.GetAll()).ToList();
            //  THIS LINE IS TO BUILD WITH NO ERRORS (FOR IMPLEMENTATION ISSUES)
        }

		public List<UserContract> GetUsersByRoleId(int roleId)
		{
			var users = UsersManager.GetUsersByRoleId(roleId);
			return UsersTranslator.ConvertToUserContract(users).ToList();
		}

		public UserContract ValidateLogin(string email, string password)
		{
			var user = UsersManager.ValidateLogin(email, password);
			return UsersTranslator.ConvertToUserContract(user);
		}

		public UserContract ValidateLogin(string email)
		{
			var user = UsersManager.ValidateLogin(email);
			return UsersTranslator.ConverToUserContract(user);
		}

		public bool HasPassword(UserContract user)
		{
			var convertedUser = UsersTranslator.ConverToUserEntity(user);
			return UsersManager.HasPassword(convertedUser);
		}
	}
}
