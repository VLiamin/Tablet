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

                    new Project {Name = "U019292", Customer = "Серегин С.Ю.", Developer = "Селин Т.Е.", Technology = "WF", Cost = 120000}
                };
            }
        }

        public Project getProject(int projectId)
        {
            throw new NotImplementedException();
        }
    }
}
