namespace FreeLancers.DAL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FreeLancers.Models;
    
    public partial class MainCategoryDataService
    {
        #region Methods
    
    	/// <summary>
    	/// Gets the specified entity by Id.
    	/// </summary>
    	/// <param name="id">The maincategory Id.</param>
    	public static MainCategory GetById(int id)
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			return entities.MainCategories.FirstOrDefault(entity => entity.MainCategoryID == id);
    		}
    	}
    
    	/// <summary>
    	/// Gets All.
    	/// </summary>
    	public static List<MainCategory> GetAll()
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			return entities.MainCategories.ToList();
    		}
    	}
    
    	/// <summary>
    	/// Adds the specified entity.
    	/// </summary>
    	/// <param name="maincategory">The maincategory entity.</param>
    	public static void Add(MainCategory maincategory)
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
            {
    			entities.MainCategories.Add(maincategory);
    			entities.SaveChanges();
            }
    	}
    
    	/// <summary>
    	/// Deletes the specified entity.
    	/// </summary>
    	/// <param name="maincategory">The maincategory entity.</param>
    	public static void Delete(MainCategory maincategory)
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			entities.MainCategories.Remove(maincategory);
    			entities.SaveChanges();
    		}
    	}
    
    	/// <summary>
    	/// Deletes the entity by Id.
    	/// </summary>
    	/// <param name="id">The maincategory Id.</param>
    	public static void DeleteById(int id)
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			var maincategory = GetById(id);
    			entities.MainCategories.Remove(maincategory);
    			entities.SaveChanges();
    		}
    	}
    
    	/// <summary>
    	/// Updates the specified entity.
    	/// </summary>
    	/// <param name="maincategory">The maincategory entity.</param>
    	public static void Update(MainCategory maincategory)
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			entities.Entry(maincategory).State = System.Data.EntityState.Modified;
    			entities.SaveChanges();
    		}
    	}
    
    	/// <summary>
    	/// Queries the entity.
    	/// </summary>
    	/// <param name="criteria">Search Criteria.</param>
    	public static List<MainCategory> Search(System.Linq.Expressions.Expression<Func<MainCategory, bool>> criteria)
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			return entities.MainCategories.Where(criteria).ToList();
    		}
    	}

        #endregion

    }
}
