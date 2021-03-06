//------------------------------------------------------------------------------
//------------------------------------------------------------------------------

namespace FreeLancers.Service.Contracts
{
    using System;
    using System.Collections.Generic;using System.Linq;using System.Runtime.Serialization;using System.Text;using System.Threading.Tasks;using FreeLancers.Service.Contracts;
    
    [DataContract]
public partial class ProfileContract
    {
        [DataMember]
        public int ProfileID { get; set; }
        [DataMember]
        public int UserID { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public int Experience { get; set; }
        [DataMember]
        public string LinkedURL { get; set; }
        [DataMember]
        public string YouTubeURL { get; set; }
        [DataMember]
        public string PreviousWork { get; set; }
        [DataMember]
        public Nullable<int> Rating { get; set; }
        [DataMember]
        public Nullable<bool> Featured { get; set; }
        [DataMember]
        public string CompanyName { get; set; }
        [DataMember]
        public int SubCategoryID { get; set; }
        [DataMember]
        public Nullable<System.DateTime> ExpiryDate { get; set; }
        [DataMember]
        public Nullable<int> ViewersCount { get; set; }
    
        [DataMember]
        public virtual List<CommentContract> Comments { get; set; }
        [DataMember]
        public virtual List<ImageContract> Images { get; set; }
        [DataMember]
        public virtual SubCategoryContract SubCategory { get; set; }
        [DataMember]
        public virtual List<SkillContract> Skills { get; set; }
        [DataMember]
        public virtual UserContract User { get; set; }
    }
}
