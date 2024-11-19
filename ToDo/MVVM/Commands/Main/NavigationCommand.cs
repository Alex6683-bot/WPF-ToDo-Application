using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using ToDo.MVVM.Utilities;
using ToDo.MVVM.ViewModels;

namespace ToDo.MVVM.Commands
{
    class NavigationCommand : CommandBase
    {
        MainViewModel MainViewModel;
        NavigationHandler Navigation;

        public NavigationCommand(MainViewModel mainViewModel, NavigationHandler navigation)
        {
            this.MainViewModel = mainViewModel;
            this.Navigation = navigation;
        }
        public override void Execute(object? parameter)
        {
            RadioButton radioButton = (RadioButton)parameter;
            switch (radioButton.Name)
            {
                case "My_Tasks":
                    Navigation.CurrentViewModel = MainViewModel.TasksListViewModel;
                    return;
                case "About":
                    Navigation.CurrentViewModel = MainViewModel.AboutViewModel;
                    return;
            }
        }
    }
}
