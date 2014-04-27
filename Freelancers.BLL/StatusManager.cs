namespace Freelancers.BLL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FreeLancers.Models;
    using FreeLancers.DAL;
    
    public partial class StatusManager
    {
        #region Methods
    
    	/// <summary>
    	/// Gets the specified entity by ID.
    	/// </summary>
    	/// <param name="id">The status ID.</param>
    	public static Status GetById(int id)
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			return StatusDataService.GetById(id);
    		}
    	}
    
    	/// <summary>
    	/// Gets All.
    	/// </summary>
    	public static List<Status> GetAll()
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			return StatusDataService.GetAll();
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
    			StatusDataService.Add(status);
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
    			StatusDataService.Delete(status);
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
    			StatusDataService.DeleteById(id);
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
    			StatusDataService.Update(status);
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
    			return StatusDataService.Search(criteria);
    		}
    	}

        #endregion

    }
}
