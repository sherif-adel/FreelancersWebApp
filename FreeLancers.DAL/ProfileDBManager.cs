using FreeLancers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeLancers.DAL
{
    public partial class ProfileDataService
    {
        #region Custom Operations

        public List<Profile> GetByUserId(int userId, bool includeImages)
        {
            if (includeImages)
                return DataContext.Profiles.Include("Images").Where(profile => profile.UserID == userId).ToList();
            else
                return DataContext.Profiles.Where(profile => profile.UserID == userId).ToList();
        }

        #endregion
    }
}
