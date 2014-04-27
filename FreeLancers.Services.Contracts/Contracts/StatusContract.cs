using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FreeLancers.Service.Contracts.Contracts
{
	[DataContract]
	public class StatusContract
	{
		[DataMember]
		public int StatusID { get; set; }

		[DataMember]
		public string Name { get; set; }

		[DataMember]
		public Nullable<int> RoleID { get; set; }

		//[DataMember]
		//public List<Request> Requests { get; set; }

		[DataMember]
		public RoleContract Role { get; set; }
	}
}
