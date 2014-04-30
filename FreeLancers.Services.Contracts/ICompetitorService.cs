namespace FreeLancers.Service.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.ServiceModel;
    using System.Text;
    
    [ServiceContract]
    public partial interface ICompetitorService
    {
        #region Methods
    
    	/// <summary>
    	/// Gets the specified entity by ID.
    	/// </summary>
    	/// <param name="id">The competitor ID.</param>
    	[OperationContract]
    	CompetitorContract GetById(int id);
    
    	/// <summary>
    	/// Gets All.
    	/// </summary>
    	[OperationContract]
    	List<CompetitorContract> GetAll();
    
    	/// <summary>
    	/// Adds the specified entity.
    	/// </summary>
    	/// <param name="competitor">The competitor entity.</param>
    	[OperationContract]
    	void Add(CompetitorContract competitor);
    
    	/// <summary>
    	/// Deletes the specified entity.
    	/// </summary>
    	/// <param name="competitor">The competitor entity.</param>
    	[OperationContract]
    	void Delete(CompetitorContract competitor);
    	/// <summary>
    	/// Deletes the entity by Id.
    	/// </summary>
    	/// <param name="id">The competitor Id.</param>
    	[OperationContract]
    	void DeleteById(int id);
    	/// <summary>
    	/// Updates the specified entity.
    	/// </summary>
    	/// <param name="competitor">The competitor entity.</param>
    	[OperationContract]
    	void Update(CompetitorContract competitor);
    	/// <summary>
    	/// Queries the entity.
    	/// </summary>
    	/// <param name="criteria">Search Criteria.</param>
    	[OperationContract]
    	List<CompetitorContract> Search(System.Linq.Expressions.Expression<Func<CompetitorContract, bool>> criteria);

        #endregion

    }
}
