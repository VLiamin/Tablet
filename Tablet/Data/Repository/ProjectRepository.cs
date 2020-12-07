using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tablet.Data.interfaces;
using Tablet.Data.Models;

namespace Tablet.Data.Repository
{
    public class ProjectRepository : IProject
    {
        private readonly AppDBContent appDBContent;

        public ProjectRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public void createProject(Project project)
        {
            appDBContent.Project.Add(project);
            appDBContent.SaveChanges();
        }
    }
}
