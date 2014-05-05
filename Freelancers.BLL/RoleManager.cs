namespace Freelancers.BLL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FreeLancers.Models;
    using FreeLancers.DAL;
    
    public partial class RoleManager : ManagersBase<Role>
    {
    
        #region Properties
    
    	private RoleDataService _roleDataService;

        #endregion

        #region Constructor
        public RoleManager(FreeLancersEntities entities):base(entities)
    	{
    		_roleDataService = new RoleDataService(entities);
        }

        #endregion

        #region Methods
    
    	/// <summary>
    	/// Gets the specified entity by ID.
    	/// </summary>
    	/// <param name="id">The role ID.</param>
    	public override Role GetById(int id)
    	{
    		return _roleDataService.GetById(id);
    	}
    
    	/// <summary>
    	/// Gets All.
    	/// </summary>
    	public override List<Role> GetAll()
    	{
    		return _roleDataService.GetAll();
    	}
    
    	/// <summary>
    	/// Adds the specified entity.
    	/// </summary>
    	/// <param name="role">The role entity.</param>
    	public override void Add(Role role)
    	{
    		_roleDataService.Add(role);
    	}
    
    	/// <summary>
    	/// Deletes the specified entity.
    	/// </summary>
    	/// <param name="role">The role entity.</param>
    	public override void Delete(Role role)
    	{
    		_roleDataService.Delete(role);
    	}
    
    	/// <summary>
    	/// Deletes the entity by Id.
    	/// </summary>
    	/// <param name="id">The role Id.</param>
    	public override void Delete(int id)
    	{
    		_roleDataService.Delete(id);
    	}
    
    	/// <summary>
    	/// Updates the specified entity.
    	/// </summary>
    	/// <param name="role">The role entity.</param>
    	public override void Update(Role role)
    	{
    		_roleDataService.Update(role);
    	}
    
    	/// <summary>
    	/// Queries the entity.
    	/// </summary>
    	/// <param name="criteria">Search Criteria.</param>
    	public override List<Role> Search(Func<Role, bool> criteria)
    	{
    		return _roleDataService.Search(criteria);
    	}

        #endregion

    }
}
