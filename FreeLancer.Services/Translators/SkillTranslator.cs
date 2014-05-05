using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FreeLancers.Models;
using FreeLancers.Service.Contracts;

namespace FreeLancers.Service.Translators
{
	public class SkillTranslator
	{
		#region ToEntity

		public static Skill ConvertToSkillEntity(SkillContract skill)
		{
			Skill entitySkill = new Skill()
			{
				SkillID = skill.SkillID,
				SkillName = skill.SkillName,
				Profiles = ProfileTranslator.ConvertToProfileEntity(skill.Profiles.ToList())
			};
			return entitySkill;
		}

		public static List<Skill> ConvertToSkillEntity(List<SkillContract> skills)
		{
			List<Skill> newSkills = new List<Skill>();
			foreach (var skill in skills)
			{
				newSkills.Add(ConvertToSkillEntity(skill));
			}
			return newSkills;
		}

		#endregion

		#region ToContract

		public static SkillContract ConvertToSkillContract(Skill skill)
		{
			SkillContract skillContract = new SkillContract()
			{
				SkillID = skill.SkillID,
				SkillName = skill.SkillName,
				Profiles = ProfileTranslator.ConvertToProfileContract(skill.Profiles.ToList())
			};
			return skillContract;
		}

		public static List<SkillContract> ConvertToSkillContract(List<Skill> skills)
		{
			List<SkillContract> newSkills = new List<SkillContract>();
			foreach (var skill in skills)
			{
				newSkills.Add(ConvertToSkillContract(skill));
			}
			return newSkills;
		}

		#endregion
	}
}