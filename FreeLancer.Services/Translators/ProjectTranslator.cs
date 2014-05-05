using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreeLancers.Models;
using FreeLancers.Service.Contracts;

namespace FreeLancers.Service.Translators
{
    public static class ProjectTranslator
    {
        #region Project

        public static Project ConvertToProjectEntity(ProjectContract project)
        {
            Project entityProject = new Project()
            {
                AverageCost = project.AverageCost,
                Competitors = CompetitorTranslator.ConvertToCompetitorEntity(project.Competitors.ToList()),
                Date = project.Date,
                Description = project.Description,
                EndDate = project.EndDate,
                Featured = project.Featured,
                Finished = project.Finished,
                FreelancerID = project.FreelancerID,
                Name = project.Name,
                ProjectID = project.ProjectID,
                StartDate = project.StartDate,
                SubCategory = SubCategoryTranslator.ConvertToSubCategoryEntity(project.SubCategory),
                SubCategoryID = project.SubCategoryID,
                User = UsersTranslator.ConvertToUserEntity(project.User),
                UserID = project.UserID,
                //UsersNotified = project.UsersNotified
            };
            return entityProject;
        }

        public static List<Project> ConvertToProjectEntity(List<ProjectContract> projects)
        {
            List<Project> newProjects = new List<Project>();
            foreach (var project in projects)
            {
                newProjects.Add(ConvertToProjectEntity(project));
            }
            return newProjects;
        }

        public static ProjectContract ConvertToProjectContract(Project project)
        {
            ProjectContract contractProject = new ProjectContract()
            {
                AverageCost = project.AverageCost,
                Competitors = CompetitorTranslator.ConvertToCompetitorContract(project.Competitors.ToList()),
                Date = project.Date,
                Description = project.Description,
                EndDate = project.EndDate,
                Featured = project.Featured,
                Finished = project.Finished,
                FreelancerID = project.FreelancerID,
                Name = project.Name,
                ProjectID = project.ProjectID,
                StartDate = project.StartDate,
                SubCategory = SubCategoryTranslator.ConvertToSubCategoryContract(project.SubCategory),
                SubCategoryID = project.SubCategoryID,
                User = UsersTranslator.ConvertToUserContract(project.User),
                UserID = project.UserID,
                //UsersNotified = project.UsersNotified
            };
            return contractProject;
        }

        public static List<ProjectContract> ConvertToProjectContract(List<Project> projects)
        {
            List<ProjectContract> newProjects = new List<ProjectContract>();
            foreach (var project in projects)
            {
                newProjects.Add(ConvertToProjectContract(project));
            }
            return newProjects;
        }

        #endregion
    }
}
