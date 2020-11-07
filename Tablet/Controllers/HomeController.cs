using Microsoft.AspNetCore.Mvc;
using Tablet.ViewModels;
using Tablet.Data.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tablet.Controllers
{
    public class HomeController : Controller
    {


        public ViewResult Index()
        {
            var homeProject = new HomeViewModel
            {

            };
            return View(homeProject);
        }
    }
}
