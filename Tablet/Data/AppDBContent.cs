﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tablet.Data.Models;

namespace Tablet.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent()
        {
        }

        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {

        }

        public DbSet<Project> Project { get; set; }
        public DbSet<GeneralDevelopment> GeneralDevelopmentModels { get; set; }
        public DbSet<Structure> Structures { get; set; }
        public DbSet<ProjectProblems> ProjectProblems {get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Stages> Stages { get; set; }
        public DbSet<ProjectGeneralProblems> ProjectGeneralProblems { get; set; }
        public DbSet<ProjectGeneralWorks> ProjectGeneralWorks { get; set; }
        public DbSet<ProjectRisks> ProjectRisks { get; set; }
        public DbSet<InformationModel> InformationModel { get; set; }
        public DbSet<Agenda> Agenda { get; set; }
        public DbSet<MeetingModel> MeetingModel { get; set; }
        public DbSet<MeetingAssignmentModel> MeetingAssignmentModel { get; set; }
        public DbSet<Restrictions> RestrictionsModel { get; set; }

        public String ProjectId { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProjectGeneralProblems>().HasQueryFilter(u => u.ProjectId.Equals(this.ProjectId));
            modelBuilder.Entity<ProjectGeneralWorks>().HasQueryFilter(u => u.ProjectId.Equals(this.ProjectId));
            modelBuilder.Entity<ProjectProblems>().HasQueryFilter(u => u.ProjectId.Equals(this.ProjectId));
            modelBuilder.Entity<ProjectRisks>().HasQueryFilter(u => u.ProjectId.Equals(this.ProjectId));
            modelBuilder.Entity<Stages>().HasQueryFilter(u => u.ProjectId.Equals(this.ProjectId));


            base.OnModelCreating(modelBuilder);
        }
    }
}
