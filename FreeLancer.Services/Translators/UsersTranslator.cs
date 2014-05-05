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

		public static User ConvertToUserEntity(UserContract user)
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
				SubCategories = user.SubCategories != null ? SubCategoryTranslator.ConvertToSubCategoryEntity(user.SubCategories) : null,
				Role = user.Role != null ? RolesTranslator.ConvertToRoleEntity(user.Role) : null
			};
			return entityUser;
		}

		public static List<User> ConvertToUserEntity(List<UserContract> users)
		{
			List<User> newUsers = new List<User>();
			foreach (var user in users)
			{
				newUsers.Add(ConvertToUserEntity(user));
			}
			return newUsers;
		}

		public static UserContract ConvertToUserContract(User user)
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
				//SubCategories = user.SubCategories != null ? SubCategoryTranslator.ConvertToSubCategoryContract(user.SubCategories.ToList()) : null,
				//Role = user.Role != null ? RolesTranslator.ConvertToRoleContract(user.Role) : null
			};
			return contractUser;
		}

		public static List<UserContract> ConvertToUserContract(List<User> users)
		{
			List<UserContract> newUsers = new List<UserContract>();
			foreach (var user in users)
			{
				newUsers.Add(ConvertToUserContract(user));
			}
			return newUsers;
		}

		#endregion
	}
}
