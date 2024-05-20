using EpicToDoList.commands;
using EpicToDoList.models;
using EpicToDoList.services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EpicToDoList.viewmodels
{
    public class AssignmentListingViewModel : ViewModelBase
    {
        private readonly AssignmentList _assignmentList;
        private readonly ObservableCollection<AssignmentViewModel> _assignments;

        public IEnumerable<AssignmentViewModel> Assignments => _assignments;

        public FooterViewModel footerViewModel { get; set; }

        public ICommand MakeAssignmentCommand { get; }



        public AssignmentListingViewModel(AssignmentList assignmentList, NavigationService makeAssignmentNavigationService)
        {
            MakeAssignmentCommand = new NavigateCommand(makeAssignmentNavigationService);
            footerViewModel = new FooterViewModel(assignmentList);

            _assignmentList = assignmentList;
            _assignments = new ObservableCollection<AssignmentViewModel>();
            UpdateAssignments();

        }

        private void UpdateAssignments()
        {
            _assignments.Clear();
            foreach (Assignment assignment in _assignmentList.GetAllAssignments())
            {
                //tworze nowy viemodel bo observable collection pracuej na viewmodelach
                AssignmentViewModel newAssignmentViewModel = new AssignmentViewModel(assignment, footerViewModel);
                //zapisanie do obesrable collection
                _assignments.Add(newAssignmentViewModel);
            }
        }
    }
}
