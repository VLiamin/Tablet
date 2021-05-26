using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tablet.Data.Models
{
    public class MeetingAssignmentModel
    {
        [Display(Name = "Введите номер")]
        public int Id { get; set; }

        [Display(Name = "Введите поручение")]
        public String Asignment { get; set; }

        [Display(Name = "Введите срок")]
        public DateTime RedLine { get; set; }

        [Display(Name = "Введите ответственных")]
        public String Responsible { get; set; }

        public String MeetingId { get; set; }
    }
}
