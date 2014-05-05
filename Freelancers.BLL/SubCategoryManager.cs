namespace Freelancers.BLL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FreeLancers.Models;
    using FreeLancers.DAL;
    
    public partial class SubCategoryManager : ManagersBase<SubCategory>
    {
    
        #region Properties
    
    	private SubCategoryDataService _subcategoryDataService;

        #endregion

        #region Constructor
        public SubCategoryManager(FreeLancersEntities entities):base(entities)
    	{
    		_subcategoryDataService = new SubCategoryDataService(entities);
        }

        #endregion

        #region Methods
    
    	/// <summary>
    	/// Gets the specified entity by ID.
    	/// </summary>
    	/// <param name="id">The subcategory ID.</param>
    	public override SubCategory GetById(int id)
    	{
    		return _subcategoryDataService.GetById(id);
    	}
    
    	/// <summary>
    	/// Gets All.
    	/// </summary>
    	public override List<SubCategory> GetAll()
    	{
    		return _subcategoryDataService.GetAll();
    	}
    
    	/// <summary>
    	/// Adds the specified entity.
    	/// </summary>
    	/// <param name="subcategory">The subcategory entity.</param>
    	public override void Add(SubCategory subcategory)
    	{
    		_subcategoryDataService.Add(subcategory);
    	}
    
    	/// <summary>
    	/// Deletes the specified entity.
    	/// </summary>
    	/// <param name="subcategory">The subcategory entity.</param>
    	public override void Delete(SubCategory subcategory)
    	{
    		_subcategoryDataService.Delete(subcategory);
    	}
    
    	/// <summary>
    	/// Deletes the entity by Id.
    	/// </summary>
    	/// <param name="id">The subcategory Id.</param>
    	public override void Delete(int id)
    	{
    		_subcategoryDataService.Delete(id);
    	}
    
    	/// <summary>
    	/// Updates the specified entity.
    	/// </summary>
    	/// <param name="subcategory">The subcategory entity.</param>
    	public override void Update(SubCategory subcategory)
    	{
    		_subcategoryDataService.Update(subcategory);
    	}
    
    	/// <summary>
    	/// Queries the entity.
    	/// </summary>
    	/// <param name="criteria">Search Criteria.</param>
    	public override List<SubCategory> Search(Func<SubCategory, bool> criteria)
    	{
    		return _subcategoryDataService.Search(criteria);
    	}

        #endregion

    }
}
