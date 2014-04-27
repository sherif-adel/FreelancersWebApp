namespace Freelancers.BLL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FreeLancers.Models;
    using FreeLancers.DAL;
    
    public partial class SkillManager
    {
        #region Methods
    
    	/// <summary>
    	/// Gets the specified entity by ID.
    	/// </summary>
    	/// <param name="id">The skill ID.</param>
    	public static Skill GetById(int id)
    	{
    		return SkillDataService.GetById(id);
    	}
    
    	/// <summary>
    	/// Gets All.
    	/// </summary>
    	public static List<Skill> GetAll()
    	{
    		return SkillDataService.GetAll();
    	}
    
    	/// <summary>
    	/// Adds the specified entity.
    	/// </summary>
    	/// <param name="skill">The skill entity.</param>
    	public static void Add(Skill skill)
    	{
    		SkillDataService.Add(skill);
    	}
    
    	/// <summary>
    	/// Deletes the specified entity.
    	/// </summary>
    	/// <param name="skill">The skill entity.</param>
    	public static void Delete(Skill skill)
    	{
    		SkillDataService.Delete(skill);
    	}
    
    	/// <summary>
    	/// Deletes the entity by Id.
    	/// </summary>
    	/// <param name="id">The skill Id.</param>
    	public static void DeleteById(int id)
    	{
    		SkillDataService.DeleteById(id);
    	}
    
    	/// <summary>
    	/// Updates the specified entity.
    	/// </summary>
    	/// <param name="skill">The skill entity.</param>
    	public static void Update(Skill skill)
    	{
    		SkillDataService.Update(skill);
    	}
    
    	/// <summary>
    	/// Queries the entity.
    	/// </summary>
    	/// <param name="criteria">Search Criteria.</param>
    	public static List<Skill> Search(System.Linq.Expressions.Expression<Func<Skill, bool>> criteria)
    	{
    		return SkillDataService.Search(criteria);
    	}

        #endregion

    }
}
