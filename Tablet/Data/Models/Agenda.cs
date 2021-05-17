using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Tablet.Data.Models
{
    public class Agenda
    {
        [Display(Name = "Введите номер")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Display(Name = "Введите вопрос")]
        public String Question { get; set; }

        [Display(Name = "Введите комментарий")]
        public String Comment { get; set; }

        [Display(Name = "Введите предложение")]
        public String Suggestion { get; set; }

        public String MeetingId { get; set; }
    }
}
