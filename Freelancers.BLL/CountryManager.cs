namespace Freelancers.BLL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FreeLancers.Models;
    using FreeLancers.DAL;
    
    public partial class CountryManager : ManagersBase<Country>
    {
    
        #region Properties
    
    	private CountryDataService _countryDataService;

        #endregion

        #region Constructor
        public CountryManager(FreeLancersEntities entities):base(entities)
    	{
    		_countryDataService = new CountryDataService(entities);
        }

        #endregion

        #region Methods
    
    	/// <summary>
    	/// Gets the specified entity by ID.
    	/// </summary>
    	/// <param name="id">The country ID.</param>
    	public override Country GetById(int id)
    	{
    		return _countryDataService.GetById(id);
    	}
    
    	/// <summary>
    	/// Gets All.
    	/// </summary>
    	public override List<Country> GetAll()
    	{
    		return _countryDataService.GetAll();
    	}
    
    	/// <summary>
    	/// Adds the specified entity.
    	/// </summary>
    	/// <param name="country">The country entity.</param>
    	public override void Add(Country country)
    	{
    		_countryDataService.Add(country);
    	}
    
    	/// <summary>
    	/// Deletes the specified entity.
    	/// </summary>
    	/// <param name="country">The country entity.</param>
    	public override void Delete(Country country)
    	{
    		_countryDataService.Delete(country);
    	}
    
    	/// <summary>
    	/// Deletes the entity by Id.
    	/// </summary>
    	/// <param name="id">The country Id.</param>
    	public override void Delete(int id)
    	{
    		_countryDataService.Delete(id);
    	}
    
    	/// <summary>
    	/// Updates the specified entity.
    	/// </summary>
    	/// <param name="country">The country entity.</param>
    	public override void Update(Country country)
    	{
    		_countryDataService.Update(country);
    	}
    
    	/// <summary>
    	/// Queries the entity.
    	/// </summary>
    	/// <param name="criteria">Search Criteria.</param>
    	public override List<Country> Search(Func<Country, bool> criteria)
    	{
    		return _countryDataService.Search(criteria);
    	}

        #endregion

    }
}
