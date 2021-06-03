using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tablet.Data.Models
{
    public class Restrictions
    {
        public String Id { get; set; }
        public String ProjectId { get; set; }

        [Display(Name = "Введите срок")]
        public DateTime DateTime { get; set; }
        public String RedLine { get; set; }
        public String Finance { get; set; }
        public String License { get; set; }
        public String Architecture { get; set; }
        public String Safety { get; set; }
        public String Data { get; set; }
        public String Document { get; set; }
        public String Infrastructure { get; set; }
    }
}
