using EpicToDoList.models;
using EpicToDoList.services.contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace EpicToDoList.services
{
    public class DbService
    {
        public void SaveAssignments(IEnumerable<Assignment> _assignments)
        {
            using (AssignmentContext context = new AssignmentContext())
            {
                //usuwa wsystkie elementy
                context.Assignments.RemoveRange(context.Assignments.ToList());

                foreach(Assignment assignment in _assignments)
                {
                    context.Assignments.Add(assignment);
                }
                context.SaveChanges();
            }
        }

        public IEnumerable<Assignment> GetAllAssignments()
        {
            using (AssignmentContext context = new AssignmentContext())
            {
                var result = context.Assignments.ToList();
                return result;
            }
        }
    }
}
