using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tablet.Data.interfaces;
using Tablet.Data.Models;
using Tablet.ViewModels;

namespace Tablet.Controllers
{
    public class ProjectController : Controller
    {

        private readonly IProject project;
        private readonly ProjectModels projectModels;

        public ProjectController(IProject project, ProjectModels projectModels)
        {
            this.project = project;
            this.projectModels = projectModels;
        }

        public IActionResult Presentation()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Presentation(Project project)
        {
            projectModels.AddToTable(project.Id, project.Name, project.Customer, project.Developer, project.Technology, project.Cost);
            return View();
        }
    }
}
