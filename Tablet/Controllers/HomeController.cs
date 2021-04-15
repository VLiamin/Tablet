using Microsoft.AspNetCore.Mvc;
using Tablet.ViewModels;
using Tablet.Data.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tablet.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Tablet.Controllers
{
    public class HomeController : Controller
    {

        private readonly MainModel mainModel;

        public HomeController(MainModel mainModel)
        {
            this.mainModel = mainModel;
        }

        [Authorize]
        public ViewResult Index()
        {
            if (HomeViewModel.measurement == null)
                HomeViewModel.measurement = "Трудозатраты";
            var items = mainModel.getGeneralDevelopmentModels();
            mainModel.generalDevelopmentModels = items;
            var secondItems = mainModel.GetStructures();
            mainModel.Structures = secondItems;
            var obj = new HomeViewModel
            {
                mainModel = this.mainModel
            };

            return View(obj);
        }

        [HttpPost]
        public RedirectToActionResult ChangeMeasurement(String measurement)
        {
            HomeViewModel.measurement = measurement;
            return RedirectToAction("Index");
        }

    }
}
