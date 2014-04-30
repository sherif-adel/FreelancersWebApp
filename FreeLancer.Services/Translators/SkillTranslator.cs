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

		public static Skill ConverToSkillEntity(SkillContract skill)
		{
			Skill entitySkill = new Skill()
			{
				SkillID = skill.SkillID,
				SkillName = skill.SkillName,
				Profiles = ProfileTranslator.ConverToProfileEntity(skill.Profiles.ToList())
			};
			return entitySkill;
		}

		public static List<Skill> ConverToSkillEntity(List<SkillContract> skills)
		{
			List<Skill> newSkills = new List<Skill>();
			foreach (var skill in skills)
			{
				newSkills.Add(ConverToSkillEntity(skill));
			}
			return newSkills;
		}

		#endregion

		#region ToContract

		public static SkillContract ConverToSkillContract(Skill skill)
		{
			SkillContract skillContract = new SkillContract()
			{
				SkillID = skill.SkillID,
				SkillName = skill.SkillName,
				Profiles = ProfileTranslator.ConverToProfileContract(skill.Profiles.ToList())
			};
			return skillContract;
		}

		public static List<SkillContract> ConverToSkillContract(List<Skill> skills)
		{
			List<SkillContract> newSkills = new List<SkillContract>();
			foreach (var skill in skills)
			{
				newSkills.Add(ConverToSkillContract(skill));
			}
			return newSkills;
		}

		#endregion
	}
}