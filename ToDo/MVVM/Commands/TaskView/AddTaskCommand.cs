using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.MVVM.Utilities;
using ToDo.MVVM.ViewModels;
using ToDo.MVVM.Models;
using System.Windows.Media;

namespace ToDo.MVVM.Commands
{
    class AddTaskCommand : CommandBase
    {
        TasksListViewModel TasksListViewModel;
        NavigationHandler Navigation;

        public AddTaskCommand(TasksListViewModel tasksListViewModel, NavigationHandler navigation)
        {
            TasksListViewModel = tasksListViewModel;
            this.Navigation = navigation;

        }

        public override void Execute(object? parameter)
        {
            TasksListViewModel.EditTaskVM = new EditTaskViewModel(Navigation, new TaskObject(TasksListViewModel.AddTaskName, new SolidColorBrush(Colors.LightBlue)), TasksListViewModel);
            TasksListViewModel.IsEditing = true;
        }
    }
}
