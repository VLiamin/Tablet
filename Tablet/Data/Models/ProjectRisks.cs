using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Tablet.Data.Models
{
    public class ProjectRisks
    {
        public int Id { get; set; }

        [Display(Name = "Введите описание")]
        public String Description { get; set; }

        [Display(Name = "Введите срок")]
        public DateTime RedLine { get; set; }

        [Display(Name = "Введите ОТВ")]
        public String OTV { get; set; }

        [Display(Name = "Введите решение")]
        public String Solution { get; set; }

        [MaxLength(20)]
        [Index(nameof(ProjectId))]
        public String ProjectId { get; set; }

        public Project Project { get; set; }
    }
}
