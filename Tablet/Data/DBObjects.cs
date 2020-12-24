using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tablet.Data.Models;

namespace Tablet.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            content.Project.RemoveRange();
            content.SaveChanges();
        }
    }
}
