
namespace FreeLancers.DAL
{

using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using FreeLancers.Models;

public partial class RoleDataService : DataServiceBase<Role>
{
    #region Constructor
    
	/// <summary>
	/// Gets the specified entity by Id.
	/// </summary>
	/// <param name="id">The role Id.</param>
	public RoleDataService(FreeLancersEntities dataContext):base(dataContext)
	{
		this.DataContext = dataContext;
	}

        #endregion

    

    #region Methods
    

	/// <summary>
	/// Gets the specified entity by Id.
	/// </summary>
	/// <param name="id">The role Id.</param>
	public override Role GetById(int id)
	{
		return DataContext.Roles.FirstOrDefault(entity => entity.RoleID == id);
	}

	/// <summary>
	/// Gets All.
	/// </summary>
	public override List<Role> GetAll()
	{
		return DataContext.Roles.ToList();
	}

	/// <summary>
	/// Adds the specified entity.
	/// </summary>
	/// <param name="role">The role entity.</param>
	public override void Add(Role role)
	{
		DataContext.Roles.Add(role);
		DataContext.SaveChanges();
	}

	/// <summary>
	/// Deletes the specified entity.
	/// </summary>
	/// <param name="role">The role entity.</param>
	public override void Delete(Role role)
	{

		DataContext.Roles.Remove(role);
		DataContext.SaveChanges();
	}

	/// <summary>
	/// Deletes the entity by Id.
	/// </summary>
	/// <param name="id">The role Id.</param>
	public override void Delete(int id)
	{
		var role = GetById(id);
		DataContext.Roles.Remove(role);
		DataContext.SaveChanges();
	}

	/// <summary>
	/// Updates the specified entity.
	/// </summary>
	/// <param name="role">The role entity.</param>
	public override void Update(Role role)
	{
		DataContext.Entry(role).State = EntityState.Modified;
		DataContext.SaveChanges();
	}

        #endregion

    
}

}
