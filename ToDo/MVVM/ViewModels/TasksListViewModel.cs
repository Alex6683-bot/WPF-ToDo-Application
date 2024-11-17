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
        public ObservableCollection<TaskObject> Tasks { get; } = new ObservableCollection<TaskObject>();
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
            //editTaskVM = new EditTaskViewModel(navigation, new TaskObject("Hi", new SolidColorBrush(Colors.Red)), this);
            //Tasks.Add(new TaskObject("Delete Microsoft Edge", new SolidColorBrush(Colors.LightBlue), new DateTime(2024, 11, 5), new DateTime(2024, 11, 6)));
            //Tasks.Add(new TaskObject("Visit Taco Bell and rate their fries", new SolidColorBrush(Colors.Red), new DateTime(2024, 11, 7), new DateTime(2024, 11, 8)));
            //Tasks.Add(new TaskObject("Commit some commits", new SolidColorBrush(Colors.Gray), new DateTime(2024, 11, 9), new DateTime(2024, 11, 10)));
            //Tasks.Add(new TaskObject("Be extra lazy about sit-ups today", new SolidColorBrush(Colors.Pink), new DateTime(2024, 11, 11), new DateTime(2024, 11, 12)));
            //Tasks.Add(new TaskObject("Wake up at 2:55 AM and read scary Wikipedia pages", new SolidColorBrush(Colors.Violet), new DateTime(2024, 11, 13), new DateTime(2024, 11, 14)));
            //Tasks.Add(new TaskObject("Binge-listen to '80s rock songs all night", new SolidColorBrush(Colors.Cyan), new DateTime(2024, 11, 15), new DateTime(2024, 11, 16)));
            //Tasks.Add(new TaskObject("Plan a no-exercise day and stick to it", new SolidColorBrush(Colors.Orange), new DateTime(2024, 11, 17), new DateTime(2024, 11, 18)));
            //Tasks.Add(new TaskObject("Wake up at 1:59 AM and play horror games", new SolidColorBrush(Colors.LightGreen), new DateTime(2024, 11, 19), new DateTime(2024, 11, 20)));
            //Tasks.Add(new TaskObject("Write a novel in 2 hours, be proud even if it's 2 sentences", new SolidColorBrush(Colors.Yellow), new DateTime(2024, 11, 21), new DateTime(2024, 11, 22)));
            //Tasks.Add(new TaskObject("Write a review of Google Chrome, including complaints", new SolidColorBrush(Colors.Black), new DateTime(2024, 11, 23), new DateTime(2024, 11, 24)));
            //Tasks.Add(new TaskObject("Try making breakfast with closed eyes", new SolidColorBrush(Colors.DarkBlue), new DateTime(2024, 11, 25), new DateTime(2024, 11, 26)));

        }
    }
}
