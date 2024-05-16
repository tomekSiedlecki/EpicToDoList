using EpicToDoList.viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EpicToDoList.commands
{
    public class AssignmentClickCommand : CommandBase
    {
        AssignmentViewModel assignmentViewModel;
        public AssignmentClickCommand(AssignmentViewModel assignmentViewModel) 
        { 
            this.assignmentViewModel = assignmentViewModel;
        }
        public override void Execute(object? parameter)
        {
            assignmentViewModel.IsChecked = !assignmentViewModel.IsChecked;
        }
    }
}
