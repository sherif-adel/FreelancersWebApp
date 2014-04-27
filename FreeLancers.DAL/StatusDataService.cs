namespace FreeLancers.DAL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FreeLancers.Models;
    
    public partial class StatusDataService
    {
        #region Methods
    
    	/// <summary>
    	/// Gets the specified entity by Id.
    	/// </summary>
    	/// <param name="id">The status Id.</param>
    	public static Status GetById(int id)
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			return entities.Status.FirstOrDefault(entity => entity.StatusID == id);
    		}
    	}
    
    	/// <summary>
    	/// Gets All.
    	/// </summary>
    	public static List<Status> GetAll()
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			return entities.Status.ToList();
    		}
    	}
    
    	/// <summary>
    	/// Adds the specified entity.
    	/// </summary>
    	/// <param name="status">The status entity.</param>
    	public static void Add(Status status)
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
            {
    			entities.Status.Add(status);
    			entities.SaveChanges();
            }
    	}
    
    	/// <summary>
    	/// Deletes the specified entity.
    	/// </summary>
    	/// <param name="status">The status entity.</param>
    	public static void Delete(Status status)
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			entities.Status.Remove(status);
    			entities.SaveChanges();
    		}
    	}
    
    	/// <summary>
    	/// Deletes the entity by Id.
    	/// </summary>
    	/// <param name="id">The status Id.</param>
    	public static void DeleteById(int id)
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			var status = GetById(id);
    			entities.Status.Remove(status);
    			entities.SaveChanges();
    		}
    	}
    
    	/// <summary>
    	/// Updates the specified entity.
    	/// </summary>
    	/// <param name="status">The status entity.</param>
    	public static void Update(Status status)
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			entities.Entry(status).State = System.Data.EntityState.Modified;
    			entities.SaveChanges();
    		}
    	}
    
    	/// <summary>
    	/// Queries the entity.
    	/// </summary>
    	/// <param name="criteria">Search Criteria.</param>
    	public static List<Status> Search(System.Linq.Expressions.Expression<Func<Status, bool>> criteria)
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			return entities.Status.Where(criteria).ToList();
    		}
    	}

        #endregion

    }
}
