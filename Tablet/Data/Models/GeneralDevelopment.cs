using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tablet.Data.Models
{
    public class GeneralDevelopment
    {
        [BindNever]
        public String Id { get; set; }

        [Display(Name = "Введите дату")]
        public String Date { get; set; }

        [Display(Name = "Введите план")]
        public int Forecast { get; set; }

        [Display(Name = "Введите прогресс")]
        public int Progress { get; set; }
    }
}
