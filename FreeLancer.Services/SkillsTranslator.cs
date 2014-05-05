//------------------------------------------------------------------------------
//------------------------------------------------------------------------------

namespace FreeLancer.Services
{
    using System;
    using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;using FreeLancers.Models;using FreeLancers.Service.Contracts;
    
    public partial class SkillsTranslator
    {
        #region Convert to Entities
    public static Skill ConvertToSkillEntity(SkillContract skill){
    
    if(skill == null)
    	return null;
    Skill entitySkill = new Skill(){
    	
        SkillID=skill.SkillID,
        SkillName=skill.SkillName,
        
            Profiles=ProfilesTranslator.ConvertToProfileEntity(skill.Profiles),
         };
    return entitySkill;}
    public static ICollection<Skill> ConvertToSkillEntity(List<SkillContract> skills)
    {
    		if(skills == null)
    			return null;
    
           List<Skill> newSkills = new List<Skill>();
    		foreach (var skill in skills)
    		{
    			newSkills.Add(ConvertToSkillEntity(skill));
    		}
    		return newSkills;
    }

        #endregion

        #region Convert to Contracts
    public static SkillContract ConvertToSkillContract(Skill skill){
    
    		if(skill == null)
    			return null;
    
    		SkillContract contractSkill = new SkillContract(){
    
            SkillID=skill.SkillID,SkillName=skill.SkillName,             Profiles=ProfilesTranslator.ConvertToProfileContract(skill.Profiles),};
    return contractSkill;}
    public static List<SkillContract> ConvertToSkillContract(ICollection<Skill> skills){
    
    		if(skills == null)
    			return null;
           List<SkillContract> newSkills = new List<SkillContract>();
    			foreach (var skill in skills)
    			{
    				newSkills.Add(ConvertToSkillContract(skill));
    			}
    			return newSkills;
    	}
        #endregion

    	
    
}}
