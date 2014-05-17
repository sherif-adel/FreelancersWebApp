
namespace FreeLancers.DAL
{

using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using FreeLancers.Models;

public partial class CompetitorDataService : DataServiceBase<Competitor>
{
    #region Constructor
    
	/// <summary>
	/// Gets the specified entity by Id.
	/// </summary>
	/// <param name="id">The competitor Id.</param>
	public CompetitorDataService(FreeLancersEntities dataContext):base(dataContext)
	{
		this.DataContext = dataContext;
	}

        #endregion

    

    #region Methods
    

	/// <summary>
	/// Gets the specified entity by Id.
	/// </summary>
	/// <param name="id">The competitor Id.</param>
	public override Competitor GetById(int id)
	{
		return DataContext.Competitors.FirstOrDefault(entity => entity.CompetitorID == id);
	}

	/// <summary>
	/// Gets All.
	/// </summary>
	public override List<Competitor> GetAll()
	{
		return DataContext.Competitors.ToList();
	}

	/// <summary>
	/// Adds the specified entity.
	/// </summary>
	/// <param name="competitor">The competitor entity.</param>
	public override void Add(Competitor competitor)
	{
		DataContext.Competitors.Add(competitor);
		DataContext.SaveChanges();
	}

	/// <summary>
	/// Deletes the specified entity.
	/// </summary>
	/// <param name="competitor">The competitor entity.</param>
	public override void Delete(Competitor competitor)
	{

		DataContext.Competitors.Remove(competitor);
		DataContext.SaveChanges();
	}

	/// <summary>
	/// Deletes the entity by Id.
	/// </summary>
	/// <param name="id">The competitor Id.</param>
	public override void Delete(int id)
	{
		var competitor = GetById(id);
		DataContext.Competitors.Remove(competitor);
		DataContext.SaveChanges();
	}

	/// <summary>
	/// Updates the specified entity.
	/// </summary>
	/// <param name="competitor">The competitor entity.</param>
	public override void Update(Competitor competitor)
	{
		DataContext.Entry(competitor).State = EntityState.Modified;
		DataContext.SaveChanges();
	}

        #endregion

    
}

}
