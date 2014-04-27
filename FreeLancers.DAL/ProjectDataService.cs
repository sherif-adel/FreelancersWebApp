namespace FreeLancers.DAL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FreeLancers.Models;
    
    public partial class ProjectDataService
    {
        #region Methods
    
    	/// <summary>
    	/// Gets the specified entity by Id.
    	/// </summary>
    	/// <param name="id">The project Id.</param>
    	public static Project GetById(int id)
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			return entities.Projects.FirstOrDefault(entity => entity.ProjectID == id);
    		}
    	}
    
    	/// <summary>
    	/// Gets All.
    	/// </summary>
    	public static List<Project> GetAll()
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			return entities.Projects.ToList();
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
    			entities.Projects.Add(project);
    			entities.SaveChanges();
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
    			entities.Projects.Remove(project);
    			entities.SaveChanges();
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
    			var project = GetById(id);
    			entities.Projects.Remove(project);
    			entities.SaveChanges();
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
    			entities.Entry(project).State = System.Data.EntityState.Modified;
    			entities.SaveChanges();
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
    			return entities.Projects.Where(criteria).ToList();
    		}
    	}

        #endregion

    }
}
