namespace FreeLancers.Service.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.ServiceModel;
    using System.Text;
    
    [ServiceContract]
    public partial interface IStatusService
    {
        #region Methods
    
    	/// <summary>
    	/// Gets the specified entity by ID.
    	/// </summary>
    	/// <param name="id">The status ID.</param>
    	[OperationContract]
    	StatusContract GetById(int id);
    
    	/// <summary>
    	/// Gets All.
    	/// </summary>
    	[OperationContract]
    	List<StatusContract> GetAll();
    
    	/// <summary>
    	/// Adds the specified entity.
    	/// </summary>
    	/// <param name="status">The status entity.</param>
    	[OperationContract]
    	void Add(StatusContract status);
    
    	/// <summary>
    	/// Deletes the specified entity.
    	/// </summary>
    	/// <param name="status">The status entity.</param>
    	[OperationContract]
    	void Delete(StatusContract status);
    	/// <summary>
    	/// Deletes the entity by Id.
    	/// </summary>
    	/// <param name="id">The status Id.</param>
    	[OperationContract]
    	void DeleteById(int id);
    	/// <summary>
    	/// Updates the specified entity.
    	/// </summary>
    	/// <param name="status">The status entity.</param>
    	[OperationContract]
    	void Update(StatusContract status);
    	/// <summary>
    	/// Queries the entity.
    	/// </summary>
    	/// <param name="criteria">Search Criteria.</param>
    	[OperationContract]
    	List<StatusContract> Search(Func<dynamic, bool> criteria);

        #endregion

    }
}
