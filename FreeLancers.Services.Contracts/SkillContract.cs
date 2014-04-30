
//------------------------------------------------------------------------------
//------------------------------------------------------------------------------


namespace FreeLancers.Service.Contracts
{

using System;
    using System.Collections.Generic;using System.Linq;using System.Runtime.Serialization;using System.Text;using System.Threading.Tasks;using FreeLancers.Service.Contracts;
    
[DataContract]
public partial class SkillContract
{

    [DataMember]
    public int SkillID { get; set; }

    [DataMember]
    public string SkillName { get; set; }



    [DataMember]
    public virtual ICollection<ProfileContract> Profiles { get; set; }

}

}
