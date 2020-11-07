using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tablet.Data.Models;

namespace Tablet.Data.interfaces
{
    public interface IProject
    {
        IEnumerable<Project> AllProjects { get; }
        Project getProject(int projectId);
    }
}
