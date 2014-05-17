namespace Freelancers.BLL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FreeLancers.Models;
    using FreeLancers.DAL;
    
    public partial class ImageManager : ManagersBase<Image>
    {
    
        #region Properties
    
    	private ImageDataService _imageDataService;

        #endregion

        #region Constructor
        public ImageManager(FreeLancersEntities entities):base(entities)
    	{
    		_imageDataService = new ImageDataService(entities);
        }

        #endregion

        #region Methods
    
    	/// <summary>
    	/// Gets the specified entity by ID.
    	/// </summary>
    	/// <param name="id">The image ID.</param>
    	public override Image GetById(int id)
    	{
    		return _imageDataService.GetById(id);
    	}
    
    	/// <summary>
    	/// Gets All.
    	/// </summary>
    	public override List<Image> GetAll()
    	{
    		return _imageDataService.GetAll();
    	}
    
    	/// <summary>
    	/// Adds the specified entity.
    	/// </summary>
    	/// <param name="image">The image entity.</param>
    	public override void Add(Image image)
    	{
    		_imageDataService.Add(image);
    	}
    
    	/// <summary>
    	/// Deletes the specified entity.
    	/// </summary>
    	/// <param name="image">The image entity.</param>
    	public override void Delete(Image image)
    	{
    		_imageDataService.Delete(image);
    	}
    
    	/// <summary>
    	/// Deletes the entity by Id.
    	/// </summary>
    	/// <param name="id">The image Id.</param>
    	public override void Delete(int id)
    	{
    		_imageDataService.Delete(id);
    	}
    
    	/// <summary>
    	/// Updates the specified entity.
    	/// </summary>
    	/// <param name="image">The image entity.</param>
    	public override void Update(Image image)
    	{
    		_imageDataService.Update(image);
    	}
    
    	/// <summary>
    	/// Queries the entity.
    	/// </summary>
    	/// <param name="criteria">Search Criteria.</param>
    	public override List<Image> Search(Func<Image, bool> criteria)
    	{
    		return _imageDataService.Search(criteria);
    	}

        #endregion

    }
}
