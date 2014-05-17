//------------------------------------------------------------------------------
//------------------------------------------------------------------------------

namespace FreeLancers.Service.Contracts
{
    using System;
    using System.Collections.Generic;using System.Linq;using System.Runtime.Serialization;using System.Text;using System.Threading.Tasks;using FreeLancers.Service.Contracts;
    
    [DataContract]
public partial class SubCategoryContract
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
    
        [DataMember]
        public virtual MainCategoryContract MainCategory { get; set; }
        [DataMember]
        public virtual List<ProjectContract> Projects { get; set; }
        [DataMember]
        public virtual List<ProfileContract> Profiles { get; set; }
        [DataMember]
        public virtual List<UserContract> Users { get; set; }
    }
}
