namespace FreeLancers.DAL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FreeLancers.Models;
    
    public partial class CompetitorDataService
    {
        #region Methods
    
    	/// <summary>
    	/// Gets the specified entity by Id.
    	/// </summary>
    	/// <param name="id">The competitor Id.</param>
    	public static Competitor GetById(int id)
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			return entities.Competitors.FirstOrDefault(entity => entity.UserID == id);
    		}
    	}
    
    	/// <summary>
    	/// Gets All.
    	/// </summary>
    	public static List<Competitor> GetAll()
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			return entities.Competitors.ToList();
    		}
    	}
    
    	/// <summary>
    	/// Adds the specified entity.
    	/// </summary>
    	/// <param name="competitor">The competitor entity.</param>
    	public static void Add(Competitor competitor)
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
            {
    			entities.Competitors.Add(competitor);
    			entities.SaveChanges();
            }
    	}
    
    	/// <summary>
    	/// Deletes the specified entity.
    	/// </summary>
    	/// <param name="competitor">The competitor entity.</param>
    	public static void Delete(Competitor competitor)
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			entities.Competitors.Remove(competitor);
    			entities.SaveChanges();
    		}
    	}
    
    	/// <summary>
    	/// Deletes the entity by Id.
    	/// </summary>
    	/// <param name="id">The competitor Id.</param>
    	public static void DeleteById(int id)
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			var competitor = GetById(id);
    			entities.Competitors.Remove(competitor);
    			entities.SaveChanges();
    		}
    	}
    
    	/// <summary>
    	/// Updates the specified entity.
    	/// </summary>
    	/// <param name="competitor">The competitor entity.</param>
    	public static void Update(Competitor competitor)
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			entities.Entry(competitor).State = System.Data.EntityState.Modified;
    			entities.SaveChanges();
    		}
    	}
    
    	/// <summary>
    	/// Queries the entity.
    	/// </summary>
    	/// <param name="criteria">Search Criteria.</param>
    	public static List<Competitor> Search(System.Linq.Expressions.Expression<Func<Competitor, bool>> criteria)
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			return entities.Competitors.Where(criteria).ToList();
    		}
    	}

        #endregion

    }
}
