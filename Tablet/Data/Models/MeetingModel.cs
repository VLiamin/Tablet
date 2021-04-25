using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tablet.Data.Models
{
    public class MeetingModel
    {
        public String Id { get; set; }

        public int Number { get; set; }

        public String Question { get; set; }

        public String Comment { get; set; }

        public String Suggestion { get; set; }
    }
}
