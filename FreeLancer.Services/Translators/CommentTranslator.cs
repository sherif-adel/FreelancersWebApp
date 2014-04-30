using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreeLancers.Models;
using FreeLancers.Service.Contracts;

namespace FreeLancers.Service.Translators
{
	public static class CommentTranslator
    {
        #region ToEntity

        public static Comment ConverToCommentEntity(CommentContract comment)
		{
			Comment entityComment = new Comment(){
				Comment1=comment.Comment1,
				CommentID=comment.CommentID,
                Date=comment.Date,
                Profile=ProfileTranslator.ConverToProfileEntity(comment.Profile),
                ProfileID=comment.ProfileID,
                User=UsersTranslator.ConverToUserEntity(comment.User),
                UserID=comment.UserID
			};
			return entityComment;
		}

		public static List<Comment> ConverToCommentEntity(List<CommentContract> comments)
		{
			List<Comment> newComments = new List<Comment>();
			foreach (var comment in comments)
			{
                newComments.Add(ConverToCommentEntity(comment));
			}
			return newComments;
		}
        #endregion
        #region ToContract
        public static CommentContract ConverToCommentContract(Comment comment)
		{
			CommentContract contractComment = new CommentContract()
			{
                Comment1 = comment.Comment1,
                CommentID = comment.CommentID,
                Date = comment.Date,
                Profile = ProfileTranslator.ConverToProfileContract(comment.Profile),
                ProfileID = comment.ProfileID,
                User = UsersTranslator.ConverToUserContract(comment.User),
                UserID = comment.UserID
			};
			return contractComment;
		}

		public static List<CommentContract> ConverToCommentContract(List<Comment> comments)
		{
			List<CommentContract> newComments = new List<CommentContract>();
			foreach (var comment in comments)
			{
				newComments.Add(ConverToCommentContract(comment));
			}
			return newComments;
		}

		#endregion
	}
}
