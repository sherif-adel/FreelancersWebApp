using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FreeLancers.Service.Contracts
{
	[ServiceContract]
	public interface IUserService
	{
		[OperationContract]
		UserContract GetById(int userId);

		[OperationContract]
		List<UserContract> GetAll();

		[OperationContract]
		void Add(UserContract user);

		[OperationContract]
		void Delete(UserContract user);

		[OperationContract]
		void DeleteById(int userId);

		[OperationContract]
		void Update(UserContract user);

		//[OperationContract]
		//List<UserContract> Search(System.Linq.Expressions.Expression<Func<UserContract, bool>> criteria);

		[OperationContract]
		List<UserContract> GetUsersByRoleId(int roleId);

		[OperationContract]
		UserContract ValidateLogin(string email, string password);
	}
}
