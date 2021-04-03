﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tablet.Data.interfaces;
using Tablet.Data.Models;

namespace Tablet.Data.Repository
{
    public class GeneralDevelopmentRepository : IGeneralDevelopment
    {
        private readonly AppDBContent appDBContent;
        public void createGeneralDevelopment (GeneralDevelopment general)
        {
            appDBContent.GeneralDevelopmentModels.Add(general);
            appDBContent.SaveChanges();
        }

        public async void deleteGeneralDevelopment(string id)
        {
            var generalDevelopment = appDBContent.GeneralDevelopmentModels.Find("3");

            if (generalDevelopment != null)
            {
                appDBContent.GeneralDevelopmentModels.Remove(generalDevelopment);
                await appDBContent.SaveChangesAsync();
            }
        }
    }
}
