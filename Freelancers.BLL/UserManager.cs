namespace Freelancers.BLL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FreeLancers.Models;
    using FreeLancers.DAL;
    
    public partial class UserManager
    {
        #region Methods
    
    	/// <summary>
    	/// Gets the specified entity by ID.
    	/// </summary>
    	/// <param name="id">The user ID.</param>
    	public static User GetById(int id)
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			return UserDataService.GetById(id);
    		}
    	}
    
    	/// <summary>
    	/// Gets All.
    	/// </summary>
    	public static List<User> GetAll()
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			return UserDataService.GetAll();
    		}
    	}
    
    	/// <summary>
    	/// Adds the specified entity.
    	/// </summary>
    	/// <param name="user">The user entity.</param>
    	public static void Add(User user)
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
            {
    			UserDataService.Add(user);
            }
    	}
    
    	/// <summary>
    	/// Deletes the specified entity.
    	/// </summary>
    	/// <param name="user">The user entity.</param>
    	public static void Delete(User user)
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			UserDataService.Delete(user);
    		}
    	}
    
    	/// <summary>
    	/// Deletes the entity by Id.
    	/// </summary>
    	/// <param name="id">The user Id.</param>
    	public static void DeleteById(int id)
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			UserDataService.DeleteById(id);
    		}
    	}
    
    	/// <summary>
    	/// Updates the specified entity.
    	/// </summary>
    	/// <param name="user">The user entity.</param>
    	public static void Update(User user)
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			UserDataService.Update(user);
    		}
    	}
    
    	/// <summary>
    	/// Queries the entity.
    	/// </summary>
    	/// <param name="criteria">Search Criteria.</param>
    	public static List<User> Search(System.Linq.Expressions.Expression<Func<User, bool>> criteria)
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			return UserDataService.Search(criteria);
    		}
    	}

        #endregion

    }
}
