namespace Freelancers.BLL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FreeLancers.Models;
    using FreeLancers.DAL;
    
    public partial class CompetitorManager
    {
        #region Methods
    
    	/// <summary>
    	/// Gets the specified entity by ID.
    	/// </summary>
    	/// <param name="id">The competitor ID.</param>
    	public static Competitor GetById(int id)
    	{
    		return CompetitorDataService.GetById(id);
    	}
    
    	/// <summary>
    	/// Gets All.
    	/// </summary>
    	public static List<Competitor> GetAll()
    	{
    		return CompetitorDataService.GetAll();
    	}
    
    	/// <summary>
    	/// Adds the specified entity.
    	/// </summary>
    	/// <param name="competitor">The competitor entity.</param>
    	public static void Add(Competitor competitor)
    	{
    		CompetitorDataService.Add(competitor);
    	}
    
    	/// <summary>
    	/// Deletes the specified entity.
    	/// </summary>
    	/// <param name="competitor">The competitor entity.</param>
    	public static void Delete(Competitor competitor)
    	{
    		CompetitorDataService.Delete(competitor);
    	}
    
    	/// <summary>
    	/// Deletes the entity by Id.
    	/// </summary>
    	/// <param name="id">The competitor Id.</param>
    	public static void DeleteById(int id)
    	{
    		CompetitorDataService.DeleteById(id);
    	}
    
    	/// <summary>
    	/// Updates the specified entity.
    	/// </summary>
    	/// <param name="competitor">The competitor entity.</param>
    	public static void Update(Competitor competitor)
    	{
    		CompetitorDataService.Update(competitor);
    	}
    
    	/// <summary>
    	/// Queries the entity.
    	/// </summary>
    	/// <param name="criteria">Search Criteria.</param>
    	public static List<Competitor> Search(System.Linq.Expressions.Expression<Func<Competitor, bool>> criteria)
    	{
    		return CompetitorDataService.Search(criteria);
    	}

        #endregion

    }
}
