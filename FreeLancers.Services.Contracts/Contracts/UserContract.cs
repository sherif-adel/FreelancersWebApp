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
		public string FirstName { get; set; }

		[DataMember]
		public string LastName { get; set; }

		[DataMember]
		public string Email { get; set; }

		[DataMember]
		public string Password { get; set; }

		[DataMember]
		public Nullable<int> Mobile { get; set; }

		[DataMember]
		public int RoleID { get; set; }


		//public virtual ICollection<Comment> Comments { get; set; }

		//public virtual ICollection<Competitor> Competitors { get; set; }

		//public virtual ICollection<Profile> Profiles { get; set; }

		//public virtual ICollection<Project> Projects { get; set; }

		//public virtual ICollection<Request> Requests { get; set; }

		//public virtual Role Role { get; set; }

		//public virtual ICollection<SubCategory> SubCategories { get; set; }

		//public virtual ICollection<Project> ProjectsNotifications { get; set; }
	}
}
