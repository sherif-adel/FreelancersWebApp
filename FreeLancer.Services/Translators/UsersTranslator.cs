using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreeLancers.Models;
using FreeLancers.Service.Contracts;

namespace FreeLancers.Service.Translators
{
	public static class UsersTranslator
	{
		#region Users

		public static User ConverToUserEntity(UserContract user)
		{
			User entityUser = new User()
			{
				UserID = user.UserID,
				FirstName = user.FirstName,
				LastName = user.LastName,
				Mobile = user.Mobile,
				Password = user.Password,
				Email = user.Email,
				RoleID = user.RoleID,
				SubCategories = user.SubCategories != null ? SubCategoryTranslator.ConverToSubCategoryEntity(user.SubCategories) : null,
				Role = user.Role != null ? RolesTranslator.ConverToRoleEntity(user.Role) : null
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
			if (user == null)
				return null;

			UserContract contractUser = new UserContract()
			{
				UserID = user.UserID,
				FirstName = user.FirstName,
				LastName = user.LastName,
				Mobile = user.Mobile,
				Password = user.Password,
				Email = user.Email,
				RoleID = user.RoleID,
				//SubCategories = user.SubCategories != null ? SubCategoryTranslator.ConverToSubCategoryContract(user.SubCategories.ToList()) : null,
				//Role = user.Role != null ? RolesTranslator.ConverToRoleContract(user.Role) : null
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
