using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreeLancers.Models;
using FreeLancers.Service.Contracts;

namespace FreeLancers.Service.Translators
{
    public static class ProfileTranslator
    {
        #region Profile

        public static Profile ConverToProfileEntity(ProfileContract profile)
        {
            Profile entityProfile = new Profile()
            {
                Comments = CommentTranslator.ConverToCommentEntity(profile.Comments.ToList()),
                CompanyName = profile.CompanyName,
                Description = profile.Description,
                Experience = profile.Experience,
                Featured = profile.Featured,
                Image1 = profile.Image1,
                Image2 = profile.Image2,
                Image3 = profile.Image3,
                LinkedURL = profile.LinkedURL,
                PreviousWork = profile.PreviousWork,
                ProfileID = profile.ProfileID,
                Rating = profile.Rating,
                Skills = SkillTranslator.ConverToSkillEntity(profile.Skills.ToList()),
                User = UsersTranslator.ConverToUserEntity(profile.User),
                UserID = profile.UserID,
                YouTubeURL = profile.YouTubeURL
            };
            return entityProfile;
        }

        public static List<Profile> ConverToProfileEntity(List<ProfileContract> profiles)
        {
            List<Profile> newProfiles = new List<Profile>();
            foreach (var profile in profiles)
            {
                newProfiles.Add(ConverToProfileEntity(profile));
            }
            return newProfiles;
        }

        public static ProfileContract ConverToProfileContract(Profile profile)
        {
            ProfileContract contractProfile = new ProfileContract()
            {
                Comments = CommentTranslator.ConverToCommentContract(profile.Comments.ToList()),
                CompanyName = profile.CompanyName,
                Description = profile.Description,
                Experience = profile.Experience,
                Featured = profile.Featured,
                Image1 = profile.Image1,
                Image2 = profile.Image2,
                Image3 = profile.Image3,
                LinkedURL = profile.LinkedURL,
                PreviousWork = profile.PreviousWork,
                ProfileID = profile.ProfileID,
                Rating = profile.Rating,
                Skills = SkillTranslator.ConverToSkillContract(profile.Skills.ToList()),
                User = UsersTranslator.ConverToUserContract(profile.User),
                UserID = profile.UserID,
                YouTubeURL = profile.YouTubeURL
            };
            return contractProfile;
        }

        public static List<ProfileContract> ConverToProfileContract(List<Profile> profiles)
        {
            List<ProfileContract> newProfiles = new List<ProfileContract>();
            foreach (var profile in profiles)
            {
                newProfiles.Add(ConverToProfileContract(profile));
            }
            return newProfiles;
        }

        #endregion
    }
}
