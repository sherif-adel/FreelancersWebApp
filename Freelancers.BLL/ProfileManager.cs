namespace Freelancers.BLL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FreeLancers.Models;
    using FreeLancers.DAL;
    
    public partial class ProfileManager
    {
        #region Methods
    
    	/// <summary>
    	/// Gets the specified entity by ID.
    	/// </summary>
    	/// <param name="id">The profile ID.</param>
    	public static Profile GetById(int id)
    	{
    		return ProfileDataService.GetById(id);
    	}
    
    	/// <summary>
    	/// Gets All.
    	/// </summary>
    	public static List<Profile> GetAll()
    	{
    		return ProfileDataService.GetAll();
    	}
    
    	/// <summary>
    	/// Adds the specified entity.
    	/// </summary>
    	/// <param name="profile">The profile entity.</param>
    	public static void Add(Profile profile)
    	{
    		ProfileDataService.Add(profile);
    	}
    
    	/// <summary>
    	/// Deletes the specified entity.
    	/// </summary>
    	/// <param name="profile">The profile entity.</param>
    	public static void Delete(Profile profile)
    	{
    		ProfileDataService.Delete(profile);
    	}
    
    	/// <summary>
    	/// Deletes the entity by Id.
    	/// </summary>
    	/// <param name="id">The profile Id.</param>
    	public static void DeleteById(int id)
    	{
    		ProfileDataService.DeleteById(id);
    	}
    
    	/// <summary>
    	/// Updates the specified entity.
    	/// </summary>
    	/// <param name="profile">The profile entity.</param>
    	public static void Update(Profile profile)
    	{
    		ProfileDataService.Update(profile);
    	}
    
    	/// <summary>
    	/// Queries the entity.
    	/// </summary>
    	/// <param name="criteria">Search Criteria.</param>
    	public static List<Profile> Search(System.Linq.Expressions.Expression<Func<Profile, bool>> criteria)
    	{
    		return ProfileDataService.Search(criteria);
    	}

        #endregion

    }
}
