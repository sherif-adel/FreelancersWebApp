//------------------------------------------------------------------------------
//------------------------------------------------------------------------------

namespace FreeLancers.Service.Contracts
{
    using System;
    using System.Collections.Generic;using System.Linq;using System.Runtime.Serialization;using System.Text;using System.Threading.Tasks;using FreeLancers.Service.Contracts;
    
    [DataContract]
public partial class MainCategoryContract
    {
        [DataMember]
        public int MainCategoryID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public byte[] Image { get; set; }
    
        [DataMember]
        public virtual List<SubCategoryContract> SubCategories { get; set; }
    }
}
