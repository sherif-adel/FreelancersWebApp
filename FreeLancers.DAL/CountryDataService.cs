
namespace FreeLancers.DAL
{

	using System;
	using System.Data.Entity;
	using System.Collections.Generic;
	using System.Linq;
	using FreeLancers.Models;
	using FreeLancers.Log;

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
		try
		{
			return DataContext.Countries.FirstOrDefault(entity => entity.CountryID == id);
		}
            catch (Exception ex)
            {
                ExceptionHandler.LogException(ex, System.Reflection.MethodInfo.GetCurrentMethod().Name, FreeLancers.Log.ExceptionHandler.LogThreshold.ERROR);
                throw ex;
            }
	}

	/// <summary>
	/// Gets All.
	/// </summary>
	public override List<Country> GetAll()
	{
		try
		{
			return DataContext.Countries.ToList();
		}
    		catch (Exception ex)
            {
                ExceptionHandler.LogException(ex, System.Reflection.MethodInfo.GetCurrentMethod().Name, FreeLancers.Log.ExceptionHandler.LogThreshold.ERROR);
                throw ex;
            }
	}

	/// <summary>
	/// Adds the specified entity.
	/// </summary>
	/// <param name="country">The country entity.</param>
	public override void Add(Country country)
	{
		try
		{
			DataContext.Countries.Add(country);
			DataContext.SaveChanges();
		}
    		catch (Exception ex)
            {
                ExceptionHandler.LogException(ex, System.Reflection.MethodInfo.GetCurrentMethod().Name, FreeLancers.Log.ExceptionHandler.LogThreshold.ERROR);
                throw ex;
            }
	}

	/// <summary>
	/// Deletes the specified entity.
	/// </summary>
	/// <param name="country">The country entity.</param>
	public override void Delete(Country country)
	{
		try
		{
			DataContext.Countries.Remove(country);
			DataContext.SaveChanges();
		}
    		catch (Exception ex)
            {
                ExceptionHandler.LogException(ex, System.Reflection.MethodInfo.GetCurrentMethod().Name, FreeLancers.Log.ExceptionHandler.LogThreshold.ERROR);
                throw ex;
            }
	}

	/// <summary>
	/// Deletes the entity by Id.
	/// </summary>
	/// <param name="id">The country Id.</param>
	public override void Delete(int id)
	{
		try
		{
			var country = GetById(id);
			DataContext.Countries.Remove(country);
			DataContext.SaveChanges();
		}
		catch (Exception ex)
            {
                ExceptionHandler.LogException(ex, System.Reflection.MethodInfo.GetCurrentMethod().Name, FreeLancers.Log.ExceptionHandler.LogThreshold.ERROR);
                throw ex;
            }
	}

	/// <summary>
	/// Updates the specified entity.
	/// </summary>
	/// <param name="country">The country entity.</param>
	public override void Update(Country country)
	{
		try
		{
			DataContext.Entry(country).State = EntityState.Modified;
			DataContext.SaveChanges();
		}
		catch (Exception ex)
            {
                ExceptionHandler.LogException(ex, System.Reflection.MethodInfo.GetCurrentMethod().Name, FreeLancers.Log.ExceptionHandler.LogThreshold.ERROR);
                throw ex;
            }
	}

        #endregion

    
}

}
