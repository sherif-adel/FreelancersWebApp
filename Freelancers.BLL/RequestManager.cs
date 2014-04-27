namespace Freelancers.BLL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FreeLancers.Models;
    using FreeLancers.DAL;
    
    public partial class RequestManager
    {
        #region Methods
    
    	/// <summary>
    	/// Gets the specified entity by ID.
    	/// </summary>
    	/// <param name="id">The request ID.</param>
    	public static Request GetById(int id)
    	{
    		return RequestDataService.GetById(id);
    	}
    
    	/// <summary>
    	/// Gets All.
    	/// </summary>
    	public static List<Request> GetAll()
    	{
    		return RequestDataService.GetAll();
    	}
    
    	/// <summary>
    	/// Adds the specified entity.
    	/// </summary>
    	/// <param name="request">The request entity.</param>
    	public static void Add(Request request)
    	{
    		RequestDataService.Add(request);
    	}
    
    	/// <summary>
    	/// Deletes the specified entity.
    	/// </summary>
    	/// <param name="request">The request entity.</param>
    	public static void Delete(Request request)
    	{
    		RequestDataService.Delete(request);
    	}
    
    	/// <summary>
    	/// Deletes the entity by Id.
    	/// </summary>
    	/// <param name="id">The request Id.</param>
    	public static void DeleteById(int id)
    	{
    		RequestDataService.DeleteById(id);
    	}
    
    	/// <summary>
    	/// Updates the specified entity.
    	/// </summary>
    	/// <param name="request">The request entity.</param>
    	public static void Update(Request request)
    	{
    		RequestDataService.Update(request);
    	}
    
    	/// <summary>
    	/// Queries the entity.
    	/// </summary>
    	/// <param name="criteria">Search Criteria.</param>
    	public static List<Request> Search(System.Linq.Expressions.Expression<Func<Request, bool>> criteria)
    	{
    		return RequestDataService.Search(criteria);
    	}

        #endregion

    }
}
