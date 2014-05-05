namespace Freelancers.BLL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FreeLancers.Models;
    using FreeLancers.DAL;
    
    public partial class MainCategoryManager : ManagersBase<MainCategory>
    {
    
        #region Properties
    
    	private MainCategoryDataService _maincategoryDataService;

        #endregion

        #region Constructor
        public MainCategoryManager(FreeLancersEntities entities):base(entities)
    	{
    		_maincategoryDataService = new MainCategoryDataService(entities);
        }

        #endregion

        #region Methods
    
    	/// <summary>
    	/// Gets the specified entity by ID.
    	/// </summary>
    	/// <param name="id">The maincategory ID.</param>
    	public override MainCategory GetById(int id)
    	{
    		return _maincategoryDataService.GetById(id);
    	}
    
    	/// <summary>
    	/// Gets All.
    	/// </summary>
    	public override List<MainCategory> GetAll()
    	{
    		return _maincategoryDataService.GetAll();
    	}
    
    	/// <summary>
    	/// Adds the specified entity.
    	/// </summary>
    	/// <param name="maincategory">The maincategory entity.</param>
    	public override void Add(MainCategory maincategory)
    	{
    		_maincategoryDataService.Add(maincategory);
    	}
    
    	/// <summary>
    	/// Deletes the specified entity.
    	/// </summary>
    	/// <param name="maincategory">The maincategory entity.</param>
    	public override void Delete(MainCategory maincategory)
    	{
    		_maincategoryDataService.Delete(maincategory);
    	}
    
    	/// <summary>
    	/// Deletes the entity by Id.
    	/// </summary>
    	/// <param name="id">The maincategory Id.</param>
    	public override void Delete(int id)
    	{
    		_maincategoryDataService.Delete(id);
    	}
    
    	/// <summary>
    	/// Updates the specified entity.
    	/// </summary>
    	/// <param name="maincategory">The maincategory entity.</param>
    	public override void Update(MainCategory maincategory)
    	{
    		_maincategoryDataService.Update(maincategory);
    	}
    
    	/// <summary>
    	/// Queries the entity.
    	/// </summary>
    	/// <param name="criteria">Search Criteria.</param>
    	public override List<MainCategory> Search(Func<MainCategory, bool> criteria)
    	{
    		return _maincategoryDataService.Search(criteria);
    	}

        #endregion

    }
}
