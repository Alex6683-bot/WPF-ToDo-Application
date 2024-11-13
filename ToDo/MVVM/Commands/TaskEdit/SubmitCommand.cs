using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.MVMM.Utilities;
using ToDo.MVMM.Models;
using ToDo.MVMM.ViewModels;

namespace ToDo.MVVM.Commands
{
    class SubmitCommand : CommandBase
    {
        TasksListViewModel TasksListViewModel;
        EditTaskViewModel EditTaskViewModel;

        public SubmitCommand(TasksListViewModel tasksListViewModel, EditTaskViewModel editTaskViewModel)
        {
            TasksListViewModel = tasksListViewModel;
            EditTaskViewModel = editTaskViewModel;
        }

        public override void Execute(object? parameter)
        {
            TasksListViewModel.IsEditing = false;
            if (!TasksListViewModel.Tasks.Contains(EditTaskViewModel.Task)) TasksListViewModel.Tasks.Add(EditTaskViewModel.Task);

            EditTaskViewModel.Task.UpdateProperties();
        }
    }
}
