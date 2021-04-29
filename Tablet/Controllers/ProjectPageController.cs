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
        private static String name;

        public ProjectPageController(ProjectPageModel projectPageModel)
        {
            this.projectPageModel = projectPageModel;
        }


        public ViewResult Index()
        {
            var items = projectPageModel.getProjectModels();
            projectPageModel.Project = items;

            var secondItems = projectPageModel.GetProjectProblemsModels();
            projectPageModel.projectProblems = secondItems;

            var thirdItems = projectPageModel.GetProjectStagesModels();
            projectPageModel.Stages = thirdItems;

            var fourthItems = projectPageModel.GetProjectGeneralProblems();
            projectPageModel.GeneralProblems = fourthItems;

            var fifthItems = projectPageModel.GetProjectGeneralWorks();
            projectPageModel.GeneralWorks = fifthItems;

            var sixthItems = projectPageModel.GetProjectRisks();
            projectPageModel.ProjectRisks = sixthItems;

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

        [HttpPost]
        public RedirectToActionResult DeleteStage(String ID)
        {
            projectPageModel.DeleteProjectStage(ID, id);
            return RedirectToAction("Index");
        }

        public ViewResult AddGeneralProblem()
        {
            return View();
        }

        [HttpPost]
        public RedirectToActionResult AddGeneralProblem(ProjectGeneralProblems projectGeneralProblems)
        {
            String problemId = Guid.NewGuid().ToString();
            projectPageModel.AddToProjectGeneralProblems(problemId, projectGeneralProblems.Description, projectGeneralProblems.Date, id);
            return RedirectToAction("Index");
        }

        public ViewResult AddGeneralWorks()
        {
            return View();
        }

        [HttpPost]
        public RedirectToActionResult AddGeneralWorks(ProjectGeneralWorks projectGeneralWorks)
        {
            String problemId = Guid.NewGuid().ToString();
            projectPageModel.AddToProjectGeneralWorks(problemId, projectGeneralWorks.Description, projectGeneralWorks.Date,
                projectGeneralWorks.RedLine,  projectGeneralWorks.Responsible, projectGeneralWorks.Persent, id);
            return RedirectToAction("Index");
        }

        public ViewResult AddRisks()
        {
            return View();
        }

        [HttpPost]
        public RedirectToActionResult AddRisks(ProjectRisks projectRisks)
        {
            String problemId = Guid.NewGuid().ToString();
            projectPageModel.AddToProjectRisks(problemId, projectRisks.Description, projectRisks.OTV,
                projectRisks.RedLine, projectRisks.Solution, id);
            return RedirectToAction("Index");
        }


        [HttpPost]
        public RedirectToActionResult Editor(Project project)
        {
            projectPageModel.EditToProject(id, project.Customer, project.Developer,
                project.Technology, project.Cost);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public RedirectToActionResult DeleteFinalProblems(String ID)
        {
            projectPageModel.DeleteGeneralProblems(ID);
            return RedirectToAction("Index");
        }
    }
}
