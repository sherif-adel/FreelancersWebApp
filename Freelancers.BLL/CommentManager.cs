namespace Freelancers.BLL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FreeLancers.Models;
    using FreeLancers.DAL;
    
    public partial class CommentManager
    {
        #region Methods
    
    	/// <summary>
    	/// Gets the specified entity by ID.
    	/// </summary>
    	/// <param name="id">The comment ID.</param>
    	public static Comment GetById(int id)
    	{
    		return CommentDataService.GetById(id);
    	}
    
    	/// <summary>
    	/// Gets All.
    	/// </summary>
    	public static List<Comment> GetAll()
    	{
    		return CommentDataService.GetAll();
    	}
    
    	/// <summary>
    	/// Adds the specified entity.
    	/// </summary>
    	/// <param name="comment">The comment entity.</param>
    	public static void Add(Comment comment)
    	{
    		CommentDataService.Add(comment);
    	}
    
    	/// <summary>
    	/// Deletes the specified entity.
    	/// </summary>
    	/// <param name="comment">The comment entity.</param>
    	public static void Delete(Comment comment)
    	{
    		CommentDataService.Delete(comment);
    	}
    
    	/// <summary>
    	/// Deletes the entity by Id.
    	/// </summary>
    	/// <param name="id">The comment Id.</param>
    	public static void DeleteById(int id)
    	{
    		CommentDataService.DeleteById(id);
    	}
    
    	/// <summary>
    	/// Updates the specified entity.
    	/// </summary>
    	/// <param name="comment">The comment entity.</param>
    	public static void Update(Comment comment)
    	{
    		CommentDataService.Update(comment);
    	}
    
    	/// <summary>
    	/// Queries the entity.
    	/// </summary>
    	/// <param name="criteria">Search Criteria.</param>
    	public static List<Comment> Search(System.Linq.Expressions.Expression<Func<Comment, bool>> criteria)
    	{
    		return CommentDataService.Search(criteria);
    	}

        #endregion

    }
}
