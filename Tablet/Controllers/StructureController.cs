using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tablet.Data.interfaces;
using Tablet.Data.Models;

namespace Tablet.Controllers
{
    public class StructureController : Controller
    {

        private readonly IStructure structure;
        private readonly MainModel mainModel;

        public StructureController (IStructure structure, MainModel mainModel)
        {
            this.structure = structure;
            this.mainModel = mainModel;
        }

        public IActionResult SecondCheckout()
        {

            return View();
        }

        [HttpPost]
        public IActionResult SecondCheckout(Structure structure)
        {
            mainModel.AddToTableStructure(structure.Name, structure.Proportion);
            return View();
        }
    }
}
