
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
    public string FirstName { get; set; }

    [DataMember]
    public string LastName { get; set; }

    [DataMember]
    public string Email { get; set; }

    [DataMember]
    public string Password { get; set; }

    [DataMember]
    public Nullable<int> Mobile { get; set; }

    [DataMember]
    public int RoleID { get; set; }



    [DataMember]
    public virtual ICollection<CommentContract> Comments { get; set; }

    [DataMember]
    public virtual ICollection<CompetitorContract> Competitors { get; set; }

    [DataMember]
    public virtual ICollection<ProfileContract> Profiles { get; set; }

    [DataMember]
    public virtual ICollection<ProjectContract> Projects { get; set; }

    [DataMember]
    public virtual ICollection<RequestContract> Requests { get; set; }

    [DataMember]
    public virtual RoleContract Role { get; set; }

    [DataMember]
    public virtual ICollection<SubCategoryContract> SubCategories { get; set; }

    [DataMember]
    public virtual ICollection<ProjectContract> ProjectsNotifications { get; set; }

}

}
