using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tablet.Data.Models;

namespace Tablet.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {

        }
         
        public DbSet<Project> Project { get; set; }
        public DbSet<GeneralDevelopment> GeneralDevelopmentModels { get; set; }
        public DbSet<Structure> Structures { get; set; }
    }
}
