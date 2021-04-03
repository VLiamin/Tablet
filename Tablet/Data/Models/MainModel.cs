using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Tablet.Data.Models
{
    public class MainModel : PageModel
    {
        private readonly AppDBContent appDBContent;

        public MainModel(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public List<GeneralDevelopment> generalDevelopmentModels { get; set; }
        public void AddToTable(string id, DateTime date, int forecast, int progress)
        {
            appDBContent.GeneralDevelopmentModels.Add(new GeneralDevelopment
            {
                Id = id,
                Date = date,
                Forecast = forecast,
                Progress = progress

            });
            appDBContent.SaveChanges();
        }

        public void DeleteFromTable(string id)
        {
            var generalDevelopment = appDBContent.GeneralDevelopmentModels.Find(id);

            if (generalDevelopment != null)
            {
                appDBContent.GeneralDevelopmentModels.Remove(generalDevelopment);
                appDBContent.SaveChangesAsync();
            }
        }

        public List<GeneralDevelopment> getGeneralDevelopmentModels()
        {
            return appDBContent.GeneralDevelopmentModels.ToList();
        }

        public List<Structure> Structures { get; set; }
        public void AddToTableStructure(string name, int proportion)
        {
            appDBContent.Structures.Add(new Structure
            {
                Id = Guid.NewGuid().ToString(),
                Name = name,
                Proportion = proportion

            });
            appDBContent.SaveChanges();
        }

        public List<Structure> GetStructures()
        {
            return appDBContent.Structures.ToList();
        }

    }


}
