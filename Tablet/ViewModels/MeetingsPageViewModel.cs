using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tablet.Data.Models;

namespace Tablet.ViewModels
{
    public class MeetingsPageViewModel : PageModel
    {

        public MeetingPageModel MeetingPageModel { get; set; }
        public MeetingModel ListOfMeetingsModel { get; set; }
        public Agenda MeetingModel { get; set; }
        public static String ProjectId { get; set; }
        public static String MeetingId { get; set; }
    }
}
