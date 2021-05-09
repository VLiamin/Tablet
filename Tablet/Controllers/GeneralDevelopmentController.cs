﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tablet.Data.interfaces;
using Tablet.Data.Models;
using Microsoft.AspNetCore.Authorization;

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

        [Authorize(Roles = "admin")]
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

        [HttpPost]
        public RedirectToActionResult DeleteValue(String Id)
        {
            mainModel.DeleteFromProgressTable(Id);
            return RedirectToAction("Index", "Home");
        }
    }
}
