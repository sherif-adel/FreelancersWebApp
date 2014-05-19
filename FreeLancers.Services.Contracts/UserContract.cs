//------------------------------------------------------------------------------
//------------------------------------------------------------------------------

namespace FreeLancers.Service.Contracts
{
    using System;
    using System.Collections.Generic;using System.Linq;using System.Runtime.Serialization;using System.Text;using System.Threading.Tasks;using FreeLancers.Service.Contracts;
    
    [DataContract]
public partial class UserContract
    {
        [DataMember]
        public int UserID { get; set; }
        [DataMember]
        public string FullName { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public Nullable<int> Mobile { get; set; }
        [DataMember]
        public int RoleID { get; set; }
        [DataMember]
        public Nullable<int> CityID { get; set; }
    
        [DataMember]
        public virtual CityContract City { get; set; }
        [DataMember]
        public virtual List<CommentContract> Comments { get; set; }
        [DataMember]
        public virtual List<CompetitorContract> Competitors { get; set; }
        [DataMember]
        public virtual List<ProfileContract> Profiles { get; set; }
        [DataMember]
        public virtual List<ProjectContract> Projects { get; set; }
        [DataMember]
        public virtual List<RequestContract> Requests { get; set; }
        [DataMember]
        public virtual RoleContract Role { get; set; }
        [DataMember]
        public virtual List<SubCategoryContract> SubCategories { get; set; }
        [DataMember]
        public virtual List<ProjectContract> Projects1 { get; set; }
    }
}
