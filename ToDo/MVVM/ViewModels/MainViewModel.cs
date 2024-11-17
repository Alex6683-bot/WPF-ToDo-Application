using System.IO.Packaging;
using ToDo.MVVM.Models;
using ToDo.MVVM.Utilities;
using System.Windows.Media;
using System.Windows.Input;
using ToDo.MVVM.Commands;

namespace ToDo.MVVM.ViewModels
{
    class MainViewModel : ViewModelBase
    {
        NavigationHandler navigation;

        public string UserName { get => Environment.UserName; }
        public ICommand NavigationCommand { get; }

        //ViewModels
        public readonly TasksListViewModel tasksListViewModel;
        public readonly AboutViewModel aboutViewModel;

        public ViewModelBase CurrentViewModel
        {
            get => navigation.CurrentViewModel;
        }

        public MainViewModel(NavigationHandler navigation) : base(navigation)
        {
            this.navigation = navigation;

            tasksListViewModel = new TasksListViewModel(navigation);
            tasksListViewModel.EditTaskVM = new EditTaskViewModel(navigation, new TaskObject("hh", new SolidColorBrush(Colors.White)), tasksListViewModel);

            aboutViewModel = new AboutViewModel(navigation);

            NavigationCommand = new NavigationCommand(this, navigation);
            navigation.CurrentViewModel = tasksListViewModel;

            navigation.ViewModelChangedEvent += OnCurrentViewModelChanged;
            //navigation.CurrentViewModel = new EditTaskViewModel(navigation, new TaskObject("Do Something with my life", new SolidColorBrush(Colors.LightBlue)));
            
        }

        void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}