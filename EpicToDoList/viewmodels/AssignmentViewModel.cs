using EpicToDoList.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicToDoList.viewmodels
{
    public class AssignmentViewModel : ViewModelBase
    {
        private readonly Assignment _assignment;

        public string Content => _assignment.Content.ToString();
        public bool IsChecked => _assignment.IsChecked;
        public AssignmentViewModel(Assignment assignment)
        {
            _assignment = assignment;
        }
    }
}
