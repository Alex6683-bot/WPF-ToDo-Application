using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ToDo.MVVM.Utilities
{
    class ViewModelBase : INotifyPropertyChanged
    {
        protected NavigationHandler navigation;
        public event PropertyChangedEventHandler? PropertyChanged;

        public ViewModelBase(NavigationHandler navigation)
        {
            this.navigation = navigation;
        }

        public void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
