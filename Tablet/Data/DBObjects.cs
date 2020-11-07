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

            if (!content.Project.Any())
            {
                content.AddRange(
                    new Project { name = "U019292", customer = "Серегин С.Ю.", developer = "Селин Т.Е.", technology = "WF", cost = 120000 }
                    );
            }
            content.SaveChanges();
        }
    }
}
