namespace FreeLancers.DAL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FreeLancers.Models;
    
    public partial class SubCategoryDataService
    {
        #region Methods
    
    	/// <summary>
    	/// Gets the specified entity by Id.
    	/// </summary>
    	/// <param name="id">The subcategory Id.</param>
    	public static SubCategory GetById(int id)
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			return entities.SubCategories.FirstOrDefault(entity => entity.SubCategoryID == id);
    		}
    	}
    
    	/// <summary>
    	/// Gets All.
    	/// </summary>
    	public static List<SubCategory> GetAll()
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			return entities.SubCategories.ToList();
    		}
    	}
    
    	/// <summary>
    	/// Adds the specified entity.
    	/// </summary>
    	/// <param name="subcategory">The subcategory entity.</param>
    	public static void Add(SubCategory subcategory)
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
            {
    			entities.SubCategories.Add(subcategory);
    			entities.SaveChanges();
            }
    	}
    
    	/// <summary>
    	/// Deletes the specified entity.
    	/// </summary>
    	/// <param name="subcategory">The subcategory entity.</param>
    	public static void Delete(SubCategory subcategory)
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			entities.SubCategories.Remove(subcategory);
    			entities.SaveChanges();
    		}
    	}
    
    	/// <summary>
    	/// Deletes the entity by Id.
    	/// </summary>
    	/// <param name="id">The subcategory Id.</param>
    	public static void DeleteById(int id)
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			var subcategory = GetById(id);
    			entities.SubCategories.Remove(subcategory);
    			entities.SaveChanges();
    		}
    	}
    
    	/// <summary>
    	/// Updates the specified entity.
    	/// </summary>
    	/// <param name="subcategory">The subcategory entity.</param>
    	public static void Update(SubCategory subcategory)
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			entities.Entry(subcategory).State = System.Data.EntityState.Modified;
    			entities.SaveChanges();
    		}
    	}
    
    	/// <summary>
    	/// Queries the entity.
    	/// </summary>
    	/// <param name="criteria">Search Criteria.</param>
    	public static List<SubCategory> Search(System.Linq.Expressions.Expression<Func<SubCategory, bool>> criteria)
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			return entities.SubCategories.Where(criteria).ToList();
    		}
    	}

        #endregion

    }
}
