
namespace FreeLancers.DAL
{

using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using FreeLancers.Models;

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
		return DataContext.Status.FirstOrDefault(entity => entity.StatusID == id);
	}

	/// <summary>
	/// Gets All.
	/// </summary>
	public override List<Status> GetAll()
	{
		return DataContext.Status.ToList();
	}

	/// <summary>
	/// Adds the specified entity.
	/// </summary>
	/// <param name="status">The status entity.</param>
	public override void Add(Status status)
	{
		DataContext.Status.Add(status);
		DataContext.SaveChanges();
	}

	/// <summary>
	/// Deletes the specified entity.
	/// </summary>
	/// <param name="status">The status entity.</param>
	public override void Delete(Status status)
	{

		DataContext.Status.Remove(status);
		DataContext.SaveChanges();
	}

	/// <summary>
	/// Deletes the entity by Id.
	/// </summary>
	/// <param name="id">The status Id.</param>
	public override void Delete(int id)
	{
		var status = GetById(id);
		DataContext.Status.Remove(status);
		DataContext.SaveChanges();
	}

	/// <summary>
	/// Updates the specified entity.
	/// </summary>
	/// <param name="status">The status entity.</param>
	public override void Update(Status status)
	{
		DataContext.Entry(status).State = EntityState.Modified;
		DataContext.SaveChanges();
	}

        #endregion

    
}

}
