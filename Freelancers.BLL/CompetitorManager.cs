namespace Freelancers.BLL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FreeLancers.Models;
    using FreeLancers.DAL;
    
    public partial class CompetitorManager : ManagersBase<Competitor>
    {
    
        #region Properties
    
    	private CompetitorDataService _competitorDataService;

        #endregion

        #region Constructor
        public CompetitorManager(FreeLancersEntities entities):base(entities)
    	{
    		_competitorDataService = new CompetitorDataService(entities);
        }

        #endregion

        #region Methods
    
    	/// <summary>
    	/// Gets the specified entity by ID.
    	/// </summary>
    	/// <param name="id">The competitor ID.</param>
    	public override Competitor GetById(int id)
    	{
    		return _competitorDataService.GetById(id);
    	}
    
    	/// <summary>
    	/// Gets All.
    	/// </summary>
    	public override List<Competitor> GetAll()
    	{
    		return _competitorDataService.GetAll();
    	}
    
    	/// <summary>
    	/// Adds the specified entity.
    	/// </summary>
    	/// <param name="competitor">The competitor entity.</param>
    	public override void Add(Competitor competitor)
    	{
    		_competitorDataService.Add(competitor);
    	}
    
    	/// <summary>
    	/// Deletes the specified entity.
    	/// </summary>
    	/// <param name="competitor">The competitor entity.</param>
    	public override void Delete(Competitor competitor)
    	{
    		_competitorDataService.Delete(competitor);
    	}
    
    	/// <summary>
    	/// Deletes the entity by Id.
    	/// </summary>
    	/// <param name="id">The competitor Id.</param>
    	public override void Delete(int id)
    	{
    		_competitorDataService.Delete(id);
    	}
    
    	/// <summary>
    	/// Updates the specified entity.
    	/// </summary>
    	/// <param name="competitor">The competitor entity.</param>
    	public override void Update(Competitor competitor)
    	{
    		_competitorDataService.Update(competitor);
    	}
    
    	/// <summary>
    	/// Queries the entity.
    	/// </summary>
    	/// <param name="criteria">Search Criteria.</param>
    	public override List<Competitor> Search(Func<Competitor, bool> criteria)
    	{
    		return _competitorDataService.Search(criteria);
    	}

        #endregion

    }
}
