using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tablet.Data.Models
{
    public class ProjectGeneralProblems
    {

        public String Id { get; set; }

        [Display(Name = "Введите описание")]
        public String Description { get; set; }

        [Display(Name = "Введите срок")]
        public DateTime Date { get; set; }

        public String Project { get; set; }

    }
}
