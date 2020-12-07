using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tablet.Data.Models;
using Tablet.ViewModels;

namespace Tablet.Controllers
{
    public class ProjectModelsController : Controller
    {
        private readonly ProjectModels projectModels;
        private readonly Project project;

        public ProjectModelsController(ProjectModels projectModels)
        {
            this.projectModels = projectModels;
        }
        public ViewResult Index()
        {
            var items = projectModels.GetProjects();
            projectModels.Projects = items;

            var obj = new ProjectListViewModel
            {
                ProjectModels = this.projectModels
            };

            return View(obj);
        }

        [HttpPost]
        public void Checkout()
        {

        }
    }
}
