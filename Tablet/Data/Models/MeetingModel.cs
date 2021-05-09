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

        [Display(Name = "Введите вопрос")]
        public String Question { get; set; }

        [Display(Name = "Введите комментарий")]
        public String Comment { get; set; }

        [Display(Name = "Введите предложение")]
        public String Suggestion { get; set; }

        public String MeetingId { get; set; }
    }
}
