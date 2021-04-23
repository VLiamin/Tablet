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

        public List<Project> project { get; set; }

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

        public List<Project> getProjectModels()
        {
            return appDBContent.Project.ToList();
        }

        public List<ProjectProblems> projectProblems { get; set; }

        public void AddToProjectProblems(String id, String number, String projectId, String problem)
        {

               appDBContent.ProjectProblems.Add(new ProjectProblems
               {
                   Id = id,
                   Number = number,
                   Project = projectId,
                   Problem = problem
               });

            appDBContent.SaveChanges();
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

        public void AddToProjectStage(String id, String number, String projectId, String stage)
        {

            appDBContent.Stages.Add(new Stages
            {
                Id = id,
                Number = number,
                Project = projectId,
                Stage = stage
            });

            appDBContent.SaveChanges();
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

        public void AddToProjectGeneralProblems(String id, String description, DateTime date, String projectId)
        {

            appDBContent.ProjectGeneralProblems.Add(new ProjectGeneralProblems
            {
                Id = id,
                Description = description,
                Date = date,
                Project = projectId
            });

            appDBContent.SaveChanges();
        }

        public void DeleteGeneralProblems(String id, String projectId)
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


        public List<ProjectGeneralProblems> GetProjectGeneralProblems()
        {
            return appDBContent.ProjectGeneralProblems.ToList();
        }



        public List<ProjectGeneralWorks> GeneralWorks { get; set; }

        public void AddToProjectGeneralWorks(String id, String description, DateTime date, DateTime redLine,
            String responsible, String persent)
        {

            appDBContent.ProjectGeneralWorks.Add(new ProjectGeneralWorks
            {
                Id = id,
                Description = description,
                Date = date,
                RedLine = redLine,
                Responsible = responsible,
                Persent = persent
            });

            appDBContent.SaveChanges();
        }

        public void DeleteGeneralWorks(String id, String projectId)
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


        public List<ProjectGeneralWorks> GetProjectGeneralWorks()
        {
            return appDBContent.ProjectGeneralWorks.ToList();
        }


        public List<ProjectRisks> ProjectRisks { get; set; }

        public void AddToProjectRisks(String id, String description, DateTime date, DateTime redLine,
            String otv, String solution)
        {

            appDBContent.ProjectRisks.Add(new ProjectRisks
            {
                Id = id,
                Description = description,
                OTV = otv,
                RedLine = redLine,
                Solution = solution
            });

            appDBContent.SaveChanges();
        }

        public void DeleteProjectRisks(String id, String projectId)
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


        public List<ProjectRisks> GetProjectRisks()
        {
            return appDBContent.ProjectRisks.ToList();
        }
    }
}
