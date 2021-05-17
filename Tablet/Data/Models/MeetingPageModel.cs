using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tablet.Data.Models
{
    public class MeetingPageModel
    {
        private readonly AppDBContent appDBContent;

        public MeetingPageModel(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public List<Agenda> MeetingModel { get; set; }

        public void AddToMeeting(int id, String meetingId, 
            String question, String comment, String suggestion)
        {

            appDBContent.Agenda.Add(new Agenda
            {
                Id = id,
                MeetingId = meetingId,
                Question = question,
                Comment = comment,
                Suggestion = suggestion
            });
            appDBContent.Database.OpenConnection();
            appDBContent.Database.ExecuteSqlCommand("SET IDENTITY_INSERT Agenda ON;");
            appDBContent.SaveChanges();
            appDBContent.Database.CloseConnection();
        }

        public void DeleteMeeting(String id)
        {

            var meeting = appDBContent.Agenda.Find(id);

            try
            {
                if (meeting != null && appDBContent.Agenda.Contains(meeting))
                {
                    appDBContent.Agenda.Remove(meeting);
                    appDBContent.SaveChangesAsync();
                }
            }
            catch (Exception e)
            {
                ///////////
            }
        }

        public List<Agenda> GetMeetingModels()
        {
            return appDBContent.Agenda.ToList();
        }


        public List<MeetingModel> ListOfMeetings { get; set; }

        public void AddToListOfMeetings(String id, int number, String projectId)
        {

            appDBContent.MeetingModel.Add(new MeetingModel
            {
                Id = id,
                Number = number,
                ProjectId = projectId
            });

            appDBContent.SaveChanges();
        }

        public void DeleteListOfMeetings(String id, String projectId)
        {

            var problem = appDBContent.ProjectProblems.Find(id);

            try
            {
                if (problem != null && appDBContent.ProjectProblems.Contains(problem))
                {
                    appDBContent.ProjectProblems.Remove(problem);
                    appDBContent.SaveChangesAsync();
                }
            }
            catch (Exception e)
            {
                ///////////
            }
        }

        public List<MeetingModel> GetListOfMeetingsModel()
        {
            return appDBContent.MeetingModel.ToList();
        }

        public List<MeetingAssignmentModel> MeetingAssignment { get; set; }

        public void AddToMeetingAssignments(int id, String meetingId, String asignment, 
            DateTime redLine, String responsible)
        {

            appDBContent.MeetingAssignmentModel.Add(new MeetingAssignmentModel
            {
                Id = id,
                MeetingId = meetingId,
                Asignment = asignment,
                RedLine = redLine,
                Responsible = responsible
            });

            appDBContent.SaveChanges();
        }

        public void DeleteMeetingAssignmentModel(String id)
        {

            var assignment = appDBContent.MeetingAssignmentModel.Find(id);

            try
            {
                if (assignment != null && appDBContent.MeetingAssignmentModel.Contains(assignment))
                {
                    appDBContent.MeetingAssignmentModel.Remove(assignment);
                    appDBContent.SaveChangesAsync();
                }
            }
            catch (Exception e)
            {
                ///////////
            }
        }

        public List<MeetingAssignmentModel> GetMeetingAssignmentModel()
        {
            return appDBContent.MeetingAssignmentModel.ToList();
        }
    }
}
