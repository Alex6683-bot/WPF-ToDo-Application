using System.Windows.Input;
using System.Windows.Media;
using ToDo.MVVM.Models;
using ToDo.MVVM.Utilities;
using ToDo.MVVM.Commands;

namespace ToDo.MVVM.ViewModels
{
    class EditTaskViewModel : ViewModelBase
    {
        private bool isEnabled = true;
        private TaskObject task;

        private bool submittable = true;


        public bool Submittable
        {
            get => submittable;
            set
            {
                if (value != submittable)
                {
                    submittable = value;
                    OnPropertyChanged();
                    ((CommandBase)SubmitCommand).OnCanExecuteChanged();
                }
            }
        }

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

        public DateTime StartDate
        {
            get => task.StartDate;
            set
            {
                if (value != task.StartDate)
                {
                    task.StartDate = value;
                    Submittable = (StartDate > EndDate) ? false : true;
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
                    Submittable = (StartDate > EndDate) ? false : true;
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

        public ICommand SubmitCommand { get; }

        public EditTaskViewModel(NavigationHandler navigation, TaskObject task, TasksListViewModel tasksListViewModel) : base (navigation)
        {
            SubmitCommand = new SubmitCommand(tasksListViewModel, this);
            this.task = task;
            Submittable = (StartDate > EndDate) ? false : true;
        }

    }
}
