using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tablet.Data.Models;

namespace Tablet.ViewModels
{
    public class ProjectListViewModel
    {
        public IEnumerable<Project> getAllModels{ get; set; }
    }
}
