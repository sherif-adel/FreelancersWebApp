
namespace FreeLancers.DAL
{

using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using FreeLancers.Models;

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
		return DataContext.Projects.FirstOrDefault(entity => entity.ProjectID == id);
	}

	/// <summary>
	/// Gets All.
	/// </summary>
	public override List<Project> GetAll()
	{
		return DataContext.Projects.ToList();
	}

	/// <summary>
	/// Adds the specified entity.
	/// </summary>
	/// <param name="project">The project entity.</param>
	public override void Add(Project project)
	{
		DataContext.Projects.Add(project);
		DataContext.SaveChanges();
	}

	/// <summary>
	/// Deletes the specified entity.
	/// </summary>
	/// <param name="project">The project entity.</param>
	public override void Delete(Project project)
	{

		DataContext.Projects.Remove(project);
		DataContext.SaveChanges();
	}

	/// <summary>
	/// Deletes the entity by Id.
	/// </summary>
	/// <param name="id">The project Id.</param>
	public override void Delete(int id)
	{
		var project = GetById(id);
		DataContext.Projects.Remove(project);
		DataContext.SaveChanges();
	}

	/// <summary>
	/// Updates the specified entity.
	/// </summary>
	/// <param name="project">The project entity.</param>
	public override void Update(Project project)
	{
		DataContext.Entry(project).State = EntityState.Modified;
		DataContext.SaveChanges();
	}

        #endregion

    
}

}
