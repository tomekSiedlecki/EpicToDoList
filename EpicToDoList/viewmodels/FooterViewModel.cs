using EpicToDoList.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EpicToDoList.viewmodels
{
    public class FooterViewModel : ViewModelBase
    {
		private int done;
		public int Done
        {
			get { return done; }
			set { done = value;
                OnPropertyChanged(nameof(Done));
            }
		}

        private int notDone;
        public int NotDone
        {
            get { return notDone; }
            set
            {
                notDone = value;
                OnPropertyChanged(nameof(notDone));
            }
        }

        private readonly AssignmentList assignmentList;

        public FooterViewModel(AssignmentList assignmentList)
        {
            this.assignmentList = assignmentList;
            UpdateDoneValues();
        }

        public void UpdateDoneValues()
        {
            int doneCounter = 0;
            int notDoneCounter = 0;
            foreach (var item in assignmentList.GetAllAssignments())
            {
                if (item.IsChecked == true)
                {
                    doneCounter++;
                }
                else
                {
                    notDoneCounter++;
                }
            }
            Done = doneCounter;
            NotDone = notDoneCounter;

        }

    }
}
