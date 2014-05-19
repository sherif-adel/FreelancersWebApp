
namespace FreeLancers.DAL
{

	using System;
	using System.Data.Entity;
	using System.Collections.Generic;
	using System.Linq;
	using FreeLancers.Models;
	using FreeLancers.Log;

public partial class StatusDataService : DataServiceBase<Status>
{
    #region Constructor
    
	/// <summary>
	/// Gets the specified entity by Id.
	/// </summary>
	/// <param name="id">The status Id.</param>
	public StatusDataService(FreeLancersEntities dataContext):base(dataContext)
	{
		this.DataContext = dataContext;
	}

        #endregion

    

    #region Methods
    

	/// <summary>
	/// Gets the specified entity by Id.
	/// </summary>
	/// <param name="id">The status Id.</param>
	public override Status GetById(int id)
	{
		try
		{
			return DataContext.Status.FirstOrDefault(entity => entity.StatusID == id);
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
	public override List<Status> GetAll()
	{
		try
		{
			return DataContext.Status.ToList();
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
	/// <param name="status">The status entity.</param>
	public override void Add(Status status)
	{
		try
		{
			DataContext.Status.Add(status);
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
	/// <param name="status">The status entity.</param>
	public override void Delete(Status status)
	{
		try
		{
			DataContext.Status.Remove(status);
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
	/// <param name="id">The status Id.</param>
	public override void Delete(int id)
	{
		try
		{
			var status = GetById(id);
			DataContext.Status.Remove(status);
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
	/// <param name="status">The status entity.</param>
	public override void Update(Status status)
	{
		try
		{
			DataContext.Entry(status).State = EntityState.Modified;
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
