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
            int id = meetingModel.Id;
            meetingPageModel.AddToMeeting(id, MeetingsPageViewModel.MeetingId,
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

            meetingPageModel.AddToMeetingAssignments(meetingAssignmentModel.Id, MeetingsPageViewModel.MeetingId,
                meetingAssignmentModel.Asignment, meetingAssignmentModel.RedLine, meetingAssignmentModel.Responsible);
            return RedirectToAction("GoToMeeting", "MeetingPage", new { Id = MeetingsPageViewModel.MeetingId });
        }

        [HttpPost]
        public RedirectToActionResult DeleteAgenda(int ID)
        {
            meetingPageModel.DeleteAgenda(ID);
            return RedirectToAction("GoToMeeting", "MeetingPage", new { Id = MeetingsPageViewModel.MeetingId });
        }

        [HttpPost]
        public RedirectToActionResult DeleteAssignment(int ID)
        {
            meetingPageModel.DeleteMeetingAssignmentModel(ID);
            return RedirectToAction("GoToMeeting", "MeetingPage", new { Id = MeetingsPageViewModel.MeetingId });
        }
    }
}
