//------------------------------------------------------------------------------
//------------------------------------------------------------------------------

namespace FreeLancers.Service.Contracts
{
    using System;
    using System.Collections.Generic;using System.Linq;using System.Runtime.Serialization;using System.Text;using System.Threading.Tasks;using FreeLancers.Service.Contracts;
    
    [DataContract]
public partial class ImageContract
    {
        [DataMember]
        public int ImageID { get; set; }
        [DataMember]
        public System.Guid GUID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public byte[] FileData { get; set; }
        [DataMember]
        public int ProfileID { get; set; }
    
        [DataMember]
        public virtual ProfileContract Profile { get; set; }
    }
}
