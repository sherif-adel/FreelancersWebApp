using FreeLancers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelancers.BLL
{
        public partial class ProfileManager
    {
        #region Custom Operations

        public List<Profile> GetProfileByUserId(int userId, bool includeImages)
        {
            return _profileDataService.GetByUserId(userId, includeImages);
        }

        #endregion
    }
}
