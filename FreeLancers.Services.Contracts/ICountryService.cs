namespace FreeLancers.Service.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.ServiceModel;
    using System.Text;
    
    [ServiceContract]
    public partial interface ICountryService
    {
        #region Methods
    
    	/// <summary>
    	/// Gets the specified entity by ID.
    	/// </summary>
    	/// <param name="id">The country ID.</param>
    	[OperationContract]
    	CountryContract GetById(int id);
    
    	/// <summary>
    	/// Gets All.
    	/// </summary>
    	[OperationContract]
    	List<CountryContract> GetAll();
    
    	/// <summary>
    	/// Adds the specified entity.
    	/// </summary>
    	/// <param name="country">The country entity.</param>
    	[OperationContract]
    	void Add(CountryContract country);
    
    	/// <summary>
    	/// Deletes the specified entity.
    	/// </summary>
    	/// <param name="country">The country entity.</param>
    	[OperationContract]
    	void Delete(CountryContract country);
    	/// <summary>
    	/// Deletes the entity by Id.
    	/// </summary>
    	/// <param name="id">The country Id.</param>
    	[OperationContract]
    	void DeleteById(int id);
    	/// <summary>
    	/// Updates the specified entity.
    	/// </summary>
    	/// <param name="country">The country entity.</param>
    	[OperationContract]
    	void Update(CountryContract country);
    	/// <summary>
    	/// Queries the entity.
    	/// </summary>
    	/// <param name="criteria">Search Criteria.</param>
    	[OperationContract]
    	List<CountryContract> Search(Func<dynamic, bool> criteria);

        #endregion

    }
}
