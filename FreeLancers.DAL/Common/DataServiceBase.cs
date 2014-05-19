namespace FreeLancers.DAL
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Data.Entity.Core.Objects.DataClasses;
    using FreeLancers.Models;
    using System.Collections.Generic;
    using FreeLancers.Log;
    public abstract class DataServiceBase<T> where T : class
    {
        #region Properties

        /// <summary>
        /// Gets the data context.
        /// </summary>
        /// <value>
        /// The data context.
        /// </value>
        public FreeLancersEntities DataContext
        {
            get;
            set;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="DataServiceBase{T}" /> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public DataServiceBase(FreeLancersEntities context)
        {
            this.DataContext = context;
        }

        #endregion

        #region Abstract Methods

        /// <summary>
        /// Saves the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public abstract void Add(T entity);

        /// <summary>
        /// Deletes the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public abstract void Delete(T entity);

        /// <summary>
        /// Deletes the specified entity id.
        /// </summary>
        /// <param name="entityId">The entity id.</param>
        public abstract void Delete(int entityId);

        /// <summary>
        /// Gets the entity by id.
        /// </summary>
        /// <param name="entityId">The entity id.</param>
        /// <returns>Object of T</returns>
        public abstract T GetById(int entityId);

        /// <summary>
        /// Gets all entities.
        /// </summary>
        /// <returns>Set of All entities</returns>
        public abstract List<T> GetAll();

        /// <summary>
        /// Updates the specified entity.
        /// </summary>
        /// <param name="request">The entitiy.</param>
        public abstract void Update(T request);

        #endregion

        #region Methods

        /// <summary>
        /// Queries the entities.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <returns></returns>
        public List<T> Search(Func<T, bool> predicate)
        {
            try
            {
                return (predicate == null) ? this.DataContext.Set<T>().ToList() : this.DataContext.Set<T>().Where(predicate).ToList();
            }
            catch (Exception ex)
            {
                ExceptionHandler.LogException(ex, System.Reflection.MethodInfo.GetCurrentMethod().Name, FreeLancers.Log.ExceptionHandler.LogThreshold.ERROR);
                throw ex;
            }
        }

    }
        #endregion
}