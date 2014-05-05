
namespace FreeLancers.DAL
{

using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using FreeLancers.Models;

public partial class UserDataService : DataServiceBase<User>
{
    #region Constructor
    
	/// <summary>
	/// Gets the specified entity by Id.
	/// </summary>
	/// <param name="id">The user Id.</param>
	public UserDataService(FreeLancersEntities dataContext):base(dataContext)
	{
		this.DataContext = dataContext;
	}

        #endregion

    

    #region Methods
    

	/// <summary>
	/// Gets the specified entity by Id.
	/// </summary>
	/// <param name="id">The user Id.</param>
	public override User GetById(int id)
	{
		return DataContext.Users.FirstOrDefault(entity => entity.UserID == id);
	}

	/// <summary>
	/// Gets All.
	/// </summary>
	public override List<User> GetAll()
	{
		return DataContext.Users.ToList();
	}

	/// <summary>
	/// Adds the specified entity.
	/// </summary>
	/// <param name="user">The user entity.</param>
	public override void Add(User user)
	{
		DataContext.Users.Add(user);
		DataContext.SaveChanges();
	}

	/// <summary>
	/// Deletes the specified entity.
	/// </summary>
	/// <param name="user">The user entity.</param>
	public override void Delete(User user)
	{

		DataContext.Users.Remove(user);
		DataContext.SaveChanges();
	}

	/// <summary>
	/// Deletes the entity by Id.
	/// </summary>
	/// <param name="id">The user Id.</param>
	public override void Delete(int id)
	{
		var user = GetById(id);
		DataContext.Users.Remove(user);
		DataContext.SaveChanges();
	}

	/// <summary>
	/// Updates the specified entity.
	/// </summary>
	/// <param name="user">The user entity.</param>
	public override void Update(User user)
	{
		DataContext.Entry(user).State = EntityState.Modified;
		DataContext.SaveChanges();
	}

        #endregion

    
}

}
