using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreeLancers.Models;
using FreeLancers.Service.Contracts;

namespace FreeLancer.Services.Translators
{
	public static class UsersTranslator
	{
		#region Users

		public static User ConverToUserEntity(UserContract user)
		{
			User entityUser = new User(){
				UserID = user.UserID,
				FirstName = user.FirstName,
				LastName = user.LastName,
				Mobile = user.Mobile,
				Password = user.Password,
				Email = user.Email,
				RoleID = user.RoleID
			};
			return entityUser;
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
			UserContract contractUser = new UserContract()
			{
				UserID = user.UserID,
				FirstName = user.FirstName,
				LastName = user.LastName,
				Mobile = user.Mobile,
				Password = user.Password,
				Email = user.Email,
				RoleID = user.RoleID
			};
			return contractUser;
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
