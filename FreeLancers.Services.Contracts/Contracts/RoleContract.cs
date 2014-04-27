using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FreeLancers.Service.Contracts.Contracts
{
	[DataContract]
	public class RoleContract
	{
		[DataMember]
		public int RoleID { get; set; }

		[DataMember]
		public string RoleName { get; set; }

		[DataMember]
		public List<StatusContract> Status { get; set; }

		[DataMember]
		public List<UserContract> Users { get; set; }
	}
}
