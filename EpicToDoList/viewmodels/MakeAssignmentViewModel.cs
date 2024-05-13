using EpicToDoList.commands;
using EpicToDoList.models;
using EpicToDoList.services;
using EpicToDoList.stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EpicToDoList.viewmodels
{
    public class MakeAssignmentViewModel : ViewModelBase
    {
		private bool _isChecked;

		public bool IsChecked
        {
			get { return _isChecked; }
			set { _isChecked = value;
                OnPropertyChanged(nameof(IsChecked)); }
		}

        private string _content;

        public string Content
        {
            get { return _content; }
            set { _content = value; 
                OnPropertyChanged(nameof(Content)); }
        }
        public ICommand SubmitCommand { get; }
        public ICommand CancelCommand { get; }

        public MakeAssignmentViewModel(AssignmentList assignmentList,NavigationService assignmentListingNavigationService)
        {
            SubmitCommand = new MakeAssignmentCommand(assignmentList,this, assignmentListingNavigationService);
            CancelCommand = new NavigateCommand(assignmentListingNavigationService);
        }


    }
}
