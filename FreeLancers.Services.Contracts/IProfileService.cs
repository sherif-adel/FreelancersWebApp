namespace FreeLancers.Service.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.ServiceModel;
    using System.Text;
    
    [ServiceContract]
    public partial interface IProfileService
    {
        #region Methods
    
    	/// <summary>
    	/// Gets the specified entity by ID.
    	/// </summary>
    	/// <param name="id">The profile ID.</param>
    	[OperationContract]
    	ProfileContract GetById(int id);
    
    	/// <summary>
    	/// Gets All.
    	/// </summary>
    	[OperationContract]
    	List<ProfileContract> GetAll();
    
    	/// <summary>
    	/// Adds the specified entity.
    	/// </summary>
    	/// <param name="profile">The profile entity.</param>
    	[OperationContract]
    	void Add(ProfileContract profile);
    
    	/// <summary>
    	/// Deletes the specified entity.
    	/// </summary>
    	/// <param name="profile">The profile entity.</param>
    	[OperationContract]
    	void Delete(ProfileContract profile);
    	/// <summary>
    	/// Deletes the entity by Id.
    	/// </summary>
    	/// <param name="id">The profile Id.</param>
    	[OperationContract]
    	void DeleteById(int id);
    	/// <summary>
    	/// Updates the specified entity.
    	/// </summary>
    	/// <param name="profile">The profile entity.</param>
    	[OperationContract]
    	void Update(ProfileContract profile);
    	/// <summary>
    	/// Queries the entity.
    	/// </summary>
    	/// <param name="criteria">Search Criteria.</param>
    	[OperationContract]
    	List<ProfileContract> Search(Func<dynamic, bool> criteria);

        #endregion

    }
}
