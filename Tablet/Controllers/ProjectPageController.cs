using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tablet.Data.Models;
using Tablet.ViewModels;

namespace Tablet.Controllers
{
    public class ProjectPageController : Controller
    {
        private readonly ProjectPageModel projectPageModel;
        private static String id;

        public ProjectPageController(ProjectPageModel projectPageModel)
        {
            this.projectPageModel = projectPageModel;
        }


        public ViewResult Index()
        {
            var items = projectPageModel.getProjectModels();
            projectPageModel.project = items;

            var secondItems = projectPageModel.GetProjectProblemsModels();
            projectPageModel.projectProblems = secondItems;


            var obj = new ProjectPageViewModel
            {
                projectPageModel = this.projectPageModel,

            };
            ProjectPageViewModel.projectId = id;
            return View(obj);
        }

        public RedirectToActionResult getProjectId(string id)
        {
            ProjectPageController.id = id;
            return RedirectToAction("Index");
        }
    }
}
