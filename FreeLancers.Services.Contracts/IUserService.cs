namespace FreeLancers.Service.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.ServiceModel;
    using System.Text;
    

    public partial interface IUserService
    {
        #region Methods
    
    	/// <summary>
    	/// Gets the specified entity by ID.
    	/// </summary>
    	/// <param name="id">The user ID.</param>
    	[OperationContract]
    	UserContract GetById(int id);
    
    	/// <summary>
    	/// Gets All.
    	/// </summary>
    	[OperationContract]
    	List<UserContract> GetAll();
    
    	/// <summary>
    	/// Adds the specified entity.
    	/// </summary>
    	/// <param name="user">The user entity.</param>
    	[OperationContract]
    	void Add(UserContract user);
    
    	/// <summary>
    	/// Deletes the specified entity.
    	/// </summary>
    	/// <param name="user">The user entity.</param>
    	[OperationContract]
    	void Delete(UserContract user);
    	/// <summary>
    	/// Deletes the entity by Id.
    	/// </summary>
    	/// <param name="id">The user Id.</param>
    	[OperationContract]
    	void DeleteById(int id);
    	/// <summary>
    	/// Updates the specified entity.
    	/// </summary>
    	/// <param name="user">The user entity.</param>
    	[OperationContract]
    	void Update(UserContract user);
    	/// <summary>
    	/// Queries the entity.
    	/// </summary>
    	/// <param name="criteria">Search Criteria.</param>
    	[OperationContract]
        List<UserContract> Search(Func<dynamic, bool> criteria);

        #endregion

    }
}
