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
            var items = restrictionsPageModel.getRestrictions();
            restrictionsPageModel.Restrictions = items;

            var obj = new RestrictionsPageViewModel
            {
                RestrictionsPage = this.restrictionsPageModel

            };
            return View(obj);
        }
    }
}
