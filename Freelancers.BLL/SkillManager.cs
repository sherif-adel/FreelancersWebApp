namespace Freelancers.BLL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FreeLancers.Models;
    using FreeLancers.DAL;
    
    public partial class SkillManager : ManagersBase<Skill>
    {
    
        #region Properties
    
    	private SkillDataService _skillDataService;

        #endregion

        #region Constructor
        public SkillManager(FreeLancersEntities entities):base(entities)
    	{
    		_skillDataService = new SkillDataService(entities);
        }

        #endregion

        #region Methods
    
    	/// <summary>
    	/// Gets the specified entity by ID.
    	/// </summary>
    	/// <param name="id">The skill ID.</param>
    	public override Skill GetById(int id)
    	{
    		return _skillDataService.GetById(id);
    	}
    
    	/// <summary>
    	/// Gets All.
    	/// </summary>
    	public override List<Skill> GetAll()
    	{
    		return _skillDataService.GetAll();
    	}
    
    	/// <summary>
    	/// Adds the specified entity.
    	/// </summary>
    	/// <param name="skill">The skill entity.</param>
    	public override void Add(Skill skill)
    	{
    		_skillDataService.Add(skill);
    	}
    
    	/// <summary>
    	/// Deletes the specified entity.
    	/// </summary>
    	/// <param name="skill">The skill entity.</param>
    	public override void Delete(Skill skill)
    	{
    		_skillDataService.Delete(skill);
    	}
    
    	/// <summary>
    	/// Deletes the entity by Id.
    	/// </summary>
    	/// <param name="id">The skill Id.</param>
    	public override void Delete(int id)
    	{
    		_skillDataService.Delete(id);
    	}
    
    	/// <summary>
    	/// Updates the specified entity.
    	/// </summary>
    	/// <param name="skill">The skill entity.</param>
    	public override void Update(Skill skill)
    	{
    		_skillDataService.Update(skill);
    	}
    
    	/// <summary>
    	/// Queries the entity.
    	/// </summary>
    	/// <param name="criteria">Search Criteria.</param>
    	public override List<Skill> Search(Func<Skill, bool> criteria)
    	{
    		return _skillDataService.Search(criteria);
    	}

        #endregion

    }
}
