
//------------------------------------------------------------------------------
//------------------------------------------------------------------------------


namespace FreeLancer.Services
{

using System;
    using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;using FreeLancers.Models;using FreeLancers.Service.Contracts;
    
public partial class UsersTranslator
{

    #region Convert to Entities
    
public static User ConvertToUserEntity(UserContract user){

User entityUser = new User(){

    UserID=user.UserID,
    FirstName=user.FirstName,
    LastName=user.LastName,
    Email=user.Email,
    Password=user.Password,
    Mobile=user.Mobile,
    RoleID=user.RoleID,
    


        Comments=CommentsTranslator.ConvertToCommentEntity(user.Comments),
    Competitors=CompetitorsTranslator.ConvertToCompetitorEntity(user.Competitors),
    Profiles=ProfilesTranslator.ConvertToProfileEntity(user.Profiles),
    Projects=ProjectsTranslator.ConvertToProjectEntity(user.Projects),
    Requests=RequestsTranslator.ConvertToRequestEntity(user.Requests),
    Role=RolesTranslator.ConvertToRoleEntity(user.Role),
    SubCategories=SubCategorysTranslator.ConvertToSubCategoryEntity(user.SubCategories),
    ProjectsNotifications=ProjectsTranslator.ConvertToProjectEntity(user.ProjectsNotifications),
    
 };
return entityUser;}

public static ICollection<User> ConvertToUserEntity(ICollection<UserContract> users){

       List<User> newUsers = new List<User>();
    			foreach (var user in users)
    			{
    				newUsers.Add(ConvertToUserEntity(user));
    			}
    			return newUsers;
    		}

        #endregion

    
    #region Convert to Contracts
    
public static UserContract ConvertToUserContract(User user){

UserContract contractUser = new UserContract(){

            UserID=user.UserID,FirstName=user.FirstName,LastName=user.LastName,Email=user.Email,Password=user.Password,Mobile=user.Mobile,RoleID=user.RoleID,
                Comments=CommentsTranslator.ConvertToCommentContract(user.Comments),
                Competitors=CompetitorsTranslator.ConvertToCompetitorContract(user.Competitors),
                Profiles=ProfilesTranslator.ConvertToProfileContract(user.Profiles),
                Projects=ProjectsTranslator.ConvertToProjectContract(user.Projects),
                Requests=RequestsTranslator.ConvertToRequestContract(user.Requests),
                Role=RolesTranslator.ConvertToRoleContract(user.Role),
                SubCategories=SubCategorysTranslator.ConvertToSubCategoryContract(user.SubCategories),
                ProjectsNotifications=ProjectsTranslator.ConvertToProjectContract(user.ProjectsNotifications),};
return contractUser;}

public static ICollection<UserContract> ConvertToUserContract(ICollection<User> users){

       List<UserContract> newUsers = new List<UserContract>();
    			foreach (var user in users)
    			{
    				newUsers.Add(ConvertToUserContract(user));
    			}
    			return newUsers;
    	}
        #endregion

    	


}}
