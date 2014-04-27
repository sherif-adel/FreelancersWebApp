namespace FreeLancers.DAL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FreeLancers.Models;
    
    public partial class CommentDataService
    {
        #region Methods
    
    	/// <summary>
    	/// Gets the specified entity by Id.
    	/// </summary>
    	/// <param name="id">The comment Id.</param>
    	public static Comment GetById(int id)
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			return entities.Comments.FirstOrDefault(entity => entity.CommentID == id);
    		}
    	}
    
    	/// <summary>
    	/// Gets All.
    	/// </summary>
    	public static List<Comment> GetAll()
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			return entities.Comments.ToList();
    		}
    	}
    
    	/// <summary>
    	/// Adds the specified entity.
    	/// </summary>
    	/// <param name="comment">The comment entity.</param>
    	public static void Add(Comment comment)
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
            {
    			entities.Comments.Add(comment);
    			entities.SaveChanges();
            }
    	}
    
    	/// <summary>
    	/// Deletes the specified entity.
    	/// </summary>
    	/// <param name="comment">The comment entity.</param>
    	public static void Delete(Comment comment)
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			entities.Comments.Remove(comment);
    			entities.SaveChanges();
    		}
    	}
    
    	/// <summary>
    	/// Deletes the entity by Id.
    	/// </summary>
    	/// <param name="id">The comment Id.</param>
    	public static void DeleteById(int id)
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			var comment = GetById(id);
    			entities.Comments.Remove(comment);
    			entities.SaveChanges();
    		}
    	}
    
    	/// <summary>
    	/// Updates the specified entity.
    	/// </summary>
    	/// <param name="comment">The comment entity.</param>
    	public static void Update(Comment comment)
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			entities.Entry(comment).State = System.Data.EntityState.Modified;
    			entities.SaveChanges();
    		}
    	}
    
    	/// <summary>
    	/// Queries the entity.
    	/// </summary>
    	/// <param name="criteria">Search Criteria.</param>
    	public static List<Comment> Search(System.Linq.Expressions.Expression<Func<Comment, bool>> criteria)
    	{
    		using (FreeLancersEntities entities = new FreeLancersEntities())
    		{
    			return entities.Comments.Where(criteria).ToList();
    		}
    	}

        #endregion

    }
}
