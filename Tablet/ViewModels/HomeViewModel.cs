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
        public static String measurement { get; set; }
        public MainModel mainModel { get; set; }
        public GeneralDevelopment general { get; set; }
        public Structure structure { get; set; }
    }
}
