namespace Freelancers.BLL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FreeLancers.Models;
    using FreeLancers.DAL;
    
    public partial class MainCategoryManager
    {
        #region Methods
    
    	/// <summary>
    	/// Gets the specified entity by ID.
    	/// </summary>
    	/// <param name="id">The maincategory ID.</param>
    	public static MainCategory GetById(int id)
    	{
    		return MainCategoryDataService.GetById(id);
    	}
    
    	/// <summary>
    	/// Gets All.
    	/// </summary>
    	public static List<MainCategory> GetAll()
    	{
    		return MainCategoryDataService.GetAll();
    	}
    
    	/// <summary>
    	/// Adds the specified entity.
    	/// </summary>
    	/// <param name="maincategory">The maincategory entity.</param>
    	public static void Add(MainCategory maincategory)
    	{
    		MainCategoryDataService.Add(maincategory);
    	}
    
    	/// <summary>
    	/// Deletes the specified entity.
    	/// </summary>
    	/// <param name="maincategory">The maincategory entity.</param>
    	public static void Delete(MainCategory maincategory)
    	{
    		MainCategoryDataService.Delete(maincategory);
    	}
    
    	/// <summary>
    	/// Deletes the entity by Id.
    	/// </summary>
    	/// <param name="id">The maincategory Id.</param>
    	public static void DeleteById(int id)
    	{
    		MainCategoryDataService.DeleteById(id);
    	}
    
    	/// <summary>
    	/// Updates the specified entity.
    	/// </summary>
    	/// <param name="maincategory">The maincategory entity.</param>
    	public static void Update(MainCategory maincategory)
    	{
    		MainCategoryDataService.Update(maincategory);
    	}
    
    	/// <summary>
    	/// Queries the entity.
    	/// </summary>
    	/// <param name="criteria">Search Criteria.</param>
    	public static List<MainCategory> Search(System.Linq.Expressions.Expression<Func<MainCategory, bool>> criteria)
    	{
    		return MainCategoryDataService.Search(criteria);
    	}

        #endregion

    }
}
