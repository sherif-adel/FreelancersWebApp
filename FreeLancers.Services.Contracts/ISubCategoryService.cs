namespace FreeLancers.Service.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.ServiceModel;
    using System.Text;
    
    [ServiceContract]
    public partial interface ISubCategoryService
    {
        #region Methods
    
    	/// <summary>
    	/// Gets the specified entity by ID.
    	/// </summary>
    	/// <param name="id">The subcategory ID.</param>
    	[OperationContract]
    	SubCategoryContract GetById(int id);
    
    	/// <summary>
    	/// Gets All.
    	/// </summary>
    	[OperationContract]
    	List<SubCategoryContract> GetAll();
    
    	/// <summary>
    	/// Adds the specified entity.
    	/// </summary>
    	/// <param name="subcategory">The subcategory entity.</param>
    	[OperationContract]
    	void Add(SubCategoryContract subcategory);
    
    	/// <summary>
    	/// Deletes the specified entity.
    	/// </summary>
    	/// <param name="subcategory">The subcategory entity.</param>
    	[OperationContract]
    	void Delete(SubCategoryContract subcategory);
    	/// <summary>
    	/// Deletes the entity by Id.
    	/// </summary>
    	/// <param name="id">The subcategory Id.</param>
    	[OperationContract]
    	void DeleteById(int id);
    	/// <summary>
    	/// Updates the specified entity.
    	/// </summary>
    	/// <param name="subcategory">The subcategory entity.</param>
    	[OperationContract]
    	void Update(SubCategoryContract subcategory);
    	/// <summary>
    	/// Queries the entity.
    	/// </summary>
    	/// <param name="criteria">Search Criteria.</param>
    	[OperationContract]
    	List<SubCategoryContract> Search(System.Linq.Expressions.Expression<Func<SubCategoryContract, bool>> criteria);

        #endregion

    }
}
