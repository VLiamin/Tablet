using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tablet.Data.Models
{
    public class ProjectPageModel
    {
        private readonly AppDBContent appDBContent;


        public ProjectPageModel(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public List<Project> Project { get; set; }

        public void AddToProject(string id, String name, String customer, String developer, String technology, int cost)
        {
            appDBContent.Project.Add(new Project
            {
                Id = id,
                Name = name,
                Customer = customer,
                Developer = developer,
                Technology = technology,
                Cost = cost
            });

            appDBContent.SaveChanges();
        }

        public void DeleteProject(string id)
        {
            var project = appDBContent.Project.Find(id);

            try
            {
                if (project != null && appDBContent.Project.Contains(project))
                {
                    appDBContent.Project.Remove(project);
                    appDBContent.SaveChangesAsync();
                }
            }
            catch (Exception e)
            {
                ///////////
            }
        }

        public void EditToProject(String id, String customer, String developer, String technology, int cost)
        {
            var project = appDBContent.Project.Find(id);

            project.Developer = developer;
            project.Customer = customer;
            project.Technology = technology;
            project.Cost = cost;

            appDBContent.SaveChanges();
        }

        public List<Project> getProjectModels(String Id)
        {
            appDBContent.ProjectId = Id; 

            return appDBContent.Project.ToList();
        }

        public List<ProjectProblems> projectProblems { get; set; }

        public void AddToProjectProblems(int id, String projectId, String problem)
        {

               appDBContent.ProjectProblems.Add(new ProjectProblems
               {
                   Id = id,
                   ProjectId = projectId,
                   Problem = problem
               });

            appDBContent.Database.OpenConnection();
            appDBContent.Database.ExecuteSqlCommand("SET IDENTITY_INSERT ProjectProblems ON;");
            appDBContent.SaveChanges();
            appDBContent.Database.CloseConnection();
        }

        public void DeleteProjectProblems(String id, String projectId)
        {

            var problem = appDBContent.ProjectProblems.Find(id);

            try
            {
                if (problem != null && appDBContent.ProjectProblems.Contains(problem))
                {
                    appDBContent.ProjectProblems.Remove(problem);
                    appDBContent.SaveChangesAsync();
                }
            }
            catch (Exception e)
            {
                ///////////
            }
        }

        public List<ProjectProblems> GetProjectProblemsModels()
        {
             return appDBContent.ProjectProblems.ToList();
        }

        public List<Stages> Stages { get; set; }

        public void AddToProjectStage(int id, String projectId, String stage)
        {

            appDBContent.Stages.Add(new Stages
            {
                Id = id,
                ProjectId = projectId,
                Stage = stage
            });

            appDBContent.RestrictionsModel.Add(new Restrictions
            {
                Id = "jjffj",
                ProjectId = "1"

            });

            appDBContent.Database.OpenConnection();
            appDBContent.Database.ExecuteSqlCommand("SET IDENTITY_INSERT Stages ON;");
            appDBContent.SaveChanges();
            appDBContent.Database.CloseConnection();
        }

        public void DeleteProjectStage(String id, String projectId)
        {

            var stage = appDBContent.Stages.Find(id);

            try
            {
                if (stage != null && appDBContent.Stages.Contains(stage))
                {
                    appDBContent.Stages.Remove(stage);
                    appDBContent.SaveChangesAsync();
                }
            }
            catch (Exception e)
            {
                ///////////
            }
        }

        
        public List<Stages> GetProjectStagesModels()
        {
            return appDBContent.Stages.ToList();
        }


        public List<ProjectGeneralProblems> GeneralProblems { get; set; }

        public void AddToProjectGeneralProblems(String description, DateTime date, String projectId)
        {

            appDBContent.ProjectGeneralProblems.Add(new ProjectGeneralProblems
            {
                Description = description,
                Date = date,
                ProjectId = projectId
            });

            appDBContent.SaveChanges();
        }

        public void DeleteGeneralProblems(String id)
        {

            var generalProblem = appDBContent.ProjectGeneralProblems.Find(id);

            try
            {
                if (generalProblem != null && appDBContent.ProjectGeneralProblems.Contains(generalProblem))
                {
                    appDBContent.ProjectGeneralProblems.Remove(generalProblem);
                    appDBContent.SaveChangesAsync();
                }
            }
            catch (Exception e)
            {
                ///////////
            }
        }


        public List<ProjectGeneralProblems> GetProjectGeneralProblems(String Id)
        {
            appDBContent.ProjectId = Id;
            return appDBContent.ProjectGeneralProblems.ToList();
        }



        public List<ProjectGeneralWorks> GeneralWorks { get; set; }

        public void AddToProjectGeneralWorks(String description, DateTime date, DateTime redLine,
            String responsible, String persent, String projectId)
        {
            

            appDBContent.ProjectGeneralWorks.Add(new ProjectGeneralWorks
            {
                Description = description,
                Date = date,
                RedLine = redLine,
                Responsible = responsible,
                Persent = persent,
                ProjectId = projectId
            });

            appDBContent.SaveChanges();
        }

        public void DeleteGeneralWorks(String id)
        {

            var generalWorks = appDBContent.ProjectGeneralWorks.Find(id);

            try
            {
                if (generalWorks != null && appDBContent.ProjectGeneralWorks.Contains(generalWorks))
                {
                    appDBContent.ProjectGeneralWorks.Remove(generalWorks);
                    appDBContent.SaveChangesAsync();
                }
            }
            catch (Exception e)
            {
                ///////////
            }
        }


        public List<ProjectGeneralWorks> GetProjectGeneralWorks()
        {
            return appDBContent.ProjectGeneralWorks.ToList();
        }


        public List<ProjectRisks> ProjectRisks { get; set; }

        public void AddToProjectRisks(String description, String otv, DateTime redLine,
            String solution, String project)
        {

            appDBContent.ProjectRisks.Add(new ProjectRisks
            {
                Description = description,
                OTV = otv,
                RedLine = redLine,
                Solution = solution,
                ProjectId = project
            });

            appDBContent.SaveChanges();
        }

        public void DeleteProjectRisks(String id)
        {

            var risk = appDBContent.ProjectRisks.Find(id);

            try
            {
                if (risk != null && appDBContent.ProjectRisks.Contains(risk))
                {
                    appDBContent.ProjectRisks.Remove(risk);
                    appDBContent.SaveChangesAsync();
                }
            }
            catch (Exception e)
            {
                ///////////
            }
        }


        public List<ProjectRisks> GetProjectRisks()
        {
            return appDBContent.ProjectRisks.ToList();
        }
    }
}
