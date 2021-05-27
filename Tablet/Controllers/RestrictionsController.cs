using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tablet.Data.Models;
using Tablet.ViewModels;

namespace Tablet.Controllers
{
    public class RestrictionsController : Controller
    {
        private readonly RestrictionsPageModel restrictionsPageModel;

        public RestrictionsController(RestrictionsPageModel restrictionsPageModel)
        {
            this.restrictionsPageModel = restrictionsPageModel;
        }

        public IActionResult Index()
        {

            if ((RestrictionsPageViewModel.ProjectId == null) || (!RestrictionsPageViewModel.ProjectId.Equals(ProjectPageViewModel.projectId)))
            {
                restrictionsPageModel.AddRestrictions(Guid.NewGuid().ToString(), ProjectPageViewModel.projectId);
            }
            var items = restrictionsPageModel.getRestrictions();
            restrictionsPageModel.Restrictions = items;

            
            var obj = new RestrictionsPageViewModel
            {
                RestrictionsPage = this.restrictionsPageModel

            };

            RestrictionsPageViewModel.ProjectId = ProjectPageViewModel.projectId;

            return View(obj);
        }

        [HttpPost]
        public RedirectToActionResult EditFinance(String value)
        {
            restrictionsPageModel.Edit("Finance", value, RestrictionsPageViewModel.ProjectId);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public RedirectToActionResult EditArchitecture(String value)
        {
            restrictionsPageModel.Edit("Architecture", value, RestrictionsPageViewModel.ProjectId);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public RedirectToActionResult EditSafety(String value)
        {
            restrictionsPageModel.Edit("Safety", value, RestrictionsPageViewModel.ProjectId);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public RedirectToActionResult EditData(String value)
        {
            restrictionsPageModel.Edit("Data", value, RestrictionsPageViewModel.ProjectId);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public RedirectToActionResult EditRedLine(String value)
        {
            restrictionsPageModel.Edit("RedLine", value, RestrictionsPageViewModel.ProjectId);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public RedirectToActionResult EditDocument(String value)
        {
            restrictionsPageModel.Edit("Document", value, RestrictionsPageViewModel.ProjectId);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public RedirectToActionResult EditInfrastructure(String value)
        {
            restrictionsPageModel.Edit("Infrastructure", value, RestrictionsPageViewModel.ProjectId);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public RedirectToActionResult EditLicense(String value)
        {
            restrictionsPageModel.Edit("License", value, RestrictionsPageViewModel.ProjectId);
            return RedirectToAction("Index");
        }
    }
}
