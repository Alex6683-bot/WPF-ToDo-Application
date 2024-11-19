using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using ToDo.MVVM.Models;
using ToDo.MVVM.Utilities;
using ToDo.MVVM.ViewModels;

namespace ToDo.MVVM.Commands
{
    class DeleteTaskCommand : CommandBase
    {
        TasksListViewModel TasksListViewModel;

        public DeleteTaskCommand(TasksListViewModel tasksListViewModel)
        {
            this.TasksListViewModel = tasksListViewModel;
        }
        public override void Execute(object? parameter)
        {
            ListViewItem item = (ListViewItem)parameter;
            TasksListViewModel.Tasks.Remove((TaskObject)item.Content);
            TaskSerialization.Serialize(TasksListViewModel.Tasks);

        }
    }
}
