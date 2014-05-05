//------------------------------------------------------------------------------
//------------------------------------------------------------------------------

namespace FreeLancers.Service.Contracts
{
    using System;
    using System.Collections.Generic;using System.Linq;using System.Runtime.Serialization;using System.Text;using System.Threading.Tasks;using FreeLancers.Service.Contracts;
    
    [DataContract]
public partial class CompetitorContract
    {
        [DataMember]
        public int ProjectID { get; set; }
        [DataMember]
        public int UserID { get; set; }
        [DataMember]
        public decimal Cost { get; set; }
        [DataMember]
        public int Duration { get; set; }
    
        [DataMember]
        public virtual ProjectContract Project { get; set; }
        [DataMember]
        public virtual UserContract User { get; set; }
    }
}
