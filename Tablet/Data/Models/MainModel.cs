using System;
using System.Collections.Generic;
using System.Linq;


namespace Tablet.Data.Models
{
    public class MainModel
    {
        private readonly AppDBContent appDBContent;

        public MainModel(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public List<GeneralDevelopment> generalDevelopmentModels { get; set; }
        public void AddToTable(DateTime date, int forecast, int progress)
        {
            appDBContent.GeneralDevelopmentModels.Add(new GeneralDevelopment
            {
                Id = Guid.NewGuid().ToString(),
                Date = date,
                Forecast = forecast,
                Progress = progress

            });
            appDBContent.SaveChanges();
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
