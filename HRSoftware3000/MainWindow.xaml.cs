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

namespace HRSoftware3000
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void goToDashboard(object sender, RoutedEventArgs e)
        {
            mainWindowFrame.Source = new Uri("Pages/dashboard.xaml", UriKind.Relative);
        }

        private void goToEmployees(object sender, RoutedEventArgs e)
        {
            mainWindowFrame.Source = new Uri("Pages/employees.xaml", UriKind.Relative);
        }

        private void goToProjects(object sender, RoutedEventArgs e)
        {
            mainWindowFrame.Source = new Uri("Pages/projects.xaml", UriKind.Relative);
        }
    }
}
