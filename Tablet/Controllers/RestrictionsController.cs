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

            if (RestrictionsPageViewModel.ProjectId == null)
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
    }
}
