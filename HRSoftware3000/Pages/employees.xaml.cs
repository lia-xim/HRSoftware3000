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

namespace HRSoftware3000.Pages
{
    /// <summary>
    /// Interaktionslogik für employees.xaml
    /// </summary>
    public partial class employees : Page
    {
        public Boolean addEmplyeeBtnClicked;

        public employees()
        {
            InitializeComponent();
        }

        private void goToEmployeesAddPage(object sender, RoutedEventArgs e)
        {
            Window window = new employeesAddPage();  
            window.Show();
            /*
            addEmplyeeBtnClicked = true;
            if (Application.Current.MainWindow.Visibility == Visibility.Visible)
            {
                MainWindow main = new MainWindow();
                main.MainWindowFrame.Source = new Uri("Pages/employeesAddPage.xaml", UriKind.Relative);
            }
            */
        }

        private void goToEmployeesUpdatePage(object sender, RoutedEventArgs e)
        {
            if (Application.Current.MainWindow.Visibility == Visibility.Visible)
            {
                MainWindow main = new MainWindow();
                main.MainWindowFrame.Source = new Uri("Pages/employeesUpdatePage.xaml", UriKind.Relative);
            }
        }
    }
}
