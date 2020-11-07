using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tablet.Data.interfaces;
using Tablet.Data.Models;

namespace Tablet.Data.mocks
{
    public class MockProject : IProject

    {

        IEnumerable<Project> IProject.AllProjects { 
            get
            {
                List<String> problem = new List<string>();
                problem.Add("Спроектировать ИСУГ");
                problem.Add("Разработать ИСУГ");
                return new List<Project>
                {

                    new Project {name = "U019292", customer = "Серегин С.Ю.", developer = "Селин Т.Е.", technology = "WF", cost = 120000}
                };
            }
        }

        public Project getProject(int projectId)
        {
            throw new NotImplementedException();
        }
    }
}
