using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.MVVM.Utilities;
using ToDo.MVVM.ViewModels;

namespace ToDo.MVVM.Commands
{
    class TestCommand : CommandBase
    {
        NavigationHandler navigation;
        public TestCommand(NavigationHandler navigation)
        {
            this.navigation = navigation;
        }

        public override void Execute(object? parameter)
        {
            throw new NotImplementedException();
        }
    }
}
