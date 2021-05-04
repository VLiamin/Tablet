﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tablet.Data.Models;

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

            return View();
        }
    }
}
