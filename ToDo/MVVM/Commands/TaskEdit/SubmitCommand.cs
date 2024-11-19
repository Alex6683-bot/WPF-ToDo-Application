using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.MVVM.Utilities;
using ToDo.MVVM.Models;
using ToDo.MVVM.ViewModels;

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
            if (string.IsNullOrEmpty(EditTaskViewModel.Task.Name)) EditTaskViewModel.Task.Name = "New Task";
            if (!TasksListViewModel.Tasks.Contains(EditTaskViewModel.Task)) TasksListViewModel.Tasks.Add(EditTaskViewModel.Task);

            EditTaskViewModel.Task.UpdateProperties();
            TasksListViewModel.IsEditing = false;

            TaskSerialization.Serialize(TasksListViewModel.Tasks);
        }

        public override bool CanExecute(object? parameter) => EditTaskViewModel.Submittable;


    }
}
