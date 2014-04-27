using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreeLancers.Models;
using FreeLancers.Service.Contracts;

namespace FreeLancers.Service.Translators
{
	public static class Translator
	{ 
		#region Users

		public static User ConverToUserEntity(UserContract user)
		{
			User newUser = new User()
			{
				UserID = user.UserID,
				FirstName = user.FirstName,
				LastName = user.LastName,
				Email = user.Email,
				Mobile = user.Mobile,
				Password = user.Password,
				RoleID = user.RoleID,
			};
			return newUser;
		}

		public static List<User> ConverToUserEntity(List<UserContract> users)
		{
			List<User> newUsers = new List<User>();
			foreach (var user in users)
			{
				newUsers.Add(ConverToUserEntity(user));
			}
			return newUsers;
		}

		public static UserContract ConverToUserContract(User user)
		{
			UserContract newUser = new UserContract()
			{
				UserID = user.UserID,
				FirstName = user.FirstName,
				LastName = user.LastName,
				Email = user.Email,
				Mobile = user.Mobile.HasValue ? user.Mobile.Value : 0,
				Password = user.Password,
				RoleID = user.RoleID,
			};
			return newUser;
		}

		public static List<UserContract> ConverToUserContract(List<User> users)
		{
			List<UserContract> newUsers = new List<UserContract>();
			foreach (var user in users)
			{
				newUsers.Add(ConverToUserContract(user));
			}
			return newUsers;
		}

		#endregion
	}
}
