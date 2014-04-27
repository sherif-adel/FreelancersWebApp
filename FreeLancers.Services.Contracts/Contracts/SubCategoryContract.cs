using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FreeLancers.Service.Contracts
{
	[DataContract]
	public class SubCategoryContract
	{
		[DataMember]
		public int SubCategoryID { get; set; }

		[DataMember]
		public string Name { get; set; }

		[DataMember]
		public string Description { get; set; }

		[DataMember]
		public byte[] Image { get; set; }

		[DataMember]
		public Nullable<int> MainCategoryID { get; set; }

		//[DataMember]
		//public MainCategory MainCategory { get; set; }

		//[DataMember]
		//public ICollection<Project> Projects { get; set; }

		[DataMember]
		public List<UserContract> Users { get; set; }
	}
}
