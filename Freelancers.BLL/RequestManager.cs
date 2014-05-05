namespace Freelancers.BLL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FreeLancers.Models;
    using FreeLancers.DAL;
    
    public partial class RequestManager : ManagersBase<Request>
    {
    
        #region Properties
    
    	private RequestDataService _requestDataService;

        #endregion

        #region Constructor
        public RequestManager(FreeLancersEntities entities):base(entities)
    	{
    		_requestDataService = new RequestDataService(entities);
        }

        #endregion

        #region Methods
    
    	/// <summary>
    	/// Gets the specified entity by ID.
    	/// </summary>
    	/// <param name="id">The request ID.</param>
    	public override Request GetById(int id)
    	{
    		return _requestDataService.GetById(id);
    	}
    
    	/// <summary>
    	/// Gets All.
    	/// </summary>
    	public override List<Request> GetAll()
    	{
    		return _requestDataService.GetAll();
    	}
    
    	/// <summary>
    	/// Adds the specified entity.
    	/// </summary>
    	/// <param name="request">The request entity.</param>
    	public override void Add(Request request)
    	{
    		_requestDataService.Add(request);
    	}
    
    	/// <summary>
    	/// Deletes the specified entity.
    	/// </summary>
    	/// <param name="request">The request entity.</param>
    	public override void Delete(Request request)
    	{
    		_requestDataService.Delete(request);
    	}
    
    	/// <summary>
    	/// Deletes the entity by Id.
    	/// </summary>
    	/// <param name="id">The request Id.</param>
    	public override void Delete(int id)
    	{
    		_requestDataService.Delete(id);
    	}
    
    	/// <summary>
    	/// Updates the specified entity.
    	/// </summary>
    	/// <param name="request">The request entity.</param>
    	public override void Update(Request request)
    	{
    		_requestDataService.Update(request);
    	}
    
    	/// <summary>
    	/// Queries the entity.
    	/// </summary>
    	/// <param name="criteria">Search Criteria.</param>
    	public override List<Request> Search(Func<Request, bool> criteria)
    	{
    		return _requestDataService.Search(criteria);
    	}

        #endregion

    }
}
