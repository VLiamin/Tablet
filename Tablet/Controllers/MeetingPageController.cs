using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tablet.Data.Models;
using Tablet.ViewModels;

namespace Tablet.Controllers
{
    public class MeetingPageController : Controller
    {
        private readonly MeetingPageModel meetingPageModel;

        public MeetingPageController(MeetingPageModel meetingPageModel)
        {
            this.meetingPageModel = meetingPageModel;
        }

        [HttpPost]
        public ViewResult GetList(String projectId)
        {
            MeetingsPageModel.ProjectId = projectId;

            var items = meetingPageModel.GetListOfMeetingsModel();
            meetingPageModel.ListOfMeetings = items;

            var secondItems = meetingPageModel.GetMeetingModels();
            meetingPageModel.MeetingModel = secondItems;


            var obj = new MeetingsPageModel
            {
                MeetingPageModel = this.meetingPageModel,
                
            };

            
            return View(obj);
        }

        public ViewResult AddMeeting()
        {
            return View();
        }

        [HttpPost]
        public ViewResult AddMeeting(ListOfMeetingsModel listOfMeetingsModel)
        {
            var Id = Guid.NewGuid().ToString();
            meetingPageModel.AddToListOfMeetings(Id, listOfMeetingsModel.Number, MeetingsPageModel.ProjectId);
            return View();
        }
    }
}
