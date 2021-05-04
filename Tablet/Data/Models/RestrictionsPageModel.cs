using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tablet.Data.Models
{
    public class RestrictionsPageModel
    {
        private readonly AppDBContent appDBContent;


        public RestrictionsPageModel(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public List<Restrictions> Restrictions { get; set; }


        public void EditToProject(String id, String customer, String developer, String technology, int cost)
        {


            var project = appDBContent.Project.Find(id);

            project.Developer = developer;
            project.Customer = customer;
            project.Technology = technology;
            project.Cost = cost;

            appDBContent.SaveChanges();
        }

        public void AddRestrictions(String id, String projectId)
        {
            foreach (var el in appDBContent.RestrictionsModel)
            {
                if (el.ProjectId.Equals(projectId))
                    return;
            }
            appDBContent.RestrictionsModel.Add(new Restrictions
            {
                Id = id,
                ProjectId = projectId
            });

            appDBContent.SaveChanges();
        }

        public List<Restrictions> getRestrictions()
        {
            return appDBContent.RestrictionsModel.ToList();
        }

        public void Edit(String name, String value, String projectId)
        {
            Restrictions item = null;
            foreach (var el in appDBContent.RestrictionsModel)
            {
                if (el.ProjectId.Equals(projectId))
                {
                    item = el;

                }


            }
        
        
            switch (name)
            {
                case "Finance":
                    item.Finance = value;
                    appDBContent.SaveChanges();
                    break;
            }
            
        }
    }
}
