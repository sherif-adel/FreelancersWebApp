
namespace FreeLancers.DAL
{

	using System;
	using System.Data.Entity;
	using System.Collections.Generic;
	using System.Linq;
	using FreeLancers.Models;
	using FreeLancers.Log;

public partial class SubCategoryDataService : DataServiceBase<SubCategory>
{
    #region Constructor
    
	/// <summary>
	/// Gets the specified entity by Id.
	/// </summary>
	/// <param name="id">The subcategory Id.</param>
	public SubCategoryDataService(FreeLancersEntities dataContext):base(dataContext)
	{
		this.DataContext = dataContext;
	}

        #endregion

    

    #region Methods
    

	/// <summary>
	/// Gets the specified entity by Id.
	/// </summary>
	/// <param name="id">The subcategory Id.</param>
	public override SubCategory GetById(int id)
	{
		try
		{
			return DataContext.SubCategories.FirstOrDefault(entity => entity.SubCategoryID == id);
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
	public override List<SubCategory> GetAll()
	{
		try
		{
			return DataContext.SubCategories.ToList();
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
	/// <param name="subcategory">The subcategory entity.</param>
	public override void Add(SubCategory subcategory)
	{
		try
		{
			DataContext.SubCategories.Add(subcategory);
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
	/// <param name="subcategory">The subcategory entity.</param>
	public override void Delete(SubCategory subcategory)
	{
		try
		{
			DataContext.SubCategories.Remove(subcategory);
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
	/// <param name="id">The subcategory Id.</param>
	public override void Delete(int id)
	{
		try
		{
			var subcategory = GetById(id);
			DataContext.SubCategories.Remove(subcategory);
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
	/// <param name="subcategory">The subcategory entity.</param>
	public override void Update(SubCategory subcategory)
	{
		try
		{
			DataContext.Entry(subcategory).State = EntityState.Modified;
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
