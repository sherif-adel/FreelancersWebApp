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

        public static Competitor ConvertToCompetitorEntity(CompetitorContract competitor)
		{
			Competitor entityCompetitor = new Competitor(){
                Cost = competitor.Cost,
                Duration = competitor.Duration,
                Project = ProjectTranslator.ConvertToProjectEntity(competitor.Project),
                ProjectID = competitor.ProjectID,
                User= UsersTranslator.ConvertToUserEntity(competitor.User),
                UserID= competitor.UserID
			};
			return entityCompetitor;
		}

		public static List<Competitor> ConvertToCompetitorEntity(List<CompetitorContract> competitors)
		{
			List<Competitor> newCompetitors = new List<Competitor>();
			foreach (var competitor in competitors)
			{
                newCompetitors.Add(ConvertToCompetitorEntity(competitor));
			}
			return newCompetitors;
		}
        #endregion

        #region ToContract
        public static CompetitorContract ConvertToCompetitorContract(Competitor competitor)
		{
			CompetitorContract contractCompetitor = new CompetitorContract()
			{
                Cost = competitor.Cost,
                Duration = competitor.Duration,
                Project = ProjectTranslator.ConvertToProjectContract(competitor.Project),
                ProjectID = competitor.ProjectID,
                User = UsersTranslator.ConvertToUserContract(competitor.User),
                UserID = competitor.UserID
			};
			return contractCompetitor;
		}

		public static List<CompetitorContract> ConvertToCompetitorContract(List<Competitor> competitors)
		{
			List<CompetitorContract> newCompetitors = new List<CompetitorContract>();
			foreach (var competitor in competitors)
			{
				newCompetitors.Add(ConvertToCompetitorContract(competitor));
			}
			return newCompetitors;
		}

		#endregion
	}
}