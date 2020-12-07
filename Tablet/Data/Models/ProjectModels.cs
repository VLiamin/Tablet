using System;
using System.Collections.Generic;
using System.Linq;


namespace Tablet.Data.Models
{
    public class ProjectModels
    {
        private readonly AppDBContent appDBContent;

        public ProjectModels(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public List<Project> Projects { get; set; }
        public void AddToTable(string name, string customer, string developer, string technology, int cost)
        {
            appDBContent.Project.Add(new Project
            {
                Id = Guid.NewGuid().ToString(),
                Name = name,
                Customer = customer,
                Developer = developer,
                Technology = technology,
                Cost = cost

            });
            appDBContent.SaveChanges();
        }

        public List<Project> GetProjects()
        {
            return appDBContent.Project.ToList();
        }

    }


}
