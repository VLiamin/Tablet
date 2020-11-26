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

        public ProjectController(IProject project)
        {
            this.project = project;
        }

        [Route("Project/List")]
        public ViewResult List()
        {
            ViewBag.tittle = "Страница с проектом";
            ProjectListViewModel obj = new ProjectListViewModel();
            obj.getAllModels = project.AllProjects;
            return View(obj);
        }
    }
}
