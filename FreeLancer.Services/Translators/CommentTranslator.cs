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

        public static Comment ConvertToCommentEntity(CommentContract comment)
		{
			Comment entityComment = new Comment(){
				Comment1=comment.Comment1,
				CommentID=comment.CommentID,
                Date=comment.Date,
                Profile=ProfileTranslator.ConvertToProfileEntity(comment.Profile),
                ProfileID=comment.ProfileID,
                User=UsersTranslator.ConvertToUserEntity(comment.User),
                UserID=comment.UserID
			};
			return entityComment;
		}

		public static List<Comment> ConvertToCommentEntity(List<CommentContract> comments)
		{
			List<Comment> newComments = new List<Comment>();
			foreach (var comment in comments)
			{
                newComments.Add(ConvertToCommentEntity(comment));
			}
			return newComments;
		}
        #endregion
        #region ToContract
        public static CommentContract ConvertToCommentContract(Comment comment)
		{
			CommentContract contractComment = new CommentContract()
			{
                Comment1 = comment.Comment1,
                CommentID = comment.CommentID,
                Date = comment.Date,
                Profile = ProfileTranslator.ConvertToProfileContract(comment.Profile),
                ProfileID = comment.ProfileID,
                User = UsersTranslator.ConvertToUserContract(comment.User),
                UserID = comment.UserID
			};
			return contractComment;
		}

		public static List<CommentContract> ConvertToCommentContract(List<Comment> comments)
		{
			List<CommentContract> newComments = new List<CommentContract>();
			foreach (var comment in comments)
			{
				newComments.Add(ConvertToCommentContract(comment));
			}
			return newComments;
		}

		#endregion
	}
}
