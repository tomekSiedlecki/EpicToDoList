using EpicToDoList.models;
using EpicToDoList.services;
using EpicToDoList.viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EpicToDoList.commands
{
    class MakeAssignmentCommand : CommandBase
    {
        private readonly AssignmentList _assignmentList;
        private readonly MakeAssignmentViewModel _makeAssignmentViewModel;
        private readonly NavigationService assignmentListingViewNavigationService;

        public MakeAssignmentCommand(AssignmentList _assignmentList, MakeAssignmentViewModel _makeAssignmentViewModel, NavigationService AssignmentListingViewNavigationService)
        {
            this._assignmentList = _assignmentList;
            this._makeAssignmentViewModel = _makeAssignmentViewModel;
            assignmentListingViewNavigationService = AssignmentListingViewNavigationService;
        }


        public override void Execute(object? parameter)
        {
            Assignment newAssignment = new Assignment(_makeAssignmentViewModel.Content, _makeAssignmentViewModel.IsChecked);

            _assignmentList.AddAssignment(newAssignment);

            assignmentListingViewNavigationService.Navigate();
        }
    }
}
