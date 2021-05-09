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
        public String Id { set; get; }

        [Display(Name = "Введите название")]
        public String Name { set; get; }

        [Display(Name = "Введите заказчика")]
        public String Customer { set; get; }

        [Display(Name = "Введите разработчика")]
        public String Developer { set; get; }

        [Display(Name = "Введите технологию")]
        public String Technology { get; set; }

        [Display(Name = "Введите стоимость")]
        public int Cost { get; set; }

    }
}
