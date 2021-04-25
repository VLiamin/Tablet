using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tablet.Data.Models;

namespace Tablet.ViewModels
{
    public class MeetingsPageModel : PageModel
    {

        public MeetingPageModel MeetingPageModel { get; set; }
        public ListOfMeetingsModel ListOfMeetingsModel { get; set; }
        public MeetingModel MeetingModel { get; set; }
        public static String ProjectId { get; set; }
        public static String MeetingId { get; set; }
    }
}
