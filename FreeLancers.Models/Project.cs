
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
    
public partial class Project
{

    public Project()
    {

        this.Competitors = new HashSet<Competitor>();

        this.Users = new HashSet<User>();

    }


    public int ProjectID { get; set; }

    public int UserID { get; set; }

    public int SubCategoryID { get; set; }

    public string Description { get; set; }

    public int AverageCost { get; set; }

    public System.DateTime StartDate { get; set; }

    public System.DateTime EndDate { get; set; }

    public bool Finished { get; set; }

    public Nullable<int> FreelancerID { get; set; }

    public System.DateTime Date { get; set; }

    public Nullable<bool> Featured { get; set; }

    public string Name { get; set; }



    public virtual SubCategory SubCategory { get; set; }

    public virtual ICollection<Competitor> Competitors { get; set; }

    public virtual User User { get; set; }

    public virtual ICollection<User> Users { get; set; }

}

}
