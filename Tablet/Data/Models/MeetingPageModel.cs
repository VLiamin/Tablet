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

        public List<MeetingModel> meetingModel { get; set; }

        public void AddToMeeting(String id, String number, String projectId, String problem)
        {

            appDBContent.MeetingModel.Add(new MeetingModel
            {
                
            });

            appDBContent.SaveChanges();
        }

        public void DeleteProjectProblems(String id, String projectId)
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

        public List<ProjectProblems> GetProjectProblemsModels()
        {
            return appDBContent.ProjectProblems.ToList();
        }

    }
}
