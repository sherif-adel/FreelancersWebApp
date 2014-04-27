using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FreeLancers.Service.Contracts.Contracts
{
	[DataContract]
	public class SkillContract
	{
		[DataMember]
		public int SkillID { get; set; }

		[DataMember]
		public string SkillName { get; set; }

		//[DataMember]
		//public virtual List<Profile> Profiles { get; set; }
	}
}
