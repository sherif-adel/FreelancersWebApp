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

        public static Project ConverToProjectEntity(ProjectContract project)
        {
            Project entityProject = new Project()
            {
                AverageCost = project.AverageCost,
                Competitors = CompetitorTranslator.ConverToCompetitorEntity(project.Competitors.ToList()),
                Date = project.Date,
                Description = project.Description,
                EndDate = project.EndDate,
                Featured = project.Featured,
                Finished = project.Finished,
                FreelancerID = project.FreelancerID,
                Name = project.Name,
                ProjectID = project.ProjectID,
                StartDate = project.StartDate,
                SubCategory = SubCategoryTranslator.ConverToSubCategoryEntity(project.SubCategory),
                SubCategoryID = project.SubCategoryID,
                User = UsersTranslator.ConverToUserEntity(project.User),
                UserID = project.UserID,
                //UsersNotified = project.UsersNotified
            };
            return entityProject;
        }

        public static List<Project> ConverToProjectEntity(List<ProjectContract> projects)
        {
            List<Project> newProjects = new List<Project>();
            foreach (var project in projects)
            {
                newProjects.Add(ConverToProjectEntity(project));
            }
            return newProjects;
        }

        public static ProjectContract ConverToProjectContract(Project project)
        {
            ProjectContract contractProject = new ProjectContract()
            {
                AverageCost = project.AverageCost,
                Competitors = CompetitorTranslator.ConverToCompetitorContract(project.Competitors.ToList()),
                Date = project.Date,
                Description = project.Description,
                EndDate = project.EndDate,
                Featured = project.Featured,
                Finished = project.Finished,
                FreelancerID = project.FreelancerID,
                Name = project.Name,
                ProjectID = project.ProjectID,
                StartDate = project.StartDate,
                SubCategory = SubCategoryTranslator.ConverToSubCategoryContract(project.SubCategory),
                SubCategoryID = project.SubCategoryID,
                User = UsersTranslator.ConverToUserContract(project.User),
                UserID = project.UserID,
                //UsersNotified = project.UsersNotified
            };
            return contractProject;
        }

        public static List<ProjectContract> ConverToProjectContract(List<Project> projects)
        {
            List<ProjectContract> newProjects = new List<ProjectContract>();
            foreach (var project in projects)
            {
                newProjects.Add(ConverToProjectContract(project));
            }
            return newProjects;
        }

        #endregion
    }
}
