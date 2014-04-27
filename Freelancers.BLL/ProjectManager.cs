namespace Freelancers.BLL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FreeLancers.Models;
    using FreeLancers.DAL;
    
    public partial class ProjectManager
    {
        #region Methods
    
    	/// <summary>
    	/// Gets the specified entity by ID.
    	/// </summary>
    	/// <param name="id">The project ID.</param>
    	public static Project GetById(int id)
    	{
    		return ProjectDataService.GetById(id);
    	}
    
    	/// <summary>
    	/// Gets All.
    	/// </summary>
    	public static List<Project> GetAll()
    	{
    		return ProjectDataService.GetAll();
    	}
    
    	/// <summary>
    	/// Adds the specified entity.
    	/// </summary>
    	/// <param name="project">The project entity.</param>
    	public static void Add(Project project)
    	{
    		ProjectDataService.Add(project);
    	}
    
    	/// <summary>
    	/// Deletes the specified entity.
    	/// </summary>
    	/// <param name="project">The project entity.</param>
    	public static void Delete(Project project)
    	{
    		ProjectDataService.Delete(project);
    	}
    
    	/// <summary>
    	/// Deletes the entity by Id.
    	/// </summary>
    	/// <param name="id">The project Id.</param>
    	public static void DeleteById(int id)
    	{
    		ProjectDataService.DeleteById(id);
    	}
    
    	/// <summary>
    	/// Updates the specified entity.
    	/// </summary>
    	/// <param name="project">The project entity.</param>
    	public static void Update(Project project)
    	{
    		ProjectDataService.Update(project);
    	}
    
    	/// <summary>
    	/// Queries the entity.
    	/// </summary>
    	/// <param name="criteria">Search Criteria.</param>
    	public static List<Project> Search(System.Linq.Expressions.Expression<Func<Project, bool>> criteria)
    	{
    		return ProjectDataService.Search(criteria);
    	}

        #endregion

    }
}
