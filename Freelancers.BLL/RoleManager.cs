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
    		return RoleDataService.GetById(id);
    	}
    
    	/// <summary>
    	/// Gets All.
    	/// </summary>
    	public static List<Role> GetAll()
    	{
    		return RoleDataService.GetAll();
    	}
    
    	/// <summary>
    	/// Adds the specified entity.
    	/// </summary>
    	/// <param name="role">The role entity.</param>
    	public static void Add(Role role)
    	{
    		RoleDataService.Add(role);
    	}
    
    	/// <summary>
    	/// Deletes the specified entity.
    	/// </summary>
    	/// <param name="role">The role entity.</param>
    	public static void Delete(Role role)
    	{
    		RoleDataService.Delete(role);
    	}
    
    	/// <summary>
    	/// Deletes the entity by Id.
    	/// </summary>
    	/// <param name="id">The role Id.</param>
    	public static void DeleteById(int id)
    	{
    		RoleDataService.DeleteById(id);
    	}
    
    	/// <summary>
    	/// Updates the specified entity.
    	/// </summary>
    	/// <param name="role">The role entity.</param>
    	public static void Update(Role role)
    	{
    		RoleDataService.Update(role);
    	}
    
    	/// <summary>
    	/// Queries the entity.
    	/// </summary>
    	/// <param name="criteria">Search Criteria.</param>
    	public static List<Role> Search(System.Linq.Expressions.Expression<Func<Role, bool>> criteria)
    	{
    		return RoleDataService.Search(criteria);
    	}

        #endregion

    }
}
