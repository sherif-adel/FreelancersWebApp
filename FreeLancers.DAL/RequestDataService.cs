
namespace FreeLancers.DAL
{

using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using FreeLancers.Models;

public partial class RequestDataService : DataServiceBase<Request>
{
    #region Constructor
    
	/// <summary>
	/// Gets the specified entity by Id.
	/// </summary>
	/// <param name="id">The request Id.</param>
	public RequestDataService(FreeLancersEntities dataContext):base(dataContext)
	{
		this.DataContext = dataContext;
	}

        #endregion

    

    #region Methods
    

	/// <summary>
	/// Gets the specified entity by Id.
	/// </summary>
	/// <param name="id">The request Id.</param>
	public override Request GetById(int id)
	{
		return DataContext.Requests.FirstOrDefault(entity => entity.RequestID == id);
	}

	/// <summary>
	/// Gets All.
	/// </summary>
	public override List<Request> GetAll()
	{
		return DataContext.Requests.ToList();
	}

	/// <summary>
	/// Adds the specified entity.
	/// </summary>
	/// <param name="request">The request entity.</param>
	public override void Add(Request request)
	{
		DataContext.Requests.Add(request);
		DataContext.SaveChanges();
	}

	/// <summary>
	/// Deletes the specified entity.
	/// </summary>
	/// <param name="request">The request entity.</param>
	public override void Delete(Request request)
	{

		DataContext.Requests.Remove(request);
		DataContext.SaveChanges();
	}

	/// <summary>
	/// Deletes the entity by Id.
	/// </summary>
	/// <param name="id">The request Id.</param>
	public override void Delete(int id)
	{
		var request = GetById(id);
		DataContext.Requests.Remove(request);
		DataContext.SaveChanges();
	}

	/// <summary>
	/// Updates the specified entity.
	/// </summary>
	/// <param name="request">The request entity.</param>
	public override void Update(Request request)
	{
		DataContext.Entry(request).State = EntityState.Modified;
		DataContext.SaveChanges();
	}

        #endregion

    
}

}
