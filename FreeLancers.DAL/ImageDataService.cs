
namespace FreeLancers.DAL
{

using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using FreeLancers.Models;

public partial class ImageDataService : DataServiceBase<Image>
{
    #region Constructor
    
	/// <summary>
	/// Gets the specified entity by Id.
	/// </summary>
	/// <param name="id">The image Id.</param>
	public ImageDataService(FreeLancersEntities dataContext):base(dataContext)
	{
		this.DataContext = dataContext;
	}

        #endregion

    

    #region Methods
    

	/// <summary>
	/// Gets the specified entity by Id.
	/// </summary>
	/// <param name="id">The image Id.</param>
	public override Image GetById(int id)
	{
		return DataContext.Images.FirstOrDefault(entity => entity.ImageID == id);
	}

	/// <summary>
	/// Gets All.
	/// </summary>
	public override List<Image> GetAll()
	{
		return DataContext.Images.ToList();
	}

	/// <summary>
	/// Adds the specified entity.
	/// </summary>
	/// <param name="image">The image entity.</param>
	public override void Add(Image image)
	{
		DataContext.Images.Add(image);
		DataContext.SaveChanges();
	}

	/// <summary>
	/// Deletes the specified entity.
	/// </summary>
	/// <param name="image">The image entity.</param>
	public override void Delete(Image image)
	{

		DataContext.Images.Remove(image);
		DataContext.SaveChanges();
	}

	/// <summary>
	/// Deletes the entity by Id.
	/// </summary>
	/// <param name="id">The image Id.</param>
	public override void Delete(int id)
	{
		var image = GetById(id);
		DataContext.Images.Remove(image);
		DataContext.SaveChanges();
	}

	/// <summary>
	/// Updates the specified entity.
	/// </summary>
	/// <param name="image">The image entity.</param>
	public override void Update(Image image)
	{
		DataContext.Entry(image).State = EntityState.Modified;
		DataContext.SaveChanges();
	}

        #endregion

    
}

}
