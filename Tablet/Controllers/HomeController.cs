using Microsoft.AspNetCore.Mvc;
using Tablet.ViewModels;
using Tablet.Data.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tablet.Data.Models;

namespace Tablet.Controllers
{
    public class HomeController : Controller
    {

        private readonly MainModel mainModel;
        private readonly GeneralDevelopment generalDevelopment;

        public HomeController(MainModel mainModel)
        {
            this.mainModel = mainModel;
        }
        public ViewResult Index()
        {
            var items = mainModel.getGeneralDevelopmentModels();
            mainModel.generalDevelopmentModels = items;
            var obj = new HomeViewModel
            {
                mainModal = this.mainModel
            };

            return View(obj);
        }

        [HttpPost]
        public void Checkout()
        {

        }
    }
}
