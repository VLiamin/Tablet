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

            var thirdItem = mainModel.GetInformation();
            InformationModel[] array = thirdItem.ToArray();
            if (array.Length != 0 && array[0].Id.Equals("1"))
            {
                HomeViewModel.measurement = array[0].Information;
            }

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
            mainModel.AddToTableInformation(measurement);
            return RedirectToAction("Index");
        }

    }
}
