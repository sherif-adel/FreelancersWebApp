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
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			return SkillDataService.GetById(id);
    		}
    	}
    
    	/// <summary>
    	/// Gets All.
    	/// </summary>
    	public static List<Skill> GetAll()
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			return SkillDataService.GetAll();
    		}
    	}
    
    	/// <summary>
    	/// Adds the specified entity.
    	/// </summary>
    	/// <param name="skill">The skill entity.</param>
    	public static void Add(Skill skill)
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
            {
    			SkillDataService.Add(skill);
            }
    	}
    
    	/// <summary>
    	/// Deletes the specified entity.
    	/// </summary>
    	/// <param name="skill">The skill entity.</param>
    	public static void Delete(Skill skill)
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			SkillDataService.Delete(skill);
    		}
    	}
    
    	/// <summary>
    	/// Deletes the entity by Id.
    	/// </summary>
    	/// <param name="id">The skill Id.</param>
    	public static void DeleteById(int id)
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			SkillDataService.DeleteById(id);
    		}
    	}
    
    	/// <summary>
    	/// Updates the specified entity.
    	/// </summary>
    	/// <param name="skill">The skill entity.</param>
    	public static void Update(Skill skill)
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			SkillDataService.Update(skill);
    		}
    	}
    
    	/// <summary>
    	/// Queries the entity.
    	/// </summary>
    	/// <param name="criteria">Search Criteria.</param>
    	public static List<Skill> Search(System.Linq.Expressions.Expression<Func<Skill, bool>> criteria)
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			return SkillDataService.Search(criteria);
    		}
    	}

        #endregion

    }
}
