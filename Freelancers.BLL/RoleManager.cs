namespace Freelancers.BLL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FreeLancers.Models;
    using FreeLancers.DAL;
    
    public partial class RoleManager
    {
        #region Methods
    
    	/// <summary>
    	/// Gets the specified entity by ID.
    	/// </summary>
    	/// <param name="id">The role ID.</param>
    	public static Role GetById(int id)
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			return RoleDataService.GetById(id);
    		}
    	}
    
    	/// <summary>
    	/// Gets All.
    	/// </summary>
    	public static List<Role> GetAll()
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			return RoleDataService.GetAll();
    		}
    	}
    
    	/// <summary>
    	/// Adds the specified entity.
    	/// </summary>
    	/// <param name="role">The role entity.</param>
    	public static void Add(Role role)
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
            {
    			RoleDataService.Add(role);
            }
    	}
    
    	/// <summary>
    	/// Deletes the specified entity.
    	/// </summary>
    	/// <param name="role">The role entity.</param>
    	public static void Delete(Role role)
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			RoleDataService.Delete(role);
    		}
    	}
    
    	/// <summary>
    	/// Deletes the entity by Id.
    	/// </summary>
    	/// <param name="id">The role Id.</param>
    	public static void DeleteById(int id)
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			RoleDataService.DeleteById(id);
    		}
    	}
    
    	/// <summary>
    	/// Updates the specified entity.
    	/// </summary>
    	/// <param name="role">The role entity.</param>
    	public static void Update(Role role)
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			RoleDataService.Update(role);
    		}
    	}
    
    	/// <summary>
    	/// Queries the entity.
    	/// </summary>
    	/// <param name="criteria">Search Criteria.</param>
    	public static List<Role> Search(System.Linq.Expressions.Expression<Func<Role, bool>> criteria)
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			return RoleDataService.Search(criteria);
    		}
    	}

        #endregion

    }
}
