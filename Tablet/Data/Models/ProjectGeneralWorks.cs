﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Tablet.Data.Models
{
    public class ProjectGeneralWorks
    {
        public int Id { get; set; }

        [Display(Name = "Введите описание")]
        public String Description { get; set; }

        [Display(Name = "Введите срок")]
        public DateTime Date { get; set; }

        [Display(Name = "Введите точку невозрата")]
        public DateTime RedLine { get; set; }

        [Display(Name = "Введите ответственных")]
        public String Responsible { get; set; }

        [Display(Name = "Введите %")]
        public String Persent { get; set; }

        [MaxLength(20)]
        [Index(nameof(ProjectId))]
        public String ProjectId { get; set; }

        public Project Project { get; set; }
    }
}
