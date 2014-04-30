using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FreeLancers.Service.Contracts
{
    [ServiceContract]
    public partial interface IUserService
    {
        [OperationContract]
        List<UserContract> GetUsersByRoleId(int roleId);

        [OperationContract]
        UserContract ValidateLogin(string email, string password);
    }
}
