
namespace FreeLancers.DAL
{

using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using FreeLancers.Models;

public partial class ProfileDataService : DataServiceBase<Profile>
{
    #region Constructor
    
	/// <summary>
	/// Gets the specified entity by Id.
	/// </summary>
	/// <param name="id">The profile Id.</param>
	public ProfileDataService(FreeLancersEntities dataContext):base(dataContext)
	{
		this.DataContext = dataContext;
	}

        #endregion

    

    #region Methods
    

	/// <summary>
	/// Gets the specified entity by Id.
	/// </summary>
	/// <param name="id">The profile Id.</param>
	public override Profile GetById(int id)
	{
		return DataContext.Profiles.FirstOrDefault(entity => entity.ProfileID == id);
	}

	/// <summary>
	/// Gets All.
	/// </summary>
	public override List<Profile> GetAll()
	{
		return DataContext.Profiles.ToList();
	}

	/// <summary>
	/// Adds the specified entity.
	/// </summary>
	/// <param name="profile">The profile entity.</param>
	public override void Add(Profile profile)
	{
		DataContext.Profiles.Add(profile);
		DataContext.SaveChanges();
	}

	/// <summary>
	/// Deletes the specified entity.
	/// </summary>
	/// <param name="profile">The profile entity.</param>
	public override void Delete(Profile profile)
	{

		DataContext.Profiles.Remove(profile);
		DataContext.SaveChanges();
	}

	/// <summary>
	/// Deletes the entity by Id.
	/// </summary>
	/// <param name="id">The profile Id.</param>
	public override void Delete(int id)
	{
		var profile = GetById(id);
		DataContext.Profiles.Remove(profile);
		DataContext.SaveChanges();
	}

	/// <summary>
	/// Updates the specified entity.
	/// </summary>
	/// <param name="profile">The profile entity.</param>
	public override void Update(Profile profile)
	{
		DataContext.Entry(profile).State = EntityState.Modified;
		DataContext.SaveChanges();
	}

        #endregion

    
}

}
