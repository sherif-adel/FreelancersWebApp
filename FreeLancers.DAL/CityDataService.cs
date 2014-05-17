
namespace FreeLancers.DAL
{

using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using FreeLancers.Models;

public partial class CityDataService : DataServiceBase<City>
{
    #region Constructor
    
	/// <summary>
	/// Gets the specified entity by Id.
	/// </summary>
	/// <param name="id">The city Id.</param>
	public CityDataService(FreeLancersEntities dataContext):base(dataContext)
	{
		this.DataContext = dataContext;
	}

        #endregion

    

    #region Methods
    

	/// <summary>
	/// Gets the specified entity by Id.
	/// </summary>
	/// <param name="id">The city Id.</param>
	public override City GetById(int id)
	{
		return DataContext.Cities.FirstOrDefault(entity => entity.CityID == id);
	}

	/// <summary>
	/// Gets All.
	/// </summary>
	public override List<City> GetAll()
	{
		return DataContext.Cities.ToList();
	}

	/// <summary>
	/// Adds the specified entity.
	/// </summary>
	/// <param name="city">The city entity.</param>
	public override void Add(City city)
	{
		DataContext.Cities.Add(city);
		DataContext.SaveChanges();
	}

	/// <summary>
	/// Deletes the specified entity.
	/// </summary>
	/// <param name="city">The city entity.</param>
	public override void Delete(City city)
	{

		DataContext.Cities.Remove(city);
		DataContext.SaveChanges();
	}

	/// <summary>
	/// Deletes the entity by Id.
	/// </summary>
	/// <param name="id">The city Id.</param>
	public override void Delete(int id)
	{
		var city = GetById(id);
		DataContext.Cities.Remove(city);
		DataContext.SaveChanges();
	}

	/// <summary>
	/// Updates the specified entity.
	/// </summary>
	/// <param name="city">The city entity.</param>
	public override void Update(City city)
	{
		DataContext.Entry(city).State = EntityState.Modified;
		DataContext.SaveChanges();
	}

        #endregion

    
}

}
