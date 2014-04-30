
//------------------------------------------------------------------------------
//------------------------------------------------------------------------------


namespace FreeLancer.Services
{

using System;
    using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;using FreeLancers.Models;using FreeLancers.Service.Contracts;
    
public partial class ProfilesTranslator
{

    #region Convert to Entities
    
public static Profile ConvertToProfileEntity(ProfileContract profile){

Profile entityProfile = new Profile(){

    ProfileID=profile.ProfileID,
    UserID=profile.UserID,
    Image1=profile.Image1,
    Image2=profile.Image2,
    Image3=profile.Image3,
    Description=profile.Description,
    Experience=profile.Experience,
    LinkedURL=profile.LinkedURL,
    YouTubeURL=profile.YouTubeURL,
    PreviousWork=profile.PreviousWork,
    Rating=profile.Rating,
    Featured=profile.Featured,
    CompanyName=profile.CompanyName,
    


        Comments=CommentsTranslator.ConvertToCommentEntity(profile.Comments),
    User=UsersTranslator.ConvertToUserEntity(profile.User),
    Skills=SkillsTranslator.ConvertToSkillEntity(profile.Skills),
    
 };
return entityProfile;}

public static ICollection<Profile> ConvertToProfileEntity(ICollection<ProfileContract> profiles){

       List<Profile> newProfiles = new List<Profile>();
    			foreach (var profile in profiles)
    			{
    				newProfiles.Add(ConvertToProfileEntity(profile));
    			}
    			return newProfiles;
    		}

        #endregion

    
    #region Convert to Contracts
    
public static ProfileContract ConvertToProfileContract(Profile profile){

ProfileContract contractProfile = new ProfileContract(){

            ProfileID=profile.ProfileID,UserID=profile.UserID,Image1=profile.Image1,Image2=profile.Image2,Image3=profile.Image3,Description=profile.Description,Experience=profile.Experience,LinkedURL=profile.LinkedURL,YouTubeURL=profile.YouTubeURL,PreviousWork=profile.PreviousWork,Rating=profile.Rating,Featured=profile.Featured,CompanyName=profile.CompanyName,
                Comments=CommentsTranslator.ConvertToCommentContract(profile.Comments),
                User=UsersTranslator.ConvertToUserContract(profile.User),
                Skills=SkillsTranslator.ConvertToSkillContract(profile.Skills),};
return contractProfile;}

public static ICollection<ProfileContract> ConvertToProfileContract(ICollection<Profile> profiles){

       List<ProfileContract> newProfiles = new List<ProfileContract>();
    			foreach (var profile in profiles)
    			{
    				newProfiles.Add(ConvertToProfileContract(profile));
    			}
    			return newProfiles;
    	}
        #endregion

    	


}}
