using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreeLancers.Models;
using FreeLancers.Service.Contracts;

namespace FreeLancers.Service.Translators
{
	public static class CompetitorTranslator
	{
		#region ToEntity

        public static Competitor ConverToCompetitorEntity(CompetitorContract competitor)
		{
			Competitor entityCompetitor = new Competitor(){
                Cost = competitor.Cost,
                Duration = competitor.Duration,
                Project = ProjectTranslator.ConverToProjectEntity(competitor.Project),
                ProjectID = competitor.ProjectID,
                User= UsersTranslator.ConverToUserEntity(competitor.User),
                UserID= competitor.UserID
			};
			return entityCompetitor;
		}

		public static List<Competitor> ConverToCompetitorEntity(List<CompetitorContract> competitors)
		{
			List<Competitor> newCompetitors = new List<Competitor>();
			foreach (var competitor in competitors)
			{
                newCompetitors.Add(ConverToCompetitorEntity(competitor));
			}
			return newCompetitors;
		}
        #endregion

        #region ToContract
        public static CompetitorContract ConverToCompetitorContract(Competitor competitor)
		{
			CompetitorContract contractCompetitor = new CompetitorContract()
			{
                Cost = competitor.Cost,
                Duration = competitor.Duration,
                Project = ProjectTranslator.ConverToProjectContract(competitor.Project),
                ProjectID = competitor.ProjectID,
                User = UsersTranslator.ConverToUserContract(competitor.User),
                UserID = competitor.UserID
			};
			return contractCompetitor;
		}

		public static List<CompetitorContract> ConverToCompetitorContract(List<Competitor> competitors)
		{
			List<CompetitorContract> newCompetitors = new List<CompetitorContract>();
			foreach (var competitor in competitors)
			{
				newCompetitors.Add(ConverToCompetitorContract(competitor));
			}
			return newCompetitors;
		}

		#endregion
	}
}