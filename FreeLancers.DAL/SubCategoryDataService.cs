
namespace FreeLancers.DAL
{

using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using FreeLancers.Models;

public partial class SubCategoryDataService : DataServiceBase<SubCategory>
{
    #region Constructor
    
	/// <summary>
	/// Gets the specified entity by Id.
	/// </summary>
	/// <param name="id">The subcategory Id.</param>
	public SubCategoryDataService(FreeLancersEntities dataContext):base(dataContext)
	{
		this.DataContext = dataContext;
	}

        #endregion

    

    #region Methods
    

	/// <summary>
	/// Gets the specified entity by Id.
	/// </summary>
	/// <param name="id">The subcategory Id.</param>
	public override SubCategory GetById(int id)
	{
		return DataContext.SubCategories.FirstOrDefault(entity => entity.SubCategoryID == id);
	}

	/// <summary>
	/// Gets All.
	/// </summary>
	public override List<SubCategory> GetAll()
	{
		return DataContext.SubCategories.ToList();
	}

	/// <summary>
	/// Adds the specified entity.
	/// </summary>
	/// <param name="subcategory">The subcategory entity.</param>
	public override void Add(SubCategory subcategory)
	{
		DataContext.SubCategories.Add(subcategory);
		DataContext.SaveChanges();
	}

	/// <summary>
	/// Deletes the specified entity.
	/// </summary>
	/// <param name="subcategory">The subcategory entity.</param>
	public override void Delete(SubCategory subcategory)
	{

		DataContext.SubCategories.Remove(subcategory);
		DataContext.SaveChanges();
	}

	/// <summary>
	/// Deletes the entity by Id.
	/// </summary>
	/// <param name="id">The subcategory Id.</param>
	public override void Delete(int id)
	{
		var subcategory = GetById(id);
		DataContext.SubCategories.Remove(subcategory);
		DataContext.SaveChanges();
	}

	/// <summary>
	/// Updates the specified entity.
	/// </summary>
	/// <param name="subcategory">The subcategory entity.</param>
	public override void Update(SubCategory subcategory)
	{
		DataContext.Entry(subcategory).State = EntityState.Modified;
		DataContext.SaveChanges();
	}

        #endregion

    
}

}
