using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tablet.Data.Models
{
    public class ProjectProblems
    {

        public String Id { get; set; }

        [Display(Name = "Введите номер")]
        public String Number { get; set; }

        public String Project { get; set; }

        [Display(Name = "Введите проблему")]
        public String Problem { get; set; }
    }
}
