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

        public List<Restrictions> getRestrictions()
        {
            return appDBContent.RestrictionsModel.ToList();
        }
    }
}
