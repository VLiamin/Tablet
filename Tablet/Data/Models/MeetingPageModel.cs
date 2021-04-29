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

        public List<MeetingModel> MeetingModel { get; set; }

        public void AddToMeeting(String id, String meetingId, int number, 
            String question, String comment, String suggestion)
        {

            appDBContent.MeetingModel.Add(new MeetingModel
            {
                Id = id,
                MeetingId = meetingId,
                Number = number,
                Question = question,
                Comment = comment,
                Suggestion = suggestion
            });

            appDBContent.SaveChanges();
        }

        public void DeleteMeeting(String id)
        {

            var meeting = appDBContent.MeetingModel.Find(id);

            try
            {
                if (meeting != null && appDBContent.MeetingModel.Contains(meeting))
                {
                    appDBContent.MeetingModel.Remove(meeting);
                    appDBContent.SaveChangesAsync();
                }
            }
            catch (Exception e)
            {
                ///////////
            }
        }

        public List<MeetingModel> GetMeetingModels()
        {
            return appDBContent.MeetingModel.ToList();
        }


        public List<ListOfMeetingsModel> ListOfMeetings { get; set; }

        public void AddToListOfMeetings(String id, int number, String projectId)
        {

            appDBContent.ListOfMeetingsModel.Add(new ListOfMeetingsModel
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

        public List<ListOfMeetingsModel> GetListOfMeetingsModel()
        {
            return appDBContent.ListOfMeetingsModel.ToList();
        }

        public List<MeetingAssignmentModel> MeetingAssignment { get; set; }

        public void AddToMeetingAssignments(String id, int number, String projectId)
        {

            appDBContent.MeetingAssignmentModel.Add(new MeetingAssignmentModel
            {

            });

            appDBContent.SaveChanges();
        }

        public void DeleteMeetingAssignmentModel(String id, String projectId)
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

        public List<MeetingAssignmentModel> GetMeetingAssignmentModel()
        {
            return appDBContent.MeetingAssignmentModel.ToList();
        }
    }
}
