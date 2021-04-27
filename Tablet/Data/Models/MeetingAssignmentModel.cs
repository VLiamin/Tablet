using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tablet.Data.Models
{
    public class MeetingAssignmentModel
    {
        public String Id { get; set; }

        public int Number { get; set; }

        public String Asignment { get; set; }

        public DateTime RedLine { get; set; }

        public String Responsible { get; set; }

        public String MeetingId { get; set; }
    }
}
