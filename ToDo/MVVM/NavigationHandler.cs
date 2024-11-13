using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.MVMM.Utilities;
using ToDo.MVMM.ViewModels;

namespace ToDo
{
    class NavigationHandler
    {

        private ViewModelBase currentViewModel;

        public ViewModelBase CurrentViewModel
        {
            get => currentViewModel;
            set
            {
                if (currentViewModel != value)
                {
                    currentViewModel = value;
                    ViewModelChangedEvent?.Invoke();
                }
            }
        }

        public Action ViewModelChangedEvent;
    }
}
