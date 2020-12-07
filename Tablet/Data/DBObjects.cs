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
                    new Project { Name = "U019292", Customer = "Серегин С.Ю.", Developer = "Селин Т.Е.", Technology = "WF", Cost = 120000 }
                    );

            }
            content.SaveChanges();
        }
    }
}
