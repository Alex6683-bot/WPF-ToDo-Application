using System.Configuration;
using System.Data;
using System.Windows;
using ToDo.MVVM.ViewModels;

namespace ToDo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(new NavigationHandler())
            };

            MainWindow.Show();
            base.OnStartup(e);
        }
    }

}
