//------------------------------------------------------------------------------
//------------------------------------------------------------------------------

namespace FreeLancer.Services
{
    using System;
    using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;using FreeLancers.Models;using FreeLancers.Service.Contracts;
    
    public partial class ProjectsTranslator
    {
        #region Convert to Entities
    public static Project ConvertToProjectEntity(ProjectContract project){
    
    Project entityProject = new Project(){
    
        ProjectID=project.ProjectID,
        UserID=project.UserID,
        SubCategoryID=project.SubCategoryID,
        Description=project.Description,
        AverageCost=project.AverageCost,
        StartDate=project.StartDate,
        EndDate=project.EndDate,
        Finished=project.Finished,
        FreelancerID=project.FreelancerID,
        Date=project.Date,
        Featured=project.Featured,
        Name=project.Name,
        
            Competitors=CompetitorsTranslator.ConvertToCompetitorEntity(project.Competitors),
        SubCategory=SubCategorysTranslator.ConvertToSubCategoryEntity(project.SubCategory),
        User=UsersTranslator.ConvertToUserEntity(project.User),
        UsersNotified=UsersTranslator.ConvertToUserEntity(project.UsersNotified),
         };
    return entityProject;}
    public static ICollection<Project> ConvertToProjectEntity(List<ProjectContract> projects){
    
           List<Project> newProjects = new List<Project>();
    			foreach (var project in projects)
    			{
    				newProjects.Add(ConvertToProjectEntity(project));
    			}
    			return newProjects;
    		}

        #endregion

        #region Convert to Contracts
    public static ProjectContract ConvertToProjectContract(Project project){
    
    ProjectContract contractProject = new ProjectContract(){
    
                ProjectID=project.ProjectID,UserID=project.UserID,SubCategoryID=project.SubCategoryID,Description=project.Description,AverageCost=project.AverageCost,StartDate=project.StartDate,EndDate=project.EndDate,Finished=project.Finished,FreelancerID=project.FreelancerID,Date=project.Date,Featured=project.Featured,Name=project.Name,                Competitors=CompetitorsTranslator.ConvertToCompetitorContract(project.Competitors),                SubCategory=SubCategorysTranslator.ConvertToSubCategoryContract(project.SubCategory),                User=UsersTranslator.ConvertToUserContract(project.User),                UsersNotified=UsersTranslator.ConvertToUserContract(project.UsersNotified),};
    return contractProject;}
    public static List<ProjectContract> ConvertToProjectContract(ICollection<Project> projects){
    
           List<ProjectContract> newProjects = new List<ProjectContract>();
    			foreach (var project in projects)
    			{
    				newProjects.Add(ConvertToProjectContract(project));
    			}
    			return newProjects;
    	}
        #endregion

    	
    
}}
