using Microsoft.AspNetCore.Mvc;
using System;
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
        public RedirectToActionResult EditFinance(String id, String value)
        {
            restrictionsPageModel.Edit(id, "Finance", value);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public RedirectToActionResult EditArchitecture(String id, String value)
        {
            restrictionsPageModel.Edit(id, "Architecture", value);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public RedirectToActionResult EditSafety(String id, String value)
        {
            restrictionsPageModel.Edit(id, "Safety", value);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public RedirectToActionResult EditData(String id, String value)
        {
            restrictionsPageModel.Edit(id, "Data", value);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public RedirectToActionResult EditRedLine(String id, String value)
        {
            restrictionsPageModel.Edit(id, "RedLine", value);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public RedirectToActionResult EditDocument(String id, String value)
        {
            restrictionsPageModel.Edit(id, "Document", value);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public RedirectToActionResult EditInfrastructure(String id, String value)
        {
            restrictionsPageModel.Edit(id, "Infrastructure", value);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public RedirectToActionResult EditLicense(String id, String value)
        {
            restrictionsPageModel.Edit(id, "License", value);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public RedirectToActionResult EditDateTime(String id, DateTime value)
        {
            restrictionsPageModel.EditDateTime(id, value);
            return RedirectToAction("Index");
        }

        public ViewResult AddTable()
        {
            return View();
        }


        public ViewResult EditTable(String id)
        {
            var items = restrictionsPageModel.getRestrictions();
            restrictionsPageModel.Restrictions = items;


            var obj = new RestrictionsPageViewModel
            {
                RestrictionsPage = this.restrictionsPageModel

            };
            RestrictionsPageViewModel.Id = id;
            return View(obj);
        }
        [HttpPost]
        public RedirectToActionResult AddTable(Restrictions restrictions)
        {
            String id = Guid.NewGuid().ToString();
            restrictionsPageModel.AddRestrictions(id, ProjectPageViewModel.projectId, restrictions.DateTime);
            return RedirectToAction("Index");
        }
    }
}
