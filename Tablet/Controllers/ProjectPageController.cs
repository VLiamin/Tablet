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

            var thirdItems = projectPageModel.GetProjectStagesModels();
            projectPageModel.Stages = thirdItems;

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

        public ViewResult AddProblem()
        {
            return View();
        }

        [HttpPost]
        public RedirectToActionResult AddProblem(ProjectProblems projectProblems)
        {
            String problemId = Guid.NewGuid().ToString();
            problemId = projectProblems.Number + problemId;
            projectPageModel.AddToProjectProblems(problemId, projectProblems.Number, id, projectProblems.Problem);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public RedirectToActionResult DeleteProblem(String ID)
        {
            projectPageModel.DeleteProjectProblems(ID, id);
            return RedirectToAction("Index");
        }

        public ViewResult AddStage()
        {
            return View();
        }

        [HttpPost]
        public RedirectToActionResult AddStage(Stages stages)
        {
            String stageId = Guid.NewGuid().ToString();
            stageId = stages.Number + stageId;
            projectPageModel.AddToProjectStage(stageId, stages.Number, id, stages.Stage);
            return RedirectToAction("Index");
        }
    }
}
