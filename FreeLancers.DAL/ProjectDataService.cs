
namespace FreeLancers.DAL
{

	using System;
	using System.Data.Entity;
	using System.Collections.Generic;
	using System.Linq;
	using FreeLancers.Models;
	using FreeLancers.Log;

public partial class ProjectDataService : DataServiceBase<Project>
{
    #region Constructor
    
	/// <summary>
	/// Gets the specified entity by Id.
	/// </summary>
	/// <param name="id">The project Id.</param>
	public ProjectDataService(FreeLancersEntities dataContext):base(dataContext)
	{
		this.DataContext = dataContext;
	}

        #endregion

    

    #region Methods
    

	/// <summary>
	/// Gets the specified entity by Id.
	/// </summary>
	/// <param name="id">The project Id.</param>
	public override Project GetById(int id)
	{
		try
		{
			return DataContext.Projects.FirstOrDefault(entity => entity.ProjectID == id);
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
	public override List<Project> GetAll()
	{
		try
		{
			return DataContext.Projects.ToList();
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
	/// <param name="project">The project entity.</param>
	public override void Add(Project project)
	{
		try
		{
			DataContext.Projects.Add(project);
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
	/// <param name="project">The project entity.</param>
	public override void Delete(Project project)
	{
		try
		{
			DataContext.Projects.Remove(project);
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
	/// <param name="id">The project Id.</param>
	public override void Delete(int id)
	{
		try
		{
			var project = GetById(id);
			DataContext.Projects.Remove(project);
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
	/// <param name="project">The project entity.</param>
	public override void Update(Project project)
	{
		try
		{
			DataContext.Entry(project).State = EntityState.Modified;
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
