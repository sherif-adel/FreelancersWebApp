
//------------------------------------------------------------------------------
//------------------------------------------------------------------------------


namespace FreeLancers.Service.Contracts
{

using System;
    using System.Collections.Generic;using System.Linq;using System.Runtime.Serialization;using System.Text;using System.Threading.Tasks;using FreeLancers.Service.Contracts;
    
[DataContract]
public partial class CommentContract
{

    [DataMember]
    public int CommentID { get; set; }

    [DataMember]
    public string Comment1 { get; set; }

    [DataMember]
    public int UserID { get; set; }

    [DataMember]
    public int ProfileID { get; set; }

    [DataMember]
    public System.DateTime Date { get; set; }



    [DataMember]
    public virtual ProfileContract Profile { get; set; }

    [DataMember]
    public virtual UserContract User { get; set; }

}

}
