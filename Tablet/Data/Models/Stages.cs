using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tablet.Data.Models
{
    public class Stages
    {
        public String Id { get; set; }

        [Display(Name = "Введите номер")]
        public String Number { get; set; }

        public String Project { get; set; }

        [Display(Name = "Введите этап")]
        public String Stage { get; set; }
    }
}
