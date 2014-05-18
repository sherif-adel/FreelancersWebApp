using FreeLancers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeLancers.DAL.Common
{
    public class DBConnection : IDisposable
    {
        #region Fields

        private FreeLancersEntities _dataContext;

        #endregion Fields


        #region Properties

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
        public DBConnection()
        {
            this._dataContext = new FreeLancersEntities();

        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Flushes this instance.
        /// </summary>
        public void Flush()
        {
            //_dataContext.SaveChanges();
            _dataContext.Dispose();

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
