using System.Collections.ObjectModel;
using System.Security.Policy;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using ToDo.MVVM.Models;
using ToDo.MVVM.Utilities;
using ToDo.MVVM.Commands;

namespace ToDo.MVVM.ViewModels
{
    class TasksListViewModel : ViewModelBase
    {
        private TaskObject selectedTask;
        private EditTaskViewModel editTaskVM;
        private bool isEditing;
        private string addTaskName = "";

        private ObservableCollection<TaskObject> tasks = new ObservableCollection<TaskObject>();

        public bool IsEditing
        {
            get => isEditing;
            set
            {
                if (value != isEditing) 
                {
                    isEditing = value;
                    OnPropertyChanged();
                }
            }
        }

        public EditTaskViewModel EditTaskVM
        {
            get => editTaskVM;
            set
            {
                if (value != editTaskVM)
                {
                    editTaskVM = value;
                    OnPropertyChanged();
                }
            }
        }
        public ObservableCollection<TaskObject> Tasks
        {
            get => tasks;
            set
            {
                if (tasks != value)
                {
                    tasks = value;
                    OnPropertyChanged();
                }
            }
        }
        public TaskObject SelectedTask 
        {
            get
            {
                return selectedTask;
            }
            set
            {
                if (value != selectedTask)
                {
                    selectedTask = value;
                    OnPropertyChanged();
                }
            }
        }

        public string AddTaskName
        {
            get => addTaskName;
            set
            {
                if (value != addTaskName)
                {
                    addTaskName = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand TestCommand { get; }
        public ICommand AddTaskCommand { get; }
        public ICommand DeleteTaskCommand { get; }
        public ICommand EditTaskCommand { get; }

        public TasksListViewModel(NavigationHandler navigation) : base(navigation)
        {
            DeleteTaskCommand = new DeleteTaskCommand(this);
            EditTaskCommand = new EditTaskCommand(this, navigation);
            AddTaskCommand = new AddTaskCommand(this, navigation);

            this.navigation = navigation;

            IsEditing = false;

            tasks = TaskSerialization.Deserialize();
            //editTaskVM = new EditTaskViewModel(navigation, new TaskObject(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Tasks", new SolidColorBrush(Colors.Red)), this);
            //Tasks.Add(new TaskObject(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Tasks", new SolidColorBrush(Colors.LightBlue), new DateTime(2024, 11, 5), new DateTime(2024, 11, 6)));


        }
    }
}
