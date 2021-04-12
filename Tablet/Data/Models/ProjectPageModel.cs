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

        public List<Project> getProjectModels()
        {
            return appDBContent.Project.ToList();
        }

        public List<ProjectProblems> projectProblems { get; set; }

        public void AddToProjectProblems(String id, String projectId, String problem)
        {

               appDBContent.ProjectProblems.Add(new ProjectProblems
               {
                   Id = id,
                   Project = projectId,
                   Problem = problem
               });

            appDBContent.SaveChanges();
        }

        public List<ProjectProblems> GetProjectProblemsModels()
        {
             return appDBContent.ProjectProblems.ToList();
        }
    }
}
