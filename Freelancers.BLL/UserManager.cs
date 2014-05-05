namespace Freelancers.BLL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FreeLancers.Models;
    using FreeLancers.DAL;
    
    public partial class UserManager : ManagersBase<User>
    {
    
        #region Properties
    
    	private UserDataService _userDataService;

        #endregion

        #region Constructor
        public UserManager(FreeLancersEntities entities):base(entities)
    	{
    		_userDataService = new UserDataService(entities);
        }

        #endregion

        #region Methods
    
    	/// <summary>
    	/// Gets the specified entity by ID.
    	/// </summary>
    	/// <param name="id">The user ID.</param>
    	public override User GetById(int id)
    	{
    		return _userDataService.GetById(id);
    	}
    
    	/// <summary>
    	/// Gets All.
    	/// </summary>
    	public override List<User> GetAll()
    	{
    		return _userDataService.GetAll();
    	}
    
    	/// <summary>
    	/// Adds the specified entity.
    	/// </summary>
    	/// <param name="user">The user entity.</param>
    	public override void Add(User user)
    	{
    		_userDataService.Add(user);
    	}
    
    	/// <summary>
    	/// Deletes the specified entity.
    	/// </summary>
    	/// <param name="user">The user entity.</param>
    	public override void Delete(User user)
    	{
    		_userDataService.Delete(user);
    	}
    
    	/// <summary>
    	/// Deletes the entity by Id.
    	/// </summary>
    	/// <param name="id">The user Id.</param>
    	public override void Delete(int id)
    	{
    		_userDataService.Delete(id);
    	}
    
    	/// <summary>
    	/// Updates the specified entity.
    	/// </summary>
    	/// <param name="user">The user entity.</param>
    	public override void Update(User user)
    	{
    		_userDataService.Update(user);
    	}
    
    	/// <summary>
    	/// Queries the entity.
    	/// </summary>
    	/// <param name="criteria">Search Criteria.</param>
    	public override List<User> Search(Func<User, bool> criteria)
    	{
    		return _userDataService.Search(criteria);
    	}

        #endregion

    }
}
