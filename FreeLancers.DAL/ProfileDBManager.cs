using FreeLancers.Log;
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

        public Profile GetByUserId(int userId, bool includeImages)
        {
            try
            {
                if (includeImages)
                    return DataContext.Profiles.Include("Images").Where(profile => profile.UserID == userId).FirstOrDefault();
                else
                    return DataContext.Profiles.Where(profile => profile.UserID == userId).FirstOrDefault();
            }
            catch (Exception ex)
            {
                ExceptionHandler.LogException(ex, System.Reflection.MethodInfo.GetCurrentMethod().Name, FreeLancers.Log.ExceptionHandler.LogThreshold.ERROR);
                throw ex;
            }
        }

        #endregion
    }
}
