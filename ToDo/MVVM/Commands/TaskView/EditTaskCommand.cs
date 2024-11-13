using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using ToDo.MVMM.Models;
using ToDo.MVMM.Utilities;
using ToDo.MVMM.ViewModels;

namespace ToDo.MVVM.Commands
{
    class EditTaskCommand : CommandBase
    {
        TasksListViewModel TaskListVM;
        NavigationHandler Navigation;

        public EditTaskCommand(TasksListViewModel tasksListViewModel, NavigationHandler navigation) 
        {
            this.TaskListVM = tasksListViewModel;
            this.Navigation = navigation;
        }
        public override void Execute(object? parameter)
        {
            TaskListVM.IsEditing = TaskListVM.IsEditing ? false : true;
            if (TaskListVM.IsEditing)
            {
                TaskListVM.EditTaskVM = new EditTaskViewModel(Navigation, (TaskObject)((ListViewItem)(parameter)).Content, TaskListVM);
            }
        }
    }
}
