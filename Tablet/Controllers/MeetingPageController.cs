using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tablet.Data.Models;

namespace Tablet.Controllers
{
    public class MeetingPageController : Controller
    {
        private readonly MeetingPageModel meetingPageModel;

        public MeetingPageController(MeetingPageModel meetingPageModel)
        {
            this.meetingPageModel = meetingPageModel;
        }

        public ViewResult GetList()
        {
            return View();
        }
    }
}
