namespace Freelancers.BLL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FreeLancers.Models;
    using FreeLancers.DAL;
    
    public partial class StatusManager : ManagersBase<Status>
    {
    
        #region Properties
    
    	private StatusDataService _statusDataService;

        #endregion

        #region Constructor
        public StatusManager(FreeLancersEntities entities):base(entities)
    	{
    		_statusDataService = new StatusDataService(entities);
        }

        #endregion

        #region Methods
    
    	/// <summary>
    	/// Gets the specified entity by ID.
    	/// </summary>
    	/// <param name="id">The status ID.</param>
    	public override Status GetById(int id)
    	{
    		return _statusDataService.GetById(id);
    	}
    
    	/// <summary>
    	/// Gets All.
    	/// </summary>
    	public override List<Status> GetAll()
    	{
    		return _statusDataService.GetAll();
    	}
    
    	/// <summary>
    	/// Adds the specified entity.
    	/// </summary>
    	/// <param name="status">The status entity.</param>
    	public override void Add(Status status)
    	{
    		_statusDataService.Add(status);
    	}
    
    	/// <summary>
    	/// Deletes the specified entity.
    	/// </summary>
    	/// <param name="status">The status entity.</param>
    	public override void Delete(Status status)
    	{
    		_statusDataService.Delete(status);
    	}
    
    	/// <summary>
    	/// Deletes the entity by Id.
    	/// </summary>
    	/// <param name="id">The status Id.</param>
    	public override void Delete(int id)
    	{
    		_statusDataService.Delete(id);
    	}
    
    	/// <summary>
    	/// Updates the specified entity.
    	/// </summary>
    	/// <param name="status">The status entity.</param>
    	public override void Update(Status status)
    	{
    		_statusDataService.Update(status);
    	}
    
    	/// <summary>
    	/// Queries the entity.
    	/// </summary>
    	/// <param name="criteria">Search Criteria.</param>
    	public override List<Status> Search(Func<Status, bool> criteria)
    	{
    		return _statusDataService.Search(criteria);
    	}

        #endregion

    }
}
