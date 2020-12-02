using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tablet.Data.Models;

namespace Tablet.Data.Repository
{
    public class SructureRepository
    {
        private readonly AppDBContent appDBContent;

        public void createGeneralDevelopment(Structure sructure)
        {
            appDBContent.Structures.Add(sructure);
            appDBContent.SaveChanges();
        }
    }
}
