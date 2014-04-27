using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FreeLancers.Service.Contracts
{
	[DataContract]
	public class UserContract
	{
		[DataMember]
		public int UserID { get; set; }

		[DataMember]
		public string Email { get; set; }

		[DataMember]
		public string FirstName { get; set; }

		[DataMember]
		public string LastName { get; set; }

		[DataMember]
		public string Password { get; set; }

		[DataMember]
		public Nullable<int> SubCategoryID { get; set; }

		[DataMember]
		public int RoleID { get; set; }

		[DataMember]
		public int Mobile { get; set; }

		//[DataMember]
		//public virtual ICollection<FreelancersPost> FreelancersPosts { get; set; }

		//[DataMember]
		//public virtual ICollection<Request> Requests { get; set; }

		//[DataMember]
		//public virtual Role Role { get; set; }

		//[DataMember]
		//public virtual SubCategory SubCategory { get; set; }
	}
}
