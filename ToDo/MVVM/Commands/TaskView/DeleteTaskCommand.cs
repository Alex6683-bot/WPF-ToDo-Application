using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using ToDo.MVMM.Models;
using ToDo.MVMM.Utilities;
using ToDo.MVMM.ViewModels;

namespace ToDo.MVVM.Commands
{
    class DeleteTaskCommand : CommandBase
    {
        TasksListViewModel tasksListViewModel;

        public DeleteTaskCommand(TasksListViewModel tasksListViewModel)
        {
            this.tasksListViewModel = tasksListViewModel;
        }
        public override void Execute(object? parameter)
        {
            ListViewItem item = (ListViewItem)parameter;
            tasksListViewModel.Tasks.Remove((TaskObject)item.Content);
        }
    }
}
