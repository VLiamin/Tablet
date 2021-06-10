using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tablet.Data.Models
{
    public class Structure
    {

        [BindNever]
        public String Id { get; set; }

        [Display(Name = "Введите название")]
        public String Name { get; set; }

        [Display(Name = "Введите факт")]
        public int Proportion { get; set; }

        [Display(Name = "Введите план")]
        public int Plan { get; set; }
    }
}
