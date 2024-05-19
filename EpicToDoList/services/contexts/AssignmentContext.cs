using EpicToDoList.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace EpicToDoList.services.contexts
{
    class AssignmentContext : DbContext
    {
        public DbSet<Assignment> Assignments { get; set; }
        
        public string DbPath { get; }

        public AssignmentContext()
        {
            DbPath = "assignments.db";
        }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
    }
}
