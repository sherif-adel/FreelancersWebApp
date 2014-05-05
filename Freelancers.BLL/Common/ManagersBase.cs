namespace Freelancers.BLL
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Data.Entity.Core.Objects.DataClasses;
    using FreeLancers.Models;
    using System.Collections.Generic;
    using FreeLancers.DAL;
    public abstract class ManagersBase<T> where T : class
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
        public ManagersBase(FreeLancersEntities context)
        {
            this.DataContext = context;
            //Can Set DataServiceBase using Factory
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
        /// <param name="user">The entity.</param>
        public abstract void Update(T user);

        /// <summary>
        /// Queries the entity.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <returns></returns>
        public abstract List<T> Search(Func<T, bool> predicate);

    }
        #endregion
}