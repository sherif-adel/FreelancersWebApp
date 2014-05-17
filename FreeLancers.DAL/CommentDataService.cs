
namespace FreeLancers.DAL
{

using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using FreeLancers.Models;

public partial class CommentDataService : DataServiceBase<Comment>
{
    #region Constructor
    
	/// <summary>
	/// Gets the specified entity by Id.
	/// </summary>
	/// <param name="id">The comment Id.</param>
	public CommentDataService(FreeLancersEntities dataContext):base(dataContext)
	{
		this.DataContext = dataContext;
	}

        #endregion

    

    #region Methods
    

	/// <summary>
	/// Gets the specified entity by Id.
	/// </summary>
	/// <param name="id">The comment Id.</param>
	public override Comment GetById(int id)
	{
		return DataContext.Comments.FirstOrDefault(entity => entity.CommentID == id);
	}

	/// <summary>
	/// Gets All.
	/// </summary>
	public override List<Comment> GetAll()
	{
		return DataContext.Comments.ToList();
	}

	/// <summary>
	/// Adds the specified entity.
	/// </summary>
	/// <param name="comment">The comment entity.</param>
	public override void Add(Comment comment)
	{
		DataContext.Comments.Add(comment);
		DataContext.SaveChanges();
	}

	/// <summary>
	/// Deletes the specified entity.
	/// </summary>
	/// <param name="comment">The comment entity.</param>
	public override void Delete(Comment comment)
	{

		DataContext.Comments.Remove(comment);
		DataContext.SaveChanges();
	}

	/// <summary>
	/// Deletes the entity by Id.
	/// </summary>
	/// <param name="id">The comment Id.</param>
	public override void Delete(int id)
	{
		var comment = GetById(id);
		DataContext.Comments.Remove(comment);
		DataContext.SaveChanges();
	}

	/// <summary>
	/// Updates the specified entity.
	/// </summary>
	/// <param name="comment">The comment entity.</param>
	public override void Update(Comment comment)
	{
		DataContext.Entry(comment).State = EntityState.Modified;
		DataContext.SaveChanges();
	}

        #endregion

    
}

}
