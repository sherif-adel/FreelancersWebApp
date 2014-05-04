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
	public static class UsersManager
	{
		public static User GetById(int userId)
		{
			return UserDataService.GetById(userId);
		}

		public static List<User> GetAll()
		{
			return UserDataService.GetAll();
		}

		public static void Add(User user)
		{
			UserDataService.Add(user);
		}

		public static void Delete(User user)
		{
			UserDataService.Delete(user);
		}

		public static void DeleteById(int userId)
		{
			UserDataService.DeleteById(userId);
		}

		public static void Update(User user)
		{
			UserDataService.Update(user);
		}

		public static void Search(System.Linq.Expressions.Expression<Func<User, bool>> criteria)
		{
			UserDataService.Search(criteria);
		}

		public static List<User> GetUsersByRoleId(int roleId)
		{
			return UserDataService.GetUsersByRoleId(roleId);
		}

		public static User ValidateLogin(string email, string password)
		{
			return UserDataService.ValidateLogin(email, password);
		}

		public static User ValidateLogin(string email)
		{
			return UserDataService.ValidateLogin(email);
		}

		public static bool HasPassword(User user)
		{
			return UserDataService.HasPassword(user);
		}
	}
}
