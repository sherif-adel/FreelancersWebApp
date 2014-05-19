
namespace FreeLancers.DAL
{

	using System;
	using System.Data.Entity;
	using System.Collections.Generic;
	using System.Linq;
	using FreeLancers.Models;
	using FreeLancers.Log;

public partial class MainCategoryDataService : DataServiceBase<MainCategory>
{
    #region Constructor
    
	/// <summary>
	/// Gets the specified entity by Id.
	/// </summary>
	/// <param name="id">The maincategory Id.</param>
	public MainCategoryDataService(FreeLancersEntities dataContext):base(dataContext)
	{
		this.DataContext = dataContext;
	}

        #endregion

    

    #region Methods
    

	/// <summary>
	/// Gets the specified entity by Id.
	/// </summary>
	/// <param name="id">The maincategory Id.</param>
	public override MainCategory GetById(int id)
	{
		try
		{
			return DataContext.MainCategories.FirstOrDefault(entity => entity.MainCategoryID == id);
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
	public override List<MainCategory> GetAll()
	{
		try
		{
			return DataContext.MainCategories.ToList();
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
	/// <param name="maincategory">The maincategory entity.</param>
	public override void Add(MainCategory maincategory)
	{
		try
		{
			DataContext.MainCategories.Add(maincategory);
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
	/// <param name="maincategory">The maincategory entity.</param>
	public override void Delete(MainCategory maincategory)
	{
		try
		{
			DataContext.MainCategories.Remove(maincategory);
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
	/// <param name="id">The maincategory Id.</param>
	public override void Delete(int id)
	{
		try
		{
			var maincategory = GetById(id);
			DataContext.MainCategories.Remove(maincategory);
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
	/// <param name="maincategory">The maincategory entity.</param>
	public override void Update(MainCategory maincategory)
	{
		try
		{
			DataContext.Entry(maincategory).State = EntityState.Modified;
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
