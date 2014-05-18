using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Freelancers.BLL;
using FreeLancers.Models;
using FreeLancers.Service.Contracts;
using Freelancers.BLL.Common;

namespace FreeLancer.Services
{
    public class ProfileService : IProfileService
    {
        public ProfileContract GetById(int profileId)
        {
            using (var dbConnector = new DBConnector())
            {
                ProfileManager profileManager = new ProfileManager(dbConnector.DataContext);
                var profile = profileManager.GetById(profileId);
                return ProfilesTranslator.ConvertToProfileContract(profile);
            }
        }

        public List<ProfileContract> GetAll()
        {
            using (var dbConnector = new DBConnector())
            {
                ProfileManager profileManager = new ProfileManager(dbConnector.DataContext);
                var profiles = profileManager.GetAll();
                return ProfilesTranslator.ConvertToProfileContract(profiles).ToList();
            }
        }

        public void Add(ProfileContract profile)
        {
            using (var dbConnector = new DBConnector())
            {
                ProfileManager profileManager = new ProfileManager(dbConnector.DataContext);
                var profileEntity = ProfilesTranslator.ConvertToProfileEntity(profile);
                profileManager.Add(profileEntity);
            }
        }

        public void Delete(ProfileContract user)
        {
            using (var dbConnector = new DBConnector())
            {
                ProfileManager profileManager = new ProfileManager(dbConnector.DataContext);
                var profile = ProfilesTranslator.ConvertToProfileEntity(user);
                profileManager.Delete(profile);
            }
        }

        public void DeleteById(int userId)
        {
            using (var dbConnector = new DBConnector())
            {
                ProfileManager profileManager = new ProfileManager(dbConnector.DataContext);
                profileManager.Delete(userId);
            }
        }

        public void Update(ProfileContract user)
        {
            using (var dbConnector = new DBConnector())
            {
                ProfileManager profileManager = new ProfileManager(dbConnector.DataContext);
                var userEntity = ProfilesTranslator.ConvertToProfileEntity(user);
                profileManager.Update(userEntity);
            }
        }

        public List<ProfileContract> Search(Func<dynamic, bool> criteria)
        {
            using (var dbConnector = new DBConnector())
            {
                ProfileManager profileManager = new ProfileManager(dbConnector.DataContext);
                Func<Profile, bool> profileCriteria = (Func<Profile, bool>)criteria;
                return ProfilesTranslator.ConvertToProfileContract(profileManager.Search(profileCriteria)).ToList();
            }
        }

        public ProfileContract GetByUserId(int userId)
        {
            using (var dbConnector = new DBConnector())
            {
                ProfileManager profileManager = new ProfileManager(dbConnector.DataContext);
                var profile = profileManager.GetById(userId);
                return ProfilesTranslator.ConvertToProfileContract(profile);
            }
        }

    }
}
