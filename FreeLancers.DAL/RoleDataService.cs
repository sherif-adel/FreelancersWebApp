namespace FreeLancers.DAL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FreeLancers.Models;
    
    public partial class RoleDataService
    {
        #region Methods
    
    	/// <summary>
    	/// Gets the specified entity by Id.
    	/// </summary>
    	/// <param name="id">The role Id.</param>
    	public static Role GetById(int id)
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			return entities.Roles.FirstOrDefault(entity => entity.RoleID == id);
    		}
    	}
    
    	/// <summary>
    	/// Gets All.
    	/// </summary>
    	public static List<Role> GetAll()
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			return entities.Roles.ToList();
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
    			entities.Roles.Add(role);
    			entities.SaveChanges();
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
    			entities.Roles.Remove(role);
    			entities.SaveChanges();
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
    			var role = GetById(id);
    			entities.Roles.Remove(role);
    			entities.SaveChanges();
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
    			entities.Entry(role).State = System.Data.EntityState.Modified;
    			entities.SaveChanges();
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
    			return entities.Roles.Where(criteria).ToList();
    		}
    	}

        #endregion

    }
}
