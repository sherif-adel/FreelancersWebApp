namespace Freelancers.BLL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FreeLancers.Models;
    using FreeLancers.DAL;
    
    public partial class ProjectManager : ManagersBase<Project>
    {
    
        #region Properties
    
    	private ProjectDataService _projectDataService;

        #endregion

        #region Constructor
        public ProjectManager(FreeLancersEntities entities):base(entities)
    	{
    		_projectDataService = new ProjectDataService(entities);
        }

        #endregion

        #region Methods
    
    	/// <summary>
    	/// Gets the specified entity by ID.
    	/// </summary>
    	/// <param name="id">The project ID.</param>
    	public override Project GetById(int id)
    	{
    		return _projectDataService.GetById(id);
    	}
    
    	/// <summary>
    	/// Gets All.
    	/// </summary>
    	public override List<Project> GetAll()
    	{
    		return _projectDataService.GetAll();
    	}
    
    	/// <summary>
    	/// Adds the specified entity.
    	/// </summary>
    	/// <param name="project">The project entity.</param>
    	public override void Add(Project project)
    	{
    		_projectDataService.Add(project);
    	}
    
    	/// <summary>
    	/// Deletes the specified entity.
    	/// </summary>
    	/// <param name="project">The project entity.</param>
    	public override void Delete(Project project)
    	{
    		_projectDataService.Delete(project);
    	}
    
    	/// <summary>
    	/// Deletes the entity by Id.
    	/// </summary>
    	/// <param name="id">The project Id.</param>
    	public override void Delete(int id)
    	{
    		_projectDataService.Delete(id);
    	}
    
    	/// <summary>
    	/// Updates the specified entity.
    	/// </summary>
    	/// <param name="project">The project entity.</param>
    	public override void Update(Project project)
    	{
    		_projectDataService.Update(project);
    	}
    
    	/// <summary>
    	/// Queries the entity.
    	/// </summary>
    	/// <param name="criteria">Search Criteria.</param>
    	public override List<Project> Search(Func<Project, bool> criteria)
    	{
    		return _projectDataService.Search(criteria);
    	}

        #endregion

    }
}
