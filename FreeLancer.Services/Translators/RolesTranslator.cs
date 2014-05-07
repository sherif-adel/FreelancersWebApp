using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FreeLancers.Models;
using FreeLancers.Service.Contracts;

namespace FreeLancers.Service.Translators
{
	public class RolesTranslator
	{
		#region ToEntity

		public static Role ConvertToRoleEntity(RoleContract role)
		{
			Role entityRole = new Role()
			{
				RoleID = role.RoleID,
				RoleName = role.RoleName,
				Status = StatusTranslator.ConvertToStatusEntity(role.Status.ToList()),
				//Users =UsersTranslator.ConvertToUserEntity(role.Users.ToList())
			};
			return entityRole;
		}

		public static List<Role> ConvertToRoleEntity(List<RoleContract> roles)
		{
			List<Role> newRoles = new List<Role>();
			foreach (var role in roles)
			{
				newRoles.Add(ConvertToRoleEntity(role));
			}
			return newRoles;
		}

		#endregion

		#region ToContract

		public static RoleContract ConvertToRoleContract(Role role)
		{
			RoleContract roleContract = new RoleContract()
			{
				RoleID = role.RoleID,
				RoleName = role.RoleName,
				Status = StatusTranslator.ConvertToStatusContract(role.Status.ToList()),
				//Users = UsersTranslator.ConvertToUserContract(role.Users.ToList())
			};
			return roleContract;
		}

		public static List<RoleContract> ConvertToRoleContract(List<Role> roles)
		{
			List<RoleContract> newRoles = new List<RoleContract>();
			foreach (var role in roles)
			{
				newRoles.Add(ConvertToRoleContract(role));
			}
			return newRoles;
		}

		#endregion
	}
}