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

        
        public ViewResult GetList()
        {
            
            var items = meetingPageModel.GetListOfMeetingsModel();
            meetingPageModel.ListOfMeetings = items;

            var secondItems = meetingPageModel.GetMeetingModels();
            meetingPageModel.MeetingModel = secondItems;


            var obj = new MeetingsPageViewModel
            {
                MeetingPageModel = this.meetingPageModel,
                
            };

            
            return View(obj);
        }

        [HttpPost]
        public RedirectToActionResult GoToList(String projectId)
        {
            int x = 0;
            if (projectId == null)
                x = 3 / x;
            MeetingsPageViewModel.ProjectId = projectId;
            return RedirectToAction("GetList");
        }

        public ViewResult AddMeeting()
        {
            return View();
        }

        [HttpPost]
        public ViewResult AddMeeting(ListOfMeetingsModel listOfMeetingsModel)
        {
            var Id = Guid.NewGuid().ToString();
            meetingPageModel.AddToListOfMeetings(Id, listOfMeetingsModel.Number, MeetingsPageViewModel.ProjectId);
            return View();
        }

        public ViewResult GoToMeeting(String Id)
        {
            MeetingsPageViewModel.MeetingId = Id;

            var items = meetingPageModel.GetListOfMeetingsModel();
            meetingPageModel.ListOfMeetings = items;

            var secondItems = meetingPageModel.GetMeetingModels();
            meetingPageModel.MeetingModel = secondItems;


            var obj = new MeetingsPageViewModel
            {
                MeetingPageModel = this.meetingPageModel,

            };
            return View(obj);
        }

        public ViewResult AddNewParameters()
        {
           
            return View();
        }

        [HttpPost]
        public RedirectToActionResult AddNewParameters(MeetingModel meetingModel)
        {
            String Id = Guid.NewGuid().ToString();
            Id = meetingModel.Number + Id;

            meetingPageModel.AddToMeeting(Id, MeetingsPageViewModel.MeetingId, meetingModel.Number,
                meetingModel.Question, meetingModel.Comment, meetingModel.Suggestion);
            return RedirectToAction("GoToMeeting");
        }
    }
}
