using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tablet.Data.Models;

namespace Tablet.ViewModels
{
    public class RestrictionsPageViewModel
    {
        public RestrictionsPageModel RestrictionsPage { get; set; }
        public static String ProjectId { get; set; }

        public static String Id { get; set; }
    }
}
