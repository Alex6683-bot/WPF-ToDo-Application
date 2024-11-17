using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ToDo.MVVM.ViewModels;

namespace ToDo.MVVM.Views
{
    /// <summary>
    /// Interaction logic for TasksView.xaml
    /// </summary>
    public partial class TasksView : UserControl
    {
        Border border = new Border();
        public TasksView()
        {
            InitializeComponent();
        }

        private void Popup_Closed(object sender, EventArgs e)
        {
            if (!((TasksListViewModel)DataContext).IsEditing)
            {
                MainGrid.Children.Remove(border);
            }
        }

        private void Task_Edit_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (!((TasksListViewModel)DataContext).IsEditing)
            {
                border.Background = Brushes.Transparent;

                Grid.SetRow(border, 0);
                Grid.SetRowSpan(border, 1);
                MainGrid.Children.Add(border);
            }
        }
    }
}
