using System.Windows.Input;
using System.Windows.Media;
using ToDo.MVMM.Models;
using ToDo.MVMM.Utilities;
using ToDo.MVVM.Commands;

namespace ToDo.MVMM.ViewModels
{
    class EditTaskViewModel : ViewModelBase
    {
        private bool isEnabled = true;
        private TaskObject task;

        public bool IsEnabled
        {
            get => isEnabled;
            set
            {
                if (isEnabled != value)
                {
                    isEnabled = value;
                    OnPropertyChanged();
                }
            }
        }
        public TaskObject Task 
        {
            get => task;
            set
            {
                if (value != task)
                {
                    task = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand Submit { get; }


        public DateTime StartDate
        {
            get => task.StartDate;
            set
            {
                if (value != task.StartDate)
                {
                    task.StartDate = value;
                    OnPropertyChanged();
                }
            }
        }

        public DateTime EndDate
        {
            get => task.EndDate;
            set
            {
                if (value != task.EndDate)
                {
                    task.EndDate = value;
                    OnPropertyChanged();

                }
            }
        }

        public SolidColorBrush ColorTag
        {
            get => task.ColorTag;
            set
            {
                if (value != task.ColorTag)
                {
                    task.ColorTag = value;
                    OnPropertyChanged();

                }
            }
        }

        public string Name
        {
            get => task.Name;
            set
            {
                if (value != task.Name)
                {
                    task.Name = value;
                    OnPropertyChanged();

                }
            }
        }

        public ICommand SubmitCommand { get; set; }

        public EditTaskViewModel(NavigationHandler navigation, TaskObject task, TasksListViewModel tasksListViewModel) : base (navigation)
        {
            SubmitCommand = new SubmitCommand(tasksListViewModel, this);
            this.task = task;
        }
    }
}
