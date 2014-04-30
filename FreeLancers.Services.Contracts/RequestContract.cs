
//------------------------------------------------------------------------------
//------------------------------------------------------------------------------


namespace FreeLancers.Service.Contracts
{

using System;
    using System.Collections.Generic;using System.Linq;using System.Runtime.Serialization;using System.Text;using System.Threading.Tasks;using FreeLancers.Service.Contracts;
    
[DataContract]
public partial class RequestContract
{

    [DataMember]
    public int RequestID { get; set; }

    [DataMember]
    public int UserID { get; set; }

    [DataMember]
    public int FreelancerID { get; set; }

    [DataMember]
    public string Description { get; set; }

    [DataMember]
    public int StatusID { get; set; }

    [DataMember]
    public System.DateTime StartDate { get; set; }

    [DataMember]
    public System.DateTime EndDate { get; set; }

    [DataMember]
    public Nullable<int> AverageCost { get; set; }



    [DataMember]
    public virtual StatusContract Status { get; set; }

    [DataMember]
    public virtual UserContract User { get; set; }

}

}
