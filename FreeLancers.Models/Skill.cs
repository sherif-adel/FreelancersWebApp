
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
    
public partial class Skill
{

    public Skill()
    {

        this.Profiles = new HashSet<Profile>();

    }


    public int SkillID { get; set; }

    public string SkillName { get; set; }



    public virtual ICollection<Profile> Profiles { get; set; }

}

}
