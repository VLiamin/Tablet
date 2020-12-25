using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tablet.Data.interfaces;
using Tablet.Data.Models;

namespace Tablet.Controllers
{
    public class GeneralDevelopmentController : Controller
    {

        private readonly IGeneralDevelopment general;
        private readonly MainModel mainModel;

        public GeneralDevelopmentController(IGeneralDevelopment general, MainModel mainModel)
        {
            this.general = general;
            this.mainModel = mainModel;
        }

        public IActionResult Checkout()
        {
            
            return View();
        }

         [HttpPost]
        public IActionResult Checkout(GeneralDevelopment general)
        {
            mainModel.AddToTable(general.Id, general.Date, general.Forecast, general.Progress);
            return View();
        }
    }
}
