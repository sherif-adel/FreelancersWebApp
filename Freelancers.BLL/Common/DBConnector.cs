using FreeLancers.DAL.Common;
using FreeLancers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelancers.BLL.Common
{
    public class DBConnector : IDisposable
    {
        #region Fields

        private FreeLancersEntities _dataContext;

        #endregion Fields

        #region Properties

        private DBConnection dbConnection
        {
            get
            {
                if (dbConnection == null)
                    return new DBConnection();
                return dbConnection;
            }
            set
            {
                dbConnection = value;
            }
        }


        /// <summary>
        /// Gets the data context.
        /// </summary>
        /// <value>
        /// The data context.
        /// </value>
        public FreeLancersEntities DataContext
        {
            get
            {
                return this._dataContext;
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitOfWork" /> class.
        /// </summary>
        public DBConnector()
        {
            this._dataContext = dbConnection.DataContext;
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Flushes this instance.
        /// </summary>
        public void Flush()
        {
            dbConnection.Flush();

        }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        public void Dispose()
        {
            Flush();
        }

        #endregion Methods
    }
}
