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

		public static Role ConverToRoleEntity(RoleContract role)
		{
			Role entityRole = new Role()
			{
				RoleID = role.RoleID,
				RoleName = role.RoleName,
				Status = StatusTranslator.ConverToStatusEntity(role.Status.ToList()),
				Users =UsersTranslator.ConverToUserEntity(role.Users.ToList())
			};
			return entityRole;
		}

		public static List<Role> ConverToRoleEntity(List<RoleContract> roles)
		{
			List<Role> newRoles = new List<Role>();
			foreach (var role in roles)
			{
				newRoles.Add(ConverToRoleEntity(role));
			}
			return newRoles;
		}

		#endregion

		#region ToContract

		public static RoleContract ConverToRoleContract(Role role)
		{
			RoleContract roleContract = new RoleContract()
			{
				RoleID = role.RoleID,
				RoleName = role.RoleName,
				Status = StatusTranslator.ConverToStatusContract(role.Status.ToList()),
				Users = UsersTranslator.ConverToUserContract(role.Users.ToList())
			};
			return roleContract;
		}

		public static List<RoleContract> ConverToRoleContract(List<Role> roles)
		{
			List<RoleContract> newRoles = new List<RoleContract>();
			foreach (var role in roles)
			{
				newRoles.Add(ConverToRoleContract(role));
			}
			return newRoles;
		}

		#endregion
	}
}