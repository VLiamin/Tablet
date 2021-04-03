using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tablet.Data.Models;

namespace Tablet.ViewModels
{
    public class HomeViewModel : PageModel
    {
        public MainModel mainModel { get; set; }
        public GeneralDevelopment general { get; set; }
        public Structure structure { get; set; }


        [HttpPost]
        public async Task<IActionResult> DeleteValue(string Id)
        {
            int x = 0;

            int y = 1 / x;
            mainModel.DeleteFromTable(Id);
            
            return RedirectToPage();
        }
    }
}
