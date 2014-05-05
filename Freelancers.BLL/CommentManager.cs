namespace Freelancers.BLL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FreeLancers.Models;
    using FreeLancers.DAL;
    
    public partial class CommentManager : ManagersBase<Comment>
    {
    
        #region Properties
    
    	private CommentDataService _commentDataService;

        #endregion

        #region Constructor
        public CommentManager(FreeLancersEntities entities):base(entities)
    	{
    		_commentDataService = new CommentDataService(entities);
        }

        #endregion

        #region Methods
    
    	/// <summary>
    	/// Gets the specified entity by ID.
    	/// </summary>
    	/// <param name="id">The comment ID.</param>
    	public override Comment GetById(int id)
    	{
    		return _commentDataService.GetById(id);
    	}
    
    	/// <summary>
    	/// Gets All.
    	/// </summary>
    	public override List<Comment> GetAll()
    	{
    		return _commentDataService.GetAll();
    	}
    
    	/// <summary>
    	/// Adds the specified entity.
    	/// </summary>
    	/// <param name="comment">The comment entity.</param>
    	public override void Add(Comment comment)
    	{
    		_commentDataService.Add(comment);
    	}
    
    	/// <summary>
    	/// Deletes the specified entity.
    	/// </summary>
    	/// <param name="comment">The comment entity.</param>
    	public override void Delete(Comment comment)
    	{
    		_commentDataService.Delete(comment);
    	}
    
    	/// <summary>
    	/// Deletes the entity by Id.
    	/// </summary>
    	/// <param name="id">The comment Id.</param>
    	public override void Delete(int id)
    	{
    		_commentDataService.Delete(id);
    	}
    
    	/// <summary>
    	/// Updates the specified entity.
    	/// </summary>
    	/// <param name="comment">The comment entity.</param>
    	public override void Update(Comment comment)
    	{
    		_commentDataService.Update(comment);
    	}
    
    	/// <summary>
    	/// Queries the entity.
    	/// </summary>
    	/// <param name="criteria">Search Criteria.</param>
    	public override List<Comment> Search(Func<Comment, bool> criteria)
    	{
    		return _commentDataService.Search(criteria);
    	}

        #endregion

    }
}
