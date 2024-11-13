using System.IO;
using System.Windows;

namespace ToDo
{
    public partial class MainWindow : Window
    {
        
        public string UserName { get => Environment.UserName; }
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
        }

        private void Resize_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Maximized)
            {
                WindowState = WindowState.Normal;
                this.BorderThickness = new System.Windows.Thickness(0.5);
            }
            else if (WindowState == WindowState.Normal)
            {
                WindowState = WindowState.Maximized;
                this.BorderThickness = new System.Windows.Thickness(5);
            }
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Minimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void TitleBar_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            DragMove();
            if (WindowState == WindowState.Maximized) this.BorderThickness = new System.Windows.Thickness(5);
        }
    }
}