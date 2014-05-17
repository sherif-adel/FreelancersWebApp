//------------------------------------------------------------------------------
//------------------------------------------------------------------------------

namespace FreeLancer.Services
{
    using System;
    using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;using FreeLancers.Models;using FreeLancers.Service.Contracts;
    
    public partial class CommentsTranslator
    {
        #region Convert to Entities
    public static Comment ConvertToCommentEntity(CommentContract comment){
    
    if(comment == null)
    	return null;
    Comment entityComment = new Comment(){
    	
        CommentID=comment.CommentID,
        Comment1=comment.Comment1,
        UserID=comment.UserID,
        ProfileID=comment.ProfileID,
        Date=comment.Date,
         };
    return entityComment;}
    public static ICollection<Comment> ConvertToCommentEntity(List<CommentContract> comments)
    {
    		if(comments == null)
    			return null;
    
           List<Comment> newComments = new List<Comment>();
    		foreach (var comment in comments)
    		{
    			newComments.Add(ConvertToCommentEntity(comment));
    		}
    		return newComments;
    }

        #endregion

        #region Convert to Contracts
    public static CommentContract ConvertToCommentContract(Comment comment){
    
    		if(comment == null)
    			return null;
    
    		CommentContract contractComment = new CommentContract(){
    
            CommentID=comment.CommentID,Comment1=comment.Comment1,UserID=comment.UserID,ProfileID=comment.ProfileID,Date=comment.Date,};
    return contractComment;}
    public static List<CommentContract> ConvertToCommentContract(ICollection<Comment> comments){
    
    		if(comments == null)
    			return null;
           List<CommentContract> newComments = new List<CommentContract>();
    			foreach (var comment in comments)
    			{
    				newComments.Add(ConvertToCommentContract(comment));
    			}
    			return newComments;
    	}
        #endregion

    	
    
}}
