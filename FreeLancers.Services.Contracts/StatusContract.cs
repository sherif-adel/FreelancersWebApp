//------------------------------------------------------------------------------
//------------------------------------------------------------------------------

namespace FreeLancers.Service.Contracts
{
    using System;
    using System.Collections.Generic;using System.Linq;using System.Runtime.Serialization;using System.Text;using System.Threading.Tasks;using FreeLancers.Service.Contracts;
    
    [DataContract]
public partial class StatusContract
    {
        [DataMember]
        public int StatusID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public Nullable<int> RoleID { get; set; }
    
        [DataMember]
        public virtual List<RequestContract> Requests { get; set; }
        [DataMember]
        public virtual RoleContract Role { get; set; }
    }
}
