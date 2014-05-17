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
    
    if(profile == null)
    	return null;
    Profile entityProfile = new Profile(){
    	
        ProfileID=profile.ProfileID,
        UserID=profile.UserID,
        Description=profile.Description,
        Experience=profile.Experience,
        LinkedURL=profile.LinkedURL,
        YouTubeURL=profile.YouTubeURL,
        PreviousWork=profile.PreviousWork,
        Rating=profile.Rating,
        Featured=profile.Featured,
        CompanyName=profile.CompanyName,
        SubCategoryID=profile.SubCategoryID,
        ExpiryDate=profile.ExpiryDate,
        ViewersCount=profile.ViewersCount,
         };
    return entityProfile;}
    public static ICollection<Profile> ConvertToProfileEntity(List<ProfileContract> profiles)
    {
    		if(profiles == null)
    			return null;
    
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
    
    		if(profile == null)
    			return null;
    
    		ProfileContract contractProfile = new ProfileContract(){
    
            ProfileID=profile.ProfileID,UserID=profile.UserID,Description=profile.Description,Experience=profile.Experience,LinkedURL=profile.LinkedURL,YouTubeURL=profile.YouTubeURL,PreviousWork=profile.PreviousWork,Rating=profile.Rating,Featured=profile.Featured,CompanyName=profile.CompanyName,SubCategoryID=profile.SubCategoryID,ExpiryDate=profile.ExpiryDate,ViewersCount=profile.ViewersCount,};
    return contractProfile;}
    public static List<ProfileContract> ConvertToProfileContract(ICollection<Profile> profiles){
    
    		if(profiles == null)
    			return null;
           List<ProfileContract> newProfiles = new List<ProfileContract>();
    			foreach (var profile in profiles)
    			{
    				newProfiles.Add(ConvertToProfileContract(profile));
    			}
    			return newProfiles;
    	}
        #endregion

    	
    
}}
