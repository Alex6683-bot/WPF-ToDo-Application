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
        TasksListViewModel tasksListViewModel;
        private TasksListViewModel tasksListViewModel1;

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
