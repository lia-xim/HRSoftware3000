using HRSoftware3000.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
            if (Application.Current.MainWindow.Visibility == Visibility.Visible)
            {
                RoutedEvent[] events = EventManager.GetRoutedEventsForOwner(typeof(Button));
                /*
                foreach (RoutedEvent e in events)
                    elem.AddHandler(e, handler);

                employees main = new employees();
                if (main.AddEmplyeeBtn.IsEnabled)
                {
                    if (main.addEmplyeeBtnClicked == true)
                    {
                        main.addEmplyeeBtnClicked = false;
                        MainWindowFrame.Source = new Uri("Pages/employeesAddPage.xaml", UriKind.Relative);
                    }
                }
                */
            }
        }

        private void goToDashboard(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.Source = new Uri("Pages/dashboard.xaml", UriKind.Relative);
        }

        private void goToEmployees(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.Source = new Uri("Pages/employees.xaml", UriKind.Relative);
        }

        private void goToProjects(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.Source = new Uri("Pages/projects.xaml", UriKind.Relative);
        }

        private void goToGanttDiagrammPage(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.Source = new Uri("Pages/ganttDiagrammPage.xaml", UriKind.Relative);
        }
        private void goToProjectUpdatePage(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.Source = new Uri("Pages/projectUpdatePage.xaml", UriKind.Relative);
        }
        private void goToProjectAddPage(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.Source = new Uri("Pages/projectAddPage.xaml", UriKind.Relative);
        }

        internal static Window GetWindow()
        {
            throw new NotImplementedException();
        }
    }
}
