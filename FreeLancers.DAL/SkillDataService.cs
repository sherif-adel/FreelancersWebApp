
namespace FreeLancers.DAL
{

using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using FreeLancers.Models;

public partial class SkillDataService : DataServiceBase<Skill>
{
    #region Constructor
    
	/// <summary>
	/// Gets the specified entity by Id.
	/// </summary>
	/// <param name="id">The skill Id.</param>
	public SkillDataService(FreeLancersEntities dataContext):base(dataContext)
	{
		this.DataContext = dataContext;
	}

        #endregion

    

    #region Methods
    

	/// <summary>
	/// Gets the specified entity by Id.
	/// </summary>
	/// <param name="id">The skill Id.</param>
	public override Skill GetById(int id)
	{
		return DataContext.Skills.FirstOrDefault(entity => entity.SkillID == id);
	}

	/// <summary>
	/// Gets All.
	/// </summary>
	public override List<Skill> GetAll()
	{
		return DataContext.Skills.ToList();
	}

	/// <summary>
	/// Adds the specified entity.
	/// </summary>
	/// <param name="skill">The skill entity.</param>
	public override void Add(Skill skill)
	{
		DataContext.Skills.Add(skill);
		DataContext.SaveChanges();
	}

	/// <summary>
	/// Deletes the specified entity.
	/// </summary>
	/// <param name="skill">The skill entity.</param>
	public override void Delete(Skill skill)
	{

		DataContext.Skills.Remove(skill);
		DataContext.SaveChanges();
	}

	/// <summary>
	/// Deletes the entity by Id.
	/// </summary>
	/// <param name="id">The skill Id.</param>
	public override void Delete(int id)
	{
		var skill = GetById(id);
		DataContext.Skills.Remove(skill);
		DataContext.SaveChanges();
	}

	/// <summary>
	/// Updates the specified entity.
	/// </summary>
	/// <param name="skill">The skill entity.</param>
	public override void Update(Skill skill)
	{
		DataContext.Entry(skill).State = EntityState.Modified;
		DataContext.SaveChanges();
	}

        #endregion

    
}

}
