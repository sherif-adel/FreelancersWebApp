using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreeLancers.Models;

namespace FreeLancers.DAL
{
	public partial class UserDataService
	{

		#region Custom Operations

		public static List<User> GetUsersByRoleId(int roleId)
		{
			using (FreeLancersEntities entities = new FreeLancersEntities())
			{
				return entities.Users.Where(user => user.RoleID == roleId).ToList();
			}
		}

		public static User ValidateLogin(string email, string password)
		{
			using (FreeLancersEntities entities = new FreeLancersEntities())
			{
				return entities.Users.FirstOrDefault(user => user.Email == email && user.Password == password);
			}
		}

		public static User ValidateLogin(string email)
		{
			using (FreeLancersEntities entities = new FreeLancersEntities())
			{
				return entities.Users.FirstOrDefault(user => user.Email == email);
			}
		}

		public static bool HasPassword(User user)
		{
			using (FreeLancersEntities entities = new FreeLancersEntities())
			{
				var returnedUser = entities.Users.FirstOrDefault(x => x.Email == user.Email);
				if (string.IsNullOrEmpty(returnedUser.Password))
					return false;
				else
					return true;
			}
		}
		#endregion
	}
}
