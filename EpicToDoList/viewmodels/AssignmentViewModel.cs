using EpicToDoList.commands;
using EpicToDoList.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EpicToDoList.viewmodels
{
    public class AssignmentViewModel : ViewModelBase
    {
        private readonly Assignment _assignment;

        public string Content => _assignment.Content.ToString();

        public bool IsChecked
        {
            get => _assignment.IsChecked;
            set
            {
                if (_assignment.IsChecked != value)
                {
                    _assignment.IsChecked = value;
                    OnPropertyChanged(nameof(IsChecked));
                    footerViewModel.UpdateDoneValues();
                }
            }
        }

        public ICommand ChangeIsCheckedCommand { get; }

        public FooterViewModel footerViewModel { get; }

        public AssignmentViewModel(Assignment assignment, FooterViewModel footerViewModel)
        {
            _assignment = assignment;
            ChangeIsCheckedCommand = new AssignmentClickCommand(this);
            this.footerViewModel = footerViewModel;
        }
    }
}
