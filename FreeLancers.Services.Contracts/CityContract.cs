//------------------------------------------------------------------------------
//------------------------------------------------------------------------------

namespace FreeLancers.Service.Contracts
{
    using System;
    using System.Collections.Generic;using System.Linq;using System.Runtime.Serialization;using System.Text;using System.Threading.Tasks;using FreeLancers.Service.Contracts;
    
    [DataContract]
public partial class CityContract
    {
        [DataMember]
        public int CityID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int CountryID { get; set; }
    
        [DataMember]
        public virtual CountryContract Country { get; set; }
        [DataMember]
        public virtual List<UserContract> Users { get; set; }
    }
}
