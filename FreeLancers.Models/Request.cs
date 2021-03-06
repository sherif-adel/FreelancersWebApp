
//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace FreeLancers.Models
{

using System;
    using System.Collections.Generic;
    
public partial class Request
{

    public int RequestID { get; set; }

    public int UserID { get; set; }

    public int FreelancerID { get; set; }

    public string Description { get; set; }

    public int StatusID { get; set; }

    public System.DateTime StartDate { get; set; }

    public System.DateTime EndDate { get; set; }

    public Nullable<int> AverageCost { get; set; }



    public virtual Status Status { get; set; }

    public virtual User User { get; set; }

}

}
