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

namespace FreeLancer.Services
{
    public class ProfileService : IProfileService
    {
        public ProfileContract GetById(int profileId)
        {
            using (var entities = new FreeLancersEntities())
            {
                ProfileManager profileManager = new ProfileManager(entities);
                var profile = profileManager.GetById(profileId);
                return ProfilesTranslator.ConvertToProfileContract(profile);
            }
        }

        public List<ProfileContract> GetAll()
        {
            using (var entities = new FreeLancersEntities())
            {
                ProfileManager profileManager = new ProfileManager(entities);
                var profiles = profileManager.GetAll();
                return ProfilesTranslator.ConvertToProfileContract(profiles).ToList();
            }
        }

        public void Add(ProfileContract profile)
        {
            using (var entities = new FreeLancersEntities())
            {
                ProfileManager profileManager = new ProfileManager(entities);
                var profileEntity = ProfilesTranslator.ConvertToProfileEntity(profile);
                profileManager.Add(profileEntity);
            }
        }

        public void Delete(ProfileContract user)
        {
            using (var entities = new FreeLancersEntities())
            {
                ProfileManager profileManager = new ProfileManager(entities);
                var profile = ProfilesTranslator.ConvertToProfileEntity(user);
                profileManager.Delete(profile);
            }
        }

        public void DeleteById(int userId)
        {
            using (var entities = new FreeLancersEntities())
            {
                ProfileManager profileManager = new ProfileManager(entities);
                profileManager.Delete(userId);
            }
        }

        public void Update(ProfileContract user)
        {
            using (var entities = new FreeLancersEntities())
            {
                ProfileManager profileManager = new ProfileManager(entities);
                var userEntity = ProfilesTranslator.ConvertToProfileEntity(user);
                profileManager.Update(userEntity);
            }
        }

        public List<ProfileContract> Search(Func<dynamic, bool> criteria)
        {
            using (FreeLancersEntities entities = new FreeLancersEntities())
            {
                ProfileManager profileManager = new ProfileManager(entities);
                Func<Profile, bool> profileCriteria = (Func<Profile, bool>)criteria;
                return ProfilesTranslator.ConvertToProfileContract(profileManager.Search(profileCriteria)).ToList();
            }
        }

        public ProfileContract GetByUserId(int userId)
        {
            using (var entities = new FreeLancersEntities())
            {
                ProfileManager profileManager = new ProfileManager(entities);
                var profile = profileManager.GetById(userId);
                return ProfilesTranslator.ConvertToProfileContract(profile);
            }
        }

    }
}
