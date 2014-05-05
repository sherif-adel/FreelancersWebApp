namespace Freelancers.BLL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FreeLancers.Models;
    using FreeLancers.DAL;
    
    public partial class ProfileManager : ManagersBase<Profile>
    {
    
        #region Properties
    
    	private ProfileDataService _profileDataService;

        #endregion

        #region Constructor
        public ProfileManager(FreeLancersEntities entities):base(entities)
    	{
    		_profileDataService = new ProfileDataService(entities);
        }

        #endregion

        #region Methods
    
    	/// <summary>
    	/// Gets the specified entity by ID.
    	/// </summary>
    	/// <param name="id">The profile ID.</param>
    	public override Profile GetById(int id)
    	{
    		return _profileDataService.GetById(id);
    	}
    
    	/// <summary>
    	/// Gets All.
    	/// </summary>
    	public override List<Profile> GetAll()
    	{
    		return _profileDataService.GetAll();
    	}
    
    	/// <summary>
    	/// Adds the specified entity.
    	/// </summary>
    	/// <param name="profile">The profile entity.</param>
    	public override void Add(Profile profile)
    	{
    		_profileDataService.Add(profile);
    	}
    
    	/// <summary>
    	/// Deletes the specified entity.
    	/// </summary>
    	/// <param name="profile">The profile entity.</param>
    	public override void Delete(Profile profile)
    	{
    		_profileDataService.Delete(profile);
    	}
    
    	/// <summary>
    	/// Deletes the entity by Id.
    	/// </summary>
    	/// <param name="id">The profile Id.</param>
    	public override void Delete(int id)
    	{
    		_profileDataService.Delete(id);
    	}
    
    	/// <summary>
    	/// Updates the specified entity.
    	/// </summary>
    	/// <param name="profile">The profile entity.</param>
    	public override void Update(Profile profile)
    	{
    		_profileDataService.Update(profile);
    	}
    
    	/// <summary>
    	/// Queries the entity.
    	/// </summary>
    	/// <param name="criteria">Search Criteria.</param>
    	public override List<Profile> Search(Func<Profile, bool> criteria)
    	{
    		return _profileDataService.Search(criteria);
    	}

        #endregion

    }
}
