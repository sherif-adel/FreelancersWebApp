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
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			return ProjectDataService.GetById(id);
    		}
    	}
    
    	/// <summary>
    	/// Gets All.
    	/// </summary>
    	public static List<Project> GetAll()
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			return ProjectDataService.GetAll();
    		}
    	}
    
    	/// <summary>
    	/// Adds the specified entity.
    	/// </summary>
    	/// <param name="project">The project entity.</param>
    	public static void Add(Project project)
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
            {
    			ProjectDataService.Add(project);
            }
    	}
    
    	/// <summary>
    	/// Deletes the specified entity.
    	/// </summary>
    	/// <param name="project">The project entity.</param>
    	public static void Delete(Project project)
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			ProjectDataService.Delete(project);
    		}
    	}
    
    	/// <summary>
    	/// Deletes the entity by Id.
    	/// </summary>
    	/// <param name="id">The project Id.</param>
    	public static void DeleteById(int id)
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			ProjectDataService.DeleteById(id);
    		}
    	}
    
    	/// <summary>
    	/// Updates the specified entity.
    	/// </summary>
    	/// <param name="project">The project entity.</param>
    	public static void Update(Project project)
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			ProjectDataService.Update(project);
    		}
    	}
    
    	/// <summary>
    	/// Queries the entity.
    	/// </summary>
    	/// <param name="criteria">Search Criteria.</param>
    	public static List<Project> Search(System.Linq.Expressions.Expression<Func<Project, bool>> criteria)
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			return ProjectDataService.Search(criteria);
    		}
    	}

        #endregion

    }
}
