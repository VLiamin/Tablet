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

            var thirdItems = meetingPageModel.GetMeetingAssignmentModel();
            meetingPageModel.MeetingAssignment = thirdItems;


            var obj = new MeetingsPageViewModel
            {
                MeetingPageModel = this.meetingPageModel,
                
            };

            
            return View(obj);
        }

        [HttpPost]
        public RedirectToActionResult GoToList(String projectId)
        {
            MeetingsPageViewModel.ProjectId = projectId;
            return RedirectToAction("GetList");
        }

        public ViewResult AddMeeting()
        {
            return View();
        }

        [HttpPost]
        public RedirectToActionResult AddMeeting(MeetingModel listOfMeetingsModel)
        {
            var Id = Guid.NewGuid().ToString();
            Id = listOfMeetingsModel.Number + Id;
            meetingPageModel.AddToListOfMeetings(Id, listOfMeetingsModel.Number, MeetingsPageViewModel.ProjectId);
            return RedirectToAction("GetList");
        }

        public ViewResult GoToMeeting(String Id)
        {
            MeetingsPageViewModel.MeetingId = Id;

            var items = meetingPageModel.GetListOfMeetingsModel();
            meetingPageModel.ListOfMeetings = items;

            var secondItems = meetingPageModel.GetMeetingModels();
            meetingPageModel.MeetingModel = secondItems;

            var thirdItems = meetingPageModel.GetMeetingAssignmentModel();
            meetingPageModel.MeetingAssignment = thirdItems;

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
        public RedirectToActionResult AddNewParameters(Agenda meetingModel)
        {
            String Id = Guid.NewGuid().ToString();
            Id = meetingModel.Number + Id;

            meetingPageModel.AddToMeeting(Id, MeetingsPageViewModel.MeetingId, meetingModel.Number,
                meetingModel.Question, meetingModel.Comment, meetingModel.Suggestion);
            return RedirectToAction("GoToMeeting", "MeetingPage", new { Id = MeetingsPageViewModel.MeetingId });
        }

        public ViewResult AddNewAssignment()
        {

            return View();
        }

        [HttpPost]
        public RedirectToActionResult AddNewAssignment(MeetingAssignmentModel meetingAssignmentModel)
        {
            String Id = Guid.NewGuid().ToString();
            Id = meetingAssignmentModel.Number + Id;

            meetingPageModel.AddToMeetingAssignments(Id, MeetingsPageViewModel.MeetingId, meetingAssignmentModel.Number,
                meetingAssignmentModel.Asignment, meetingAssignmentModel.RedLine, meetingAssignmentModel.Responsible);
            return RedirectToAction("GoToMeeting", "MeetingPage", new { Id = MeetingsPageViewModel.MeetingId });
        }

        [HttpPost]
        public RedirectToActionResult DeleteMeeting(String ID)
        {
            meetingPageModel.DeleteMeeting(ID);
            return RedirectToAction("GoToMeeting", "MeetingPage", new { Id = MeetingsPageViewModel.MeetingId });
        }

        [HttpPost]
        public RedirectToActionResult DeleteAssignment(String ID)
        {
            meetingPageModel.DeleteMeetingAssignmentModel(ID);
            return RedirectToAction("GoToMeeting", "MeetingPage", new { Id = MeetingsPageViewModel.MeetingId });
        }
    }
}
