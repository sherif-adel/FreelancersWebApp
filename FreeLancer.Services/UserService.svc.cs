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
using FreeLancers.Service.Translators;

namespace FreeLancer.Services
{
	public class UserService : IUserService
	{
		public UserContract GetById(int userId)
		{
			var user = UsersManager.GetById(userId);
			return Translator.ConverToUserContract(user);
		}

		public List<UserContract> GetAll()
		{
			var users = UsersManager.GetAll();
			return Translator.ConverToUserContract(users);
		}

		public void Add(UserContract user)
		{
			var userEntity = Translator.ConverToUserEntity(user);
			UsersManager.Add(userEntity);
		}

		public void Delete(UserContract user)
		{
			var userEntity = Translator.ConverToUserEntity(user);
			UsersManager.Delete(userEntity);
		}

		public void DeleteById(int userId)
		{
			UsersManager.DeleteById(userId);
		}

		public void Update(UserContract user)
		{
			var userEntity = Translator.ConverToUserEntity(user);
			UsersManager.Update(userEntity);
		}

		//public List<UserContract> Search(System.Linq.Expressions.Expression<Func<UserContract, bool>> criteria)
		//{
		//	var userEntity = Translator.ConverToUserEntity((UserContract)criteria.Parameters[0]);
		//	var param = Expression.Parameter(typeof(User), "p");
		//	var body = criteria.Body;

		//	var lambda = Expression.Lambda<Func<User, bool>>(
		//		body, param);

		//	var users = UsersManager.Search(lambda);
		//	return Translator.ConverToUserContract(users);
		//}

		public List<UserContract> GetUsersByRoleId(int roleId)
		{
			var users = UsersManager.GetUsersByRoleId(roleId);
			return Translator.ConverToUserContract(users);
		}

		public UserContract ValidateLogin(string email, string password)
		{
			var user = UsersManager.ValidateLogin(email, password);
			return Translator.ConverToUserContract(user);
		}
	}
}
