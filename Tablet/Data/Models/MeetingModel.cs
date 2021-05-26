using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tablet.Data.Models
{
    public class MeetingModel
    {
        public String Id { get; set; }

        [Display(Name = "Введите номер")]
        public int Number { get; set; }

        public String ProjectId { get; set; }
    }
}
