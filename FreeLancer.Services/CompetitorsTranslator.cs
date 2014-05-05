//------------------------------------------------------------------------------
//------------------------------------------------------------------------------

namespace FreeLancer.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using FreeLancers.Models;
    using FreeLancers.Service.Contracts;

    public partial class CompetitorsTranslator
    {
        #region Convert to Entities
        public static Competitor ConvertToCompetitorEntity(CompetitorContract competitor)
        {

            if (competitor == null)
                return null;
            Competitor entityCompetitor = new Competitor()
            {

                ProjectID = competitor.ProjectID,
                UserID = competitor.UserID,
                Cost = competitor.Cost,
                Duration = competitor.Duration,

                Project = ProjectsTranslator.ConvertToProjectEntity(competitor.Project),
                User = UsersTranslator.ConvertToUserEntity(competitor.User),
            };
            return entityCompetitor;
        }
        public static ICollection<Competitor> ConvertToCompetitorEntity(List<CompetitorContract> competitors)
        {
            if (competitors == null)
                return null;

            List<Competitor> newCompetitors = new List<Competitor>();
            foreach (var competitor in competitors)
            {
                newCompetitors.Add(ConvertToCompetitorEntity(competitor));
            }
            return newCompetitors;
        }

        #endregion

        #region Convert to Contracts
        public static CompetitorContract ConvertToCompetitorContract(Competitor competitor)
        {

            if (competitor == null)
                return null;

            CompetitorContract contractCompetitor = new CompetitorContract()
            {

                ProjectID = competitor.ProjectID,
                UserID = competitor.UserID,
                Cost = competitor.Cost,
                Duration = competitor.Duration,
                Project = ProjectsTranslator.ConvertToProjectContract(competitor.Project),
                User = UsersTranslator.ConvertToUserContract(competitor.User),
            };
            return contractCompetitor;
        }
        public static List<CompetitorContract> ConvertToCompetitorContract(ICollection<Competitor> competitors)
        {

            if (competitors == null)
                return null;
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
