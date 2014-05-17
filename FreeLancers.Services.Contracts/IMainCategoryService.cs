namespace FreeLancers.Service.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.ServiceModel;
    using System.Text;
    
    [ServiceContract]
    public partial interface IMainCategoryService
    {
        #region Methods
    
    	/// <summary>
    	/// Gets the specified entity by ID.
    	/// </summary>
    	/// <param name="id">The maincategory ID.</param>
    	[OperationContract]
    	MainCategoryContract GetById(int id);
    
    	/// <summary>
    	/// Gets All.
    	/// </summary>
    	[OperationContract]
    	List<MainCategoryContract> GetAll();
    
    	/// <summary>
    	/// Adds the specified entity.
    	/// </summary>
    	/// <param name="maincategory">The maincategory entity.</param>
    	[OperationContract]
    	void Add(MainCategoryContract maincategory);
    
    	/// <summary>
    	/// Deletes the specified entity.
    	/// </summary>
    	/// <param name="maincategory">The maincategory entity.</param>
    	[OperationContract]
    	void Delete(MainCategoryContract maincategory);
    	/// <summary>
    	/// Deletes the entity by Id.
    	/// </summary>
    	/// <param name="id">The maincategory Id.</param>
    	[OperationContract]
    	void DeleteById(int id);
    	/// <summary>
    	/// Updates the specified entity.
    	/// </summary>
    	/// <param name="maincategory">The maincategory entity.</param>
    	[OperationContract]
    	void Update(MainCategoryContract maincategory);
    	/// <summary>
    	/// Queries the entity.
    	/// </summary>
    	/// <param name="criteria">Search Criteria.</param>
    	[OperationContract]
    	List<MainCategoryContract> Search(Func<dynamic, bool> criteria);

        #endregion

    }
}
