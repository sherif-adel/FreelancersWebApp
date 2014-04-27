namespace Freelancers.BLL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FreeLancers.Models;
    using FreeLancers.DAL;
    
    public partial class SubCategoryManager
    {
        #region Methods
    
    	/// <summary>
    	/// Gets the specified entity by ID.
    	/// </summary>
    	/// <param name="id">The subcategory ID.</param>
    	public static SubCategory GetById(int id)
    	{
    		return SubCategoryDataService.GetById(id);
    	}
    
    	/// <summary>
    	/// Gets All.
    	/// </summary>
    	public static List<SubCategory> GetAll()
    	{
    		return SubCategoryDataService.GetAll();
    	}
    
    	/// <summary>
    	/// Adds the specified entity.
    	/// </summary>
    	/// <param name="subcategory">The subcategory entity.</param>
    	public static void Add(SubCategory subcategory)
    	{
    		SubCategoryDataService.Add(subcategory);
    	}
    
    	/// <summary>
    	/// Deletes the specified entity.
    	/// </summary>
    	/// <param name="subcategory">The subcategory entity.</param>
    	public static void Delete(SubCategory subcategory)
    	{
    		SubCategoryDataService.Delete(subcategory);
    	}
    
    	/// <summary>
    	/// Deletes the entity by Id.
    	/// </summary>
    	/// <param name="id">The subcategory Id.</param>
    	public static void DeleteById(int id)
    	{
    		SubCategoryDataService.DeleteById(id);
    	}
    
    	/// <summary>
    	/// Updates the specified entity.
    	/// </summary>
    	/// <param name="subcategory">The subcategory entity.</param>
    	public static void Update(SubCategory subcategory)
    	{
    		SubCategoryDataService.Update(subcategory);
    	}
    
    	/// <summary>
    	/// Queries the entity.
    	/// </summary>
    	/// <param name="criteria">Search Criteria.</param>
    	public static List<SubCategory> Search(System.Linq.Expressions.Expression<Func<SubCategory, bool>> criteria)
    	{
    		return SubCategoryDataService.Search(criteria);
    	}

        #endregion

    }
}
