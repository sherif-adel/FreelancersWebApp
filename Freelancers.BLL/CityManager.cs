namespace Freelancers.BLL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FreeLancers.Models;
    using FreeLancers.DAL;
    
    public partial class CityManager : ManagersBase<City>
    {
    
        #region Properties
    
    	private CityDataService _cityDataService;

        #endregion

        #region Constructor
        public CityManager(FreeLancersEntities entities):base(entities)
    	{
    		_cityDataService = new CityDataService(entities);
        }

        #endregion

        #region Methods
    
    	/// <summary>
    	/// Gets the specified entity by ID.
    	/// </summary>
    	/// <param name="id">The city ID.</param>
    	public override City GetById(int id)
    	{
    		return _cityDataService.GetById(id);
    	}
    
    	/// <summary>
    	/// Gets All.
    	/// </summary>
    	public override List<City> GetAll()
    	{
    		return _cityDataService.GetAll();
    	}
    
    	/// <summary>
    	/// Adds the specified entity.
    	/// </summary>
    	/// <param name="city">The city entity.</param>
    	public override void Add(City city)
    	{
    		_cityDataService.Add(city);
    	}
    
    	/// <summary>
    	/// Deletes the specified entity.
    	/// </summary>
    	/// <param name="city">The city entity.</param>
    	public override void Delete(City city)
    	{
    		_cityDataService.Delete(city);
    	}
    
    	/// <summary>
    	/// Deletes the entity by Id.
    	/// </summary>
    	/// <param name="id">The city Id.</param>
    	public override void Delete(int id)
    	{
    		_cityDataService.Delete(id);
    	}
    
    	/// <summary>
    	/// Updates the specified entity.
    	/// </summary>
    	/// <param name="city">The city entity.</param>
    	public override void Update(City city)
    	{
    		_cityDataService.Update(city);
    	}
    
    	/// <summary>
    	/// Queries the entity.
    	/// </summary>
    	/// <param name="criteria">Search Criteria.</param>
    	public override List<City> Search(Func<City, bool> criteria)
    	{
    		return _cityDataService.Search(criteria);
    	}

        #endregion

    }
}
