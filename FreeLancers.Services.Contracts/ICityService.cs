namespace FreeLancers.Service.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.ServiceModel;
    using System.Text;
    
    [ServiceContract]
    public partial interface ICityService
    {
        #region Methods
    
    	/// <summary>
    	/// Gets the specified entity by ID.
    	/// </summary>
    	/// <param name="id">The city ID.</param>
    	[OperationContract]
    	CityContract GetById(int id);
    
    	/// <summary>
    	/// Gets All.
    	/// </summary>
    	[OperationContract]
    	List<CityContract> GetAll();
    
    	/// <summary>
    	/// Adds the specified entity.
    	/// </summary>
    	/// <param name="city">The city entity.</param>
    	[OperationContract]
    	void Add(CityContract city);
    
    	/// <summary>
    	/// Deletes the specified entity.
    	/// </summary>
    	/// <param name="city">The city entity.</param>
    	[OperationContract]
    	void Delete(CityContract city);
    	/// <summary>
    	/// Deletes the entity by Id.
    	/// </summary>
    	/// <param name="id">The city Id.</param>
    	[OperationContract]
    	void DeleteById(int id);
    	/// <summary>
    	/// Updates the specified entity.
    	/// </summary>
    	/// <param name="city">The city entity.</param>
    	[OperationContract]
    	void Update(CityContract city);
    	/// <summary>
    	/// Queries the entity.
    	/// </summary>
    	/// <param name="criteria">Search Criteria.</param>
    	[OperationContract]
    	List<CityContract> Search(Func<dynamic, bool> criteria);

        #endregion

    }
}
