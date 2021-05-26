using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace Tablet.Data.Models
{
    public class Project
    {
        [Display(Name = "Введите идентификатор")]
        [MaxLength(20)]
        public String Id { set; get; }

        [Display(Name = "Введите название")]
        [MaxLength(20)]
        public String Name { set; get; }

        [Display(Name = "Введите заказчика")]
        [MaxLength(20)]
        public String Customer { set; get; }

        [Display(Name = "Введите разработчика")]
        [MaxLength(20)]
        public String Developer { set; get; }

        [Display(Name = "Введите технологию")]
        [MaxLength(10)]
        public String Technology { get; set; }

        [Display(Name = "Введите стоимость")]
        public int Cost { get; set; }

        public List<ProjectGeneralProblems> ProjectGeneralProblems { get; set; }

        public List<ProjectGeneralWorks> ProjectGeneralWorks { get; set; }

        public List<ProjectProblems> ProjectProblems { get; set; }

        public List<ProjectRisks> ProjectRisks { get; set; }

        public List<Stages> Stages { get; set; }

    }
}
