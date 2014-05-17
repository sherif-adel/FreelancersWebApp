using FreeLancer.Services;
using Freelancers.BLL;
using FreeLancers.Models;
using FreeLancers.Service.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace FreeLancers.UI.Freelancer
{
    public partial class MyProfile : System.Web.UI.Page
    {
        #region Properties
        private UserService _userService;
        private ProfileService _profileService;

        public UserService UserService
        {
            get
            {
                if (_userService == null)
                    _userService = new UserService();
                return _userService;
            }
        }

        public ProfileService ProfileService
        {
            get
            {
                if (_profileService == null)
                    _profileService = new ProfileService();
                return _profileService;
            }
        }

        public UserContract CurrentUser
        {
            get
            {
                if (Session["loggedUser"] != null)
                    return (UserContract)Session["loggedUser"];
                Session["loggedUser"] = UserService.GetById(5);
                return (UserContract)Session["loggedUser"];
            }
            set
            {
                Session["loggedUser"] = value;
            }
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {

            loadProfileData();

        }

        private void loadProfileData()
        {
            var currentProfile = ProfileService.GetById(CurrentUser.Profiles.FirstOrDefault().ProfileID);
            if (currentProfile != null)
            {
                txtCompanyName.Value = currentProfile.CompanyName;
                txtDescription.Value = currentProfile.Description;
                txtLinkedInUrl.Value = currentProfile.LinkedURL;
                txtYouTubeUrl.Value = currentProfile.YouTubeURL;
                txtPreviousWork.Value = currentProfile.PreviousWork;
                txtExperience.Value = currentProfile.Experience.ToString();
                experienceRange.Value = currentProfile.Experience.ToString();
                if (currentProfile.Images != null && currentProfile.Images.Count > 0)
                {
                    image1.Visible = true;
                    image1.Src = "~/Common/ImageHandler.ashx?imageID=" + currentProfile.Images[0].ImageID;
                    if (currentProfile.Images.Count > 1)
                    {
                        image2.Visible = true;
                        image2.Src = "~/Common/ImageHandler.ashx?imageID=" + currentProfile.Images[1].ImageID;
                    }

                    if (currentProfile.Images.Count > 2)
                    {
                        image3.Visible = true;
                        image3.Src = "~/Common/ImageHandler.ashx?imageID=" + currentProfile.Images[2].ImageID;
                    }
                }
            }
        }

        private ProfileContract FillProfileData()
        {
            ProfileContract newProfile = new ProfileContract()
            {
                UserID = CurrentUser.UserID,
                CompanyName = txtCompanyName.Value,
                Description = txtDescription.Value,
                LinkedURL = txtLinkedInUrl.Value,
                YouTubeURL = txtYouTubeUrl.Value,
                PreviousWork = txtPreviousWork.Value,
                Experience = (int)float.Parse(txtExperience.Value),
                SubCategoryID = 1
            };

            var image1 = loadImage(image1Upload, newProfile.ProfileID);
            var image2 = loadImage(image2Upload, newProfile.ProfileID);
            var image3 = loadImage(image3Upload, newProfile.ProfileID);

            //newProfile.Images = new List<ImageContract>();
            //newProfile.Images.Add(image1);
            //newProfile.Images.Add(image2);
           // newProfile.Images.Add(image3);

            return newProfile;
        }

        private ImageContract loadImage(HtmlInputFile imageControl, int profileID)
        {
            byte[] data;
            if (imageControl.PostedFile.InputStream.Length > 0)
            {
                using (Stream inputStream = imageControl.PostedFile.InputStream)
                {
                    MemoryStream memoryStream = inputStream as MemoryStream;
                    if (memoryStream == null)
                    {
                        memoryStream = new MemoryStream();
                        inputStream.CopyTo(memoryStream);
                    }
                    data = memoryStream.ToArray();
                }
                return new ImageContract()
                 {
                     Name = imageControl.Value,
                     FileData = data,
                     ProfileID = profileID
                 };
            }
            else
                return null;
        }

        private void SaveProfile(ProfileContract profile)
        {
            FreeLancersEntities entities = new FreeLancersEntities();
            ProfileManager profileManager = new ProfileManager(entities);
            var profileEntity = ProfilesTranslator.ConvertToProfileEntity(profile);
            profileManager.Add(profileEntity);
        }

        protected void btnEditProfile_Click(object sender, EventArgs e)
        {
            var profile = FillProfileData();
            SaveProfile(profile);
        }
    }
}