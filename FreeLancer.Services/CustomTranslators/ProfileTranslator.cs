using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreeLancers.Models;
using FreeLancers.Service.Contracts;
using FreeLancer.Services;

namespace FreeLancers.Service
{
    public partial class ProfilesTranslator
    {
        #region Profile

        public static Profile ConvertToProfileEntity(ProfileContract profile, bool includeImages)
        {
            if (profile == null)
                return null;
            Profile entityProfile = new Profile()
            {

                ProfileID = profile.ProfileID,
                UserID = profile.UserID,
                Description = profile.Description,
                Experience = profile.Experience,
                LinkedURL = profile.LinkedURL,
                YouTubeURL = profile.YouTubeURL,
                PreviousWork = profile.PreviousWork,
                Rating = profile.Rating,
                Featured = profile.Featured,
                CompanyName = profile.CompanyName,
                SubCategoryID = profile.SubCategoryID,
                Images = profile.Images != null ? ImagesTranslator.ConvertToImageEntity(profile.Images) : null
            };
            return entityProfile;
        }

        public static List<Profile> ConvertToProfileEntity(List<ProfileContract> profiles, bool includeImages)
        {
            List<Profile> newProfiles = new List<Profile>();
            foreach (var profile in profiles)
            {
                newProfiles.Add(ConvertToProfileEntity(profile, includeImages));
            }
            return newProfiles;
        }

        public static ProfileContract ConvertToProfileContract(Profile profile, bool includeImages)
        {
            ProfileContract contractProfile = new ProfileContract()
            {
                ProfileID = profile.ProfileID,
                UserID = profile.UserID,
                Description = profile.Description,
                Experience = profile.Experience,
                LinkedURL = profile.LinkedURL,
                YouTubeURL = profile.YouTubeURL,
                PreviousWork = profile.PreviousWork,
                Rating = profile.Rating,
                Featured = profile.Featured,
                CompanyName = profile.CompanyName,
                SubCategoryID = profile.SubCategoryID,
                Images = profile.Images != null ? ImagesTranslator.ConvertToImageContract(profile.Images) : null
            };
            return contractProfile;
        }

        public static List<ProfileContract> ConvertToProfileContract(List<Profile> profiles, bool includeImages)
        {
            List<ProfileContract> newProfiles = new List<ProfileContract>();
            foreach (var profile in profiles)
            {
                newProfiles.Add(ConvertToProfileContract(profile, includeImages));
            }
            return newProfiles;
        }

        #endregion
    }
}
