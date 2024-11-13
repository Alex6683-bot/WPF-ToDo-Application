using System.IO.Packaging;
using ToDo.MVMM.Models;
using ToDo.MVMM.Utilities;
using System.Windows.Media;

namespace ToDo.MVMM.ViewModels
{
    class MainViewModel : ViewModelBase
    {
        NavigationHandler navigation;

        public string UserName { get => Environment.UserName; }
        public ViewModelBase CurrentViewModel
        {
            get => navigation.CurrentViewModel;
        }

        public MainViewModel(NavigationHandler navigation) : base(navigation)
        {
            this.navigation = navigation;
            navigation.CurrentViewModel = new TasksListViewModel(navigation);

            navigation.ViewModelChangedEvent += OnCurrentViewModelChanged;
            //navigation.CurrentViewModel = new EditTaskViewModel(navigation, new TaskObject("Do Something with my life", new SolidColorBrush(Colors.LightBlue)));
            
        }

        void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}