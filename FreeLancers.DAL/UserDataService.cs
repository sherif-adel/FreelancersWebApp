namespace FreeLancers.DAL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FreeLancers.Models;
    
    public partial class UserDataService
    {
        #region Methods
    
    	/// <summary>
    	/// Gets the specified entity by Id.
    	/// </summary>
    	/// <param name="id">The user Id.</param>
    	public static User GetById(int id)
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			return entities.Users.FirstOrDefault(entity => entity.UserID == id);
    		}
    	}
    
    	/// <summary>
    	/// Gets All.
    	/// </summary>
    	public static List<User> GetAll()
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			return entities.Users.ToList();
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
    			entities.Users.Add(user);
    			entities.SaveChanges();
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
    			entities.Users.Remove(user);
    			entities.SaveChanges();
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
    			var user = GetById(id);
    			entities.Users.Remove(user);
    			entities.SaveChanges();
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
    			entities.Entry(user).State = System.Data.EntityState.Modified;
    			entities.SaveChanges();
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
    			return entities.Users.Where(criteria).ToList();
    		}
    	}

        #endregion

    }
}
