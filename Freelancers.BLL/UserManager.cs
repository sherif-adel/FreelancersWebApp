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
    		return UserDataService.GetById(id);
    	}
    
    	/// <summary>
    	/// Gets All.
    	/// </summary>
    	public static List<User> GetAll()
    	{
    		return UserDataService.GetAll();
    	}
    
    	/// <summary>
    	/// Adds the specified entity.
    	/// </summary>
    	/// <param name="user">The user entity.</param>
    	public static void Add(User user)
    	{
    		UserDataService.Add(user);
    	}
    
    	/// <summary>
    	/// Deletes the specified entity.
    	/// </summary>
    	/// <param name="user">The user entity.</param>
    	public static void Delete(User user)
    	{
    		UserDataService.Delete(user);
    	}
    
    	/// <summary>
    	/// Deletes the entity by Id.
    	/// </summary>
    	/// <param name="id">The user Id.</param>
    	public static void DeleteById(int id)
    	{
    		UserDataService.DeleteById(id);
    	}
    
    	/// <summary>
    	/// Updates the specified entity.
    	/// </summary>
    	/// <param name="user">The user entity.</param>
    	public static void Update(User user)
    	{
    		UserDataService.Update(user);
    	}
    
    	/// <summary>
    	/// Queries the entity.
    	/// </summary>
    	/// <param name="criteria">Search Criteria.</param>
    	public static List<User> Search(System.Linq.Expressions.Expression<Func<User, bool>> criteria)
    	{
    		return UserDataService.Search(criteria);
    	}

        #endregion

    }
}
