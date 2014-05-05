//------------------------------------------------------------------------------
//------------------------------------------------------------------------------

namespace FreeLancers.Service.Contracts
{
    using System;
    using System.Collections.Generic;using System.Linq;using System.Runtime.Serialization;using System.Text;using System.Threading.Tasks;using FreeLancers.Service.Contracts;
    
    [DataContract]
public partial class RoleContract
    {
        [DataMember]
        public int RoleID { get; set; }
        [DataMember]
        public string RoleName { get; set; }
    
        [DataMember]
        public virtual List<StatusContract> Status { get; set; }
        //[DataMember]
        //public virtual List<UserContract> Users { get; set; }
    }
}
