﻿using System;
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

        public void AddToMeeting(String id, String number, String projectId, String problem)
        {

            appDBContent.MeetingModel.Add(new MeetingModel
            {
                
            });

            appDBContent.SaveChanges();
        }

        public void DeleteMeeting(String id, String projectId)
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

        public List<MeetingModel> GetMeetingModels()
        {
            return appDBContent.MeetingModel.ToList();
        }


        public List<ListOfMeetingsModel> ListOfMeetings { get; set; }

        public void AddToListOfMeetings(String id, String number, String projectId, String problem)
        {

            appDBContent.ListOfMeetingsModel.Add(new ListOfMeetingsModel
            {

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

    }
}
