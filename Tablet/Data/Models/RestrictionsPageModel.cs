﻿using System;
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

        public void AddRestrictions(String id, String projectId, DateTime date)
        {
            appDBContent.RestrictionsModel.Add(new Restrictions
            {
                Id = id,
                ProjectId = projectId,
                DateTime = date
            
            });

            appDBContent.SaveChanges();
        }

        public List<Restrictions> getRestrictions()
        {
            return appDBContent.RestrictionsModel.ToList();
        }

        public void Edit(String id, String name, String value)
        {

            Restrictions item = null;
            foreach (var el in appDBContent.RestrictionsModel)
            {
                  if (el.Id.Equals(id))
                  {
                      item = el;
                      break;
                  }
            }
        
        
            switch (name)
            {
                case "Finance":
                    item.Finance = value;                    
                    break;
                case "RedLine":
                    item.RedLine = value;
                    break;
                case "License":
                    item.License = value;
                    break;
                case "Architecture":
                    item.Architecture = value;
                    break;
                case "Safety":
                    item.Safety = value;
                    break;
                case "Data":
                    item.Data = value;
                    break;
                case "Document":
                    item.Document = value;
                    break;
                case "Infrastructure":
                    item.Infrastructure = value;
                    break;
            }
            appDBContent.SaveChanges();

        }

        internal void EditDateTime(string id, DateTime value)
        {
            Restrictions item = null;
            foreach (var el in appDBContent.RestrictionsModel)
            {
                if (el.Id.Equals(id))
                {
                    item = el;
                    break;
                }
            }

            item.DateTime = value;
            appDBContent.SaveChanges();
        }
    }
}
