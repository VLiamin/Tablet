using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Tablet.Data.Models
{
    public class ProjectProblems
    {

        [Display(Name = "Введите номер")]
        public int Id { get; set; }

        [MaxLength(20)]
        [Index(nameof(ProjectId))]
        public String ProjectId { get; set; }

        [Display(Name = "Введите проблему")]
        public String Problem { get; set; }

        public Project Project { get; set; }
    }
}
