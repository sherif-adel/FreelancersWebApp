
namespace FreeLancers.DAL
{

using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using FreeLancers.Models;

public partial class MainCategoryDataService : DataServiceBase<MainCategory>
{
    #region Constructor
    
	/// <summary>
	/// Gets the specified entity by Id.
	/// </summary>
	/// <param name="id">The maincategory Id.</param>
	public MainCategoryDataService(FreeLancersEntities dataContext):base(dataContext)
	{
		this.DataContext = dataContext;
	}

        #endregion

    

    #region Methods
    

	/// <summary>
	/// Gets the specified entity by Id.
	/// </summary>
	/// <param name="id">The maincategory Id.</param>
	public override MainCategory GetById(int id)
	{
		return DataContext.MainCategories.FirstOrDefault(entity => entity.MainCategoryID == id);
	}

	/// <summary>
	/// Gets All.
	/// </summary>
	public override List<MainCategory> GetAll()
	{
		return DataContext.MainCategories.ToList();
	}

	/// <summary>
	/// Adds the specified entity.
	/// </summary>
	/// <param name="maincategory">The maincategory entity.</param>
	public override void Add(MainCategory maincategory)
	{
		DataContext.MainCategories.Add(maincategory);
		DataContext.SaveChanges();
	}

	/// <summary>
	/// Deletes the specified entity.
	/// </summary>
	/// <param name="maincategory">The maincategory entity.</param>
	public override void Delete(MainCategory maincategory)
	{

		DataContext.MainCategories.Remove(maincategory);
		DataContext.SaveChanges();
	}

	/// <summary>
	/// Deletes the entity by Id.
	/// </summary>
	/// <param name="id">The maincategory Id.</param>
	public override void Delete(int id)
	{
		var maincategory = GetById(id);
		DataContext.MainCategories.Remove(maincategory);
		DataContext.SaveChanges();
	}

	/// <summary>
	/// Updates the specified entity.
	/// </summary>
	/// <param name="maincategory">The maincategory entity.</param>
	public override void Update(MainCategory maincategory)
	{
		DataContext.Entry(maincategory).State = EntityState.Modified;
		DataContext.SaveChanges();
	}

        #endregion

    
}

}
