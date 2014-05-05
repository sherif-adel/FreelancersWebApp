//------------------------------------------------------------------------------
//------------------------------------------------------------------------------

namespace FreeLancers.Service.Contracts
{
    using System;
    using System.Collections.Generic;using System.Linq;using System.Runtime.Serialization;using System.Text;using System.Threading.Tasks;using FreeLancers.Service.Contracts;
    
    [DataContract]
public partial class ProjectContract
    {
        [DataMember]
        public int ProjectID { get; set; }
        [DataMember]
        public int UserID { get; set; }
        [DataMember]
        public int SubCategoryID { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public int AverageCost { get; set; }
        [DataMember]
        public System.DateTime StartDate { get; set; }
        [DataMember]
        public System.DateTime EndDate { get; set; }
        [DataMember]
        public bool Finished { get; set; }
        [DataMember]
        public Nullable<int> FreelancerID { get; set; }
        [DataMember]
        public System.DateTime Date { get; set; }
        [DataMember]
        public Nullable<bool> Featured { get; set; }
        [DataMember]
        public string Name { get; set; }
    
        [DataMember]
        public virtual List<CompetitorContract> Competitors { get; set; }
        [DataMember]
        public virtual SubCategoryContract SubCategory { get; set; }
        [DataMember]
        public virtual UserContract User { get; set; }
        [DataMember]
        public virtual List<UserContract> UsersNotified { get; set; }
    }
}
