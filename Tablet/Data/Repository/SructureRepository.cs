using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tablet.Data.interfaces;
using Tablet.Data.Models;

namespace Tablet.Data.Repository
{
    public class SructureRepository : IStructure
    {
        private readonly AppDBContent appDBContent;

        public void createStructure (Structure sructure)
        {
            appDBContent.Structures.Add(sructure);
            appDBContent.SaveChanges();
        }
    }
}
