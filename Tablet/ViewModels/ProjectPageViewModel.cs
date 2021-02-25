using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tablet.Data.Models;

namespace Tablet.ViewModels
{
    public class ProjectPageViewModel
    {
        public ProjectPageModel projectPageModel { get; set; }
        public ProjectProblems projectProblems { get; set; }
        public Project project { get; set; }
        public static String projectId { get; set; }
    }
}
