using EpicToDoList.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicToDoList.models
{
    public class AssignmentList
    {
        private List<Assignment> _assignments;


        public void AddAssignment(Assignment newAssignment)
        {
            _assignments.Add(newAssignment);
        }

        public IEnumerable<Assignment> GetAllAssignments()
        {
            return _assignments;
        }


        public AssignmentList(IEnumerable<Assignment> assignments)
        {
            _assignments = assignments.ToList();
        }
    }
}
