
namespace FreeLancers.DAL
{

using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using FreeLancers.Models;

public partial class CountryDataService : DataServiceBase<Country>
{
    #region Constructor
    
	/// <summary>
	/// Gets the specified entity by Id.
	/// </summary>
	/// <param name="id">The country Id.</param>
	public CountryDataService(FreeLancersEntities dataContext):base(dataContext)
	{
		this.DataContext = dataContext;
	}

        #endregion

    

    #region Methods
    

	/// <summary>
	/// Gets the specified entity by Id.
	/// </summary>
	/// <param name="id">The country Id.</param>
	public override Country GetById(int id)
	{
		return DataContext.Countries.FirstOrDefault(entity => entity.CountryID == id);
	}

	/// <summary>
	/// Gets All.
	/// </summary>
	public override List<Country> GetAll()
	{
		return DataContext.Countries.ToList();
	}

	/// <summary>
	/// Adds the specified entity.
	/// </summary>
	/// <param name="country">The country entity.</param>
	public override void Add(Country country)
	{
		DataContext.Countries.Add(country);
		DataContext.SaveChanges();
	}

	/// <summary>
	/// Deletes the specified entity.
	/// </summary>
	/// <param name="country">The country entity.</param>
	public override void Delete(Country country)
	{

		DataContext.Countries.Remove(country);
		DataContext.SaveChanges();
	}

	/// <summary>
	/// Deletes the entity by Id.
	/// </summary>
	/// <param name="id">The country Id.</param>
	public override void Delete(int id)
	{
		var country = GetById(id);
		DataContext.Countries.Remove(country);
		DataContext.SaveChanges();
	}

	/// <summary>
	/// Updates the specified entity.
	/// </summary>
	/// <param name="country">The country entity.</param>
	public override void Update(Country country)
	{
		DataContext.Entry(country).State = EntityState.Modified;
		DataContext.SaveChanges();
	}

        #endregion

    
}

}
